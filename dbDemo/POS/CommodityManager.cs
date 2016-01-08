using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo
{
    class CommodityManager
    {
        SqlDataAdapter dataAdapter;
        DataSet dataset;
        DataTable dataTable;    //当前的表

        public CommodityManager(DataGridView dgv)
        {
            dataset = new DataSet();
            connectToServer();
            dgv.DataSource = dataTable;
            dgv.Columns["s_id"].Visible = false;
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
                builder.Append("s_pro_price as 促销价格, ");
                builder.Append("s_start_time as 促销起时间, ");
                builder.Append("s_end_time as 促销止时间, ");
                builder.Append("is_discount as 允许打折, ");
                builder.Append("quantity as 数量, ");
                builder.Append("quantity_warning as 库存警告数量, ");
                builder.Append("quantity_planned as 计划进货数量, ");
                builder.Append("is_allow_sale as 允许销售, ");
                builder.Append("supplier_id as 供应商ID ");
                builder.Append("FROM view_commodity_input");
                dataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                dataAdapter.Fill(dataset, "commodity");
                dataTable = dataset.Tables["commodity"];
                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(dataAdapter);
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


        public bool addToDataTable(NewItemArgs e)
        {
            DataRow row = dataTable.NewRow();

            row["供应商名称"] = e.name;
            row["供应商地址"] = e.addr;
            row["供应商电话"] = e.phone;
            dataTable.Rows.Add(row);
            return true;
        }

        public void update()
        {
            dataAdapter.Update(dataTable);
            dataTable.AcceptChanges();
        }
    }
}
