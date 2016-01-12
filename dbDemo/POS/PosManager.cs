using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace dbDemo
{
    class PosManager:IDisposable
    {
        public delegate void DataChangedEventHandler(Object sender, DataChangedEventArgs e);
        public event DataChangedEventHandler dataChanged;

        public delegate void BillUpEventHandler(Object sender, BillUpEventArgs e);
        public event BillUpEventHandler BillUp;

        decimal sumFinal = 0;        //当前的合计金额合计
        int count = 0;      //当前的商品的数量合计
        DataTable dt;   //当前的商品清单
        SqlDataAdapter tradeDataAdapter,saleDataAdapter,vipDataAdapter;
        DataSet dataset;    //内存中的临时数据库

        private bool isVipMode = false;
        private string vipCode;

        private bool isBillUp = true;

        //构造函数
        public PosManager(TextBox tb_sum,TextBox tb_count,DataGridView dgv)
        {
            dt = new DataTable();
            dataset = new DataSet();
            //数据绑定
            dgv.DataSource = dt;

            connectToServer();
        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();
            
            try
            {
                conn.Open();

                tradeDataAdapter = new SqlDataAdapter("SELECT * FROM tb_trade", conn);
                saleDataAdapter = new SqlDataAdapter("SELECT * FROM tb_sale", conn);
                vipDataAdapter = new SqlDataAdapter("SELECT * FROM tb_vip", conn);

                //先获取所有商品信息填充到dataset去
                SqlCommand cmd = new SqlCommand("SELECT * FROM view_commodity_cashier", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable tb_commodity = new DataTable("commodity");
                tb_commodity.Load(reader);

                dataset.Tables.Add(tb_commodity);
                reader.Close();

                //获取tb_trade表
                tradeDataAdapter.Fill(dataset, "trade");

                //获取tb_sale表
                saleDataAdapter.Fill(dataset, "sale");

                //获取tb_vip表
                vipDataAdapter.Fill(dataset, "vip");

                StringBuilder builder = new StringBuilder();
                //获取当前的购物表模式
                //拼接select语句
                builder.Append("SELECT ");
                builder.Append("tb_commodity.s_code 条形码, ");
                builder.Append("tb_commodity.s_name 商品名, ");
                builder.Append("tb_commodity.s_price 商品单价, ");
                builder.Append("tb_sale.sale_count 数量, ");
                builder.Append("tb_sale.sale_amount 合计  ");
                builder.Append("FROM tb_commodity,tb_sale");

                SqlDataAdapter shoplistAdapter = new SqlDataAdapter(builder.ToString(), conn);
                shoplistAdapter.FillSchema(dt, SchemaType.Mapped);

                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(tradeDataAdapter);
                SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(saleDataAdapter);
                SqlCommandBuilder cmdBuilder3 = new SqlCommandBuilder(vipDataAdapter);
                SqlCommandBuilder cmdBuilder4 = new SqlCommandBuilder(shoplistAdapter);

            }
            catch (Exception e)
            {
                MessageBox.Show("连接至服务器失败，请检查连接！错误："+e.ToString(), "错误");
            }
            finally
            {
                conn.Close();
            }
        }

        public class BillUpEventArgs : EventArgs
        {
            public readonly decimal chargedSum, changeSum;
            public BillUpEventArgs(decimal chargedSum, decimal changeSum)
            {
                this.chargedSum = chargedSum;
                this.changeSum = changeSum;
            }
        }

        internal bool enterVipMode(string vipCode)
        {
            DataTable tb_vip = dataset.Tables["vip"];
            DataRow[] rows =  tb_vip.Select("vip_code = '" + vipCode + "'");
            if (rows.Count() == 1)
            {
                this.vipCode = vipCode;
                this.isVipMode = true;
                return true;
            }
            else
                return false;
        }

        public class DataChangedEventArgs : EventArgs
        {
            public readonly string billSum,Fav,billFinal,count;
            public DataChangedEventArgs(string billSum, string Fav, string billFinal,string count)
            {
                this.billSum = billSum;
                this.Fav = Fav;
                this.billFinal = billFinal;
                this.count = count;
            }
        }
        //通知已经完成结账操作
        private void onBillUpFinish(decimal charged)
        {
            decimal  changeSum;
            changeSum = charged - sumFinal;
            BillUpEventArgs args = new BillUpEventArgs(charged, changeSum);
            BillUp(this, args);
        }


        //用于通知数据发生改变
        protected virtual void onDataChanged()
        {
            if (dataChanged != null)
            {
                decimal sum, fav;
                if (isVipMode)
                {
                    sum = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        sum += (decimal)(row["合计"]);
                    }
                    sumFinal = sum * (decimal)0.95;
                    fav = sum - sumFinal;
                }
                else
                {
                    fav = 0;
                    sum = 0;
                    foreach(DataRow row in dt.Rows)
                    {
                        sum += (decimal)(row["合计"]);
                    }
                    sumFinal = sum - fav;
                }
                DataChangedEventArgs e = new DataChangedEventArgs(sum.ToString(), fav.ToString(), sumFinal.ToString(),count.ToString());
                dataChanged(this, e);
            }
        }

        public bool addToShopList(string code)
        {
            if (isBillUp)
            {
                deleteAll();
                isBillUp = false;
            }
            Regex reg = new Regex(@"(\d*)\+(\d*)");
            Match mat = reg.Match(code);
            if (mat.Groups.Count == 1)
            {
                //可能单纯是数字，进行查找
                DataTable s_dt = dataset.Tables["commodity"];
                DataRow[] result = s_dt.Select("s_code = '" + code +"'");
                if (result.Count() == 0)
                {
                    return false;
                }
                else
                {
                    if (Convert.ToBoolean(result[0]["is_allow_sale"]) == false)//不允许销售
                    {
                        return false;
                    }
                    //检查打折
                    if(Convert.ToBoolean(result[0]["is_discount"]) == true)
                    {
                        newRow(code, result[0]["s_name"].ToString(), (decimal)(result[0]["s_pro_price"]), 1);
                        count += 1;
                    }
                    else
                    {
                        newRow(code, result[0]["s_name"].ToString(), (decimal)(result[0]["s_price"]), 1);
                        count += 1;
                    }
                }
            }else if(mat.Groups.Count == 3)
            {
                DataTable s_dt = dataset.Tables["commodity"];
                DataRow[] result = s_dt.Select("s_code = '" + mat.Groups[2].Value.ToString() + "'");
                if (result.Count() == 0)
                {
                    return false;
                }
                else
                {
                    if (Convert.ToBoolean(result[0]["is_allow_sale"]) == false)//不允许销售
                    {
                        return false;
                    }
                    //检查打折
                    if (Convert.ToBoolean(result[0]["is_discount"]) == true)
                    {
                        newRow(mat.Groups[2].Value, result[0]["s_name"].ToString(), (decimal)(result[0]["s_pro_price"]), Convert.ToInt32(mat.Groups[1].Value));
                        count += Convert.ToInt32(mat.Groups[1].Value);
                    }
                    else
                    {
                        newRow(mat.Groups[2].Value, result[0]["s_name"].ToString(), (decimal)(result[0]["s_price"]), Convert.ToInt32(mat.Groups[1].Value));
                        count += Convert.ToInt32(mat.Groups[1].Value);
                    }
                }
            }
            else
            {
                return false;
            }
            onDataChanged();
            return true;
        }

        public void settle(decimal chargedSum)
        {
            //和数据库合并
            combineToDataset();
            onBillUpFinish(chargedSum);
            vipCode = "";
            isVipMode = false;
            isBillUp = true;
        }

        //结账时和数据连接合并
        private bool combineToDataset()
        {
            //添加到trade表
            DataTable tb_trade = dataset.Tables["trade"];
            DataRow row = tb_trade.NewRow();
            row["users_id"] = 0;
            row["trade_amount"] = sumFinal;
            if (isVipMode)
                row["vip_code"] = vipCode;
            else
                row["vip_code"] = DBNull.Value;
            row["trade_time"] = DateTime.Now.ToString();
            tb_trade.Rows.Add(row);
            tradeDataAdapter.Update(dataset,"trade");
            //重新fill，因为id会自我更新
            tradeDataAdapter.Fill(dataset, "trade");
            int lastTrade_id = Convert.ToInt32(tb_trade.Rows[tb_trade.Rows.Count-1]["trade_id"]);
            //添加到sale表
            DataTable tb_sale = dataset.Tables["sale"];
            foreach (DataRow r in dt.Rows)
            {
                row = tb_sale.NewRow();
                //查找s_id
                int s_id;
                DataRow[] rows = dataset.Tables["commodity"].Select("s_code = '" + r["条形码"] + "'");
                if (rows.Count() == 1)
                {
                    s_id = Convert.ToInt32(rows[0]["s_id"]);
                }
                else
                    return false;
                row["s_id"] = s_id;
                row["sale_count"] = r["数量"];
                row["sale_amount"] = r["合计"];
                row["trade_id"] = lastTrade_id;
                tb_sale.Rows.Add(row);
                saleDataAdapter.Update(dataset, "sale");
                //重新fill，因为id会自我更新
                saleDataAdapter.Fill(dataset, "sale");
            }
            //添加到VIP表
            if (isVipMode)
            {
                DataTable tb_vip = dataset.Tables["vip"];
                DataRow[] rows =  tb_vip.Select("vip_code = '" + vipCode + "'");
                if (rows.Count() == 1)
                {
                    decimal t = (decimal)rows[0]["purchase_sum"];
                    rows[0]["purchase_sum"] = sumFinal+t;
                }
                else
                    return false;
                vipDataAdapter.Update(dataset, "vip");
            }
            return true;
        }

        public void deleteAll()
        {
            dt.Rows.Clear();
            count = 0;
            onDataChanged();
        }

        public void deleteOne(int index)
        {
            dt.Rows.RemoveAt(index);
            onDataChanged();
        }

        private void newRow(string code,string name,decimal price,int count)
        {
            //  相同项可以合并
            DataRow[] rows =  dt.Select("条形码 = '" + code + "'");
            if (rows.Count() == 1)
            {
                int t = Convert.ToInt32(rows[0]["数量"]);
                rows[0]["数量"] = count + t;
                return;
            }
            DataRow row = dt.NewRow();
            row["条形码"] = code;
            row["商品名"] = name;
            row["商品单价"] = price;
            row["数量"] = count;
            row["合计"] = price * count;
            dt.Rows.Add(row);
        }

        public void Dispose()
        {
            dt.Dispose();
            tradeDataAdapter.Dispose();
            saleDataAdapter.Dispose();
            vipDataAdapter.Dispose();
            dataset.Dispose();
        }
    }
}
