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
    class SupplierManager
    {
        SqlDataAdapter supplierDataAdapter;
        DataSet dataset;        //临时数据库
        DataTable dataTable;    //当前的表

        public SupplierManager(DataGridView dgv)
        {
            dataset = new DataSet();
            connectToServer();
            dgv.DataSource = dataTable;
            dgv.Columns["supplier_id"].Visible = false;

        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();

                //先获取所有供应商信息到dataset去
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT supplier_id, supplier_name as 供应商名称, ");
                builder.Append("supplier_addr as 供应商地址, ");
                builder.Append("supplier_phone as 供应商电话 ");
                builder.Append("FROM tb_supplier");
                supplierDataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                supplierDataAdapter.Fill(dataset, "supplier");
                dataTable = dataset.Tables["supplier"];

                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(supplierDataAdapter);
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
            supplierDataAdapter.Update(dataTable);
            dataTable.AcceptChanges();
        }
    }



    public class NewItemArgs
    {
        public readonly string name, addr, phone;
        public NewItemArgs(string name,string addr,string phone)
        {
            this.name = name;
            this.addr = addr;
            this.phone = phone;
        }
    }
}
