using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo.BG
{
    class PurchaseManager:IDisposable
    {
        DataSet dataset;
        DataTable dataTable;
        SqlDataAdapter purchaseDataAdapter,stockDataAdapter;

        public PurchaseManager(DataGridView dgv)
        {
            dataset = new DataSet();
            connectToServer();
            dgv.DataSource = dataTable;
            dgv.Columns["s_id"].Visible = false;
        }

        public void newPurchasePlan(int index,string quantity,string price,DateTime stockTime, DateTime arrTime)
        {
            if (arrTime!=null)
            {
                dataTable.Rows[index]["计划进货数量"] = Convert.ToInt32(quantity);
                DataTable tb_stock = dataset.Tables["stock"];
                //插入新行
                //找到s_id
                int sid = Convert.ToInt32(dataTable.Rows[index]["s_id"]);
                DataRow row = tb_stock.NewRow();
                row["s_id"] = sid;
                row["stock_count"] = quantity;
                row["stock_price"] = price;
                row["stock_time"] = stockTime;
                row["stock_state"] = 1;
                tb_stock.Rows.Add(row);
            }
            else
            {
                dataTable.Rows[index]["quantity_planned"] = Convert.ToInt32(quantity);
                DataTable tb_stock = dataset.Tables["stock"];
                //插入新行
                //找到s_id
                int sid = Convert.ToInt32(dataTable.Rows[index]["s_id"]);
                DataRow row = tb_stock.NewRow();
                row["s_id"] = sid;
                row["stock_count"] = quantity;
                row["stock_price"] = price;
                row["stock_time"] = stockTime;
                row["stock_arr_time"] = arrTime;
                if (DateTime.Compare(stockTime, arrTime) < 0)
                {
                    row["stock_state"] = 0;
                }
                else if(DateTime.Compare(stockTime, arrTime) == 0)
                {
                    row["stock_state"] = 2;
                }
                tb_stock.Rows.Add(row);
            }

            update();
        }

        private void update()
        {
            purchaseDataAdapter.Update(dataTable);
            stockDataAdapter.Update(dataset, "stock");
        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();

                //先获取所有商品信息
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT s_id, s_name as 商品名, ");
                builder.Append("s_price as 单价, ");
                builder.Append("s_code as 条形码, ");
                builder.Append("quantity as 数量, ");
                builder.Append("quantity_warning as 库存警告数量, ");
                builder.Append("quantity_planned as 计划进货数量, ");
                builder.Append("supplier_id as 供应商ID ");
                builder.Append("FROM tb_commodity ");
                builder.Append("WHERE quantity < quantity_warning");
                purchaseDataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                purchaseDataAdapter.Fill(dataset, "commodity");
                dataTable = dataset.Tables["commodity"];

                stockDataAdapter = new SqlDataAdapter("SELECT * FROM tb_stock", conn);
                stockDataAdapter.Fill(dataset, "stock");

                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(purchaseDataAdapter);
                SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(stockDataAdapter);

            }
            catch (Exception e)
            {
                MessageBox.Show("连接至服务器失败，请检查连接！错误：" + e.ToString(), "错误");
            }
            finally
            {
                conn.Close();
            }
        }

        public void Dispose()
        {
            dataset.Dispose();
            purchaseDataAdapter.Dispose();
            stockDataAdapter.Dispose();
        }
    }
}
