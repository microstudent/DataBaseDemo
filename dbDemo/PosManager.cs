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
    class PosManager
    {
        public delegate void DataChangedEventHandler(Object sender, DataChangedEventArgs e);
        public event DataChangedEventHandler dataChanged;

        public delegate void BillUpEventHandler(Object sender, BillUpEventArgs e);
        public event BillUpEventHandler BillUp;

        int sum = 0;        //当前的合计金额合计
        int count = 0;      //当前的商品的数量合计
        DataTable dt;   //当前的商品清单
        SqlDataAdapter tradeDataAdapter,saleDataAdapter;
        DataSet dataset;    //内存中的临时数据库

        private bool isVipMode = false;

        //构造函数
        public PosManager(TextBox tb_sum,TextBox tb_count,DataGridView dgv)
        {
            dt = new DataTable();
            dataset = new DataSet();
            //数据绑定
            tb_sum.DataBindings.Add("Text", sum, null);
            tb_count.DataBindings.Add("Text", count, null);
            dgv.DataSource = dt;

            connectToServer();
        }

        private void connectToServer()
        {
            //配置连接属性
            SqlConnectionStringBuilder sqlbuilder = new SqlConnectionStringBuilder();
            sqlbuilder.DataSource = "localhost";    //TODO
            sqlbuilder.InitialCatalog = "PosDB";   //数据库名
            sqlbuilder.IntegratedSecurity = true;

            SqlConnection conn = new SqlConnection();
            
            conn.ConnectionString = sqlbuilder.ConnectionString;
            try
            {
                conn.Open();

                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM view_commodity_cashier;");

                tradeDataAdapter = new SqlDataAdapter("SELECT * FROM tb_trade", conn);
                saleDataAdapter = new SqlDataAdapter("SELECT * FROM tb_sale", conn);
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

                //获取当前的购物表模式
                //拼接select语句
                builder.Clear();
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

        public class DataChangedEventArgs : EventArgs
        {
            public readonly string billSum,Fav,billFinal;
            public DataChangedEventArgs(string billSum, string Fav, string billFinal)
            {
                this.billSum = billSum;
                this.Fav = Fav;
                this.billFinal = billFinal;
            }
        }
        //通知已经完成结账操作
        private void onBillUpFinish(decimal charged,decimal sumFinal)
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
                decimal sum, fav, sumFinal;
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
                DataChangedEventArgs e = new DataChangedEventArgs(sum.ToString(), fav.ToString(), sumFinal.ToString());
                dataChanged(this, e);
            }
        }

        public bool addToShopList(string code)
        {
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
                    //TODO  不允许打折
                    newRow(code, result[0]["s_name"].ToString(), (decimal)(result[0]["s_price"]), 1);
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
                    newRow(result[0]["s_code"].ToString(), result[0]["s_name"].ToString(), (decimal)result[0]["s_price"], Convert.ToInt32(mat.Groups[1].Value));
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public void settle(decimal chargedSum,decimal sumFinal)
        {
            //和数据库合并
            combineToDataset(chargedSum);
            onBillUpFinish(chargedSum, sumFinal);
        }

        private void combineToDataset(decimal chargedSum)
        {
            //添加到trade表
            DataTable tb_trade = dataset.Tables["trade"];
            DataRow row = tb_trade.NewRow();
            row["users_id"] = 0;
            row["trade_amount"] = chargedSum;
            row["vip_code"] = DBNull.Value;
            row["trade_time"] = DateTime.Now.ToString();
            tb_trade.Rows.Add(row);
            tradeDataAdapter.Update(dataset,"trade");
            //添加到sale表

            //添加到VIP表
        }

        public void deleteAll()
        {
            dt.Rows.Clear();
            onDataChanged();
        }

        public void deleteOne(int index)
        {
            dt.Rows.RemoveAt(index);
            onDataChanged();
        }

        private void newRow(string code,string name,decimal price,int count)
        {
            //TODO  相同项可以合并
            DataRow row = dt.NewRow();
            row["条形码"] = code;
            row["商品名"] = name;
            row["商品单价"] = price;
            row["数量"] = count;
            row["合计"] = price * count;
            dt.Rows.Add(row);
            onDataChanged();
        }
    }
}
