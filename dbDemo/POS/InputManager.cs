using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo
{
    class InputManager:IDisposable
    {
        public class NewItemArgs
        {
            public readonly string name,code, supplier_name;
            public readonly decimal price;
            public readonly bool isDiscount, isSaled;
            public readonly int quantity;
            public string end_time, start_time; 
            public decimal pro_price = -1;
            public int quan_warning = -1, quan_planned = -1;
            public NewItemArgs(string name,string code ,string supplierName,
                decimal price,bool isDiscount,bool isSaled,int quantity)
            {
                this.name = name;
                this.code = code;
                this.supplier_name = supplierName;
                this.price = price;
                this.isDiscount = isDiscount;
                this.isSaled = isSaled;
                this.quantity = quantity;
            }
            public void setDiscount(string startTime,string endTime,decimal proPrice)
            {
                this.start_time = startTime;
                this.end_time = endTime;
                this.pro_price = proPrice;
            }
            public void setQuanWarn(int quanWarning)
            {
                this.quan_warning = quanWarning;
            }
            public void setQuanPlanned(int quanPlanned)
            {
                this.quan_planned = quanPlanned;
            }
        }

        SqlDataAdapter commodityDataAdapter;
        DataSet dataset;        //临时数据库
        DataTable dataTable;    //当前的表


        public InputManager(DataGridView dgv,ComboBox supplier)
        {
            dataset = new DataSet();
            dataTable = new DataTable("commodity");
            connectToServer();
            dgv.DataSource = dataTable;
            ArrayList supplier_list = new ArrayList();
            foreach(DataRow row in dataset.Tables["supplier"].Rows)
            {
                supplier_list.Add(row["supplier_name"]);
            }
            supplier.DataSource = supplier_list;
            
        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();

                //先获取所有供应商信息到dataset去
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_supplier", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable tb_supplier = new DataTable("supplier");
                tb_supplier.Load(reader);

                dataset.Tables.Add(tb_supplier);
                reader.Close();

                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT s_name as 商品名, ");
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
                commodityDataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                //获取商品录入视图
                commodityDataAdapter.FillSchema(dataTable,SchemaType.Mapped);

                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(commodityDataAdapter);
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

        public void update()
        {
            commodityDataAdapter.Update(dataTable);
            dataTable.Clear();
            dataTable.AcceptChanges();
        }

        public bool addToDataTable(NewItemArgs e)
        {
            DataRow row = dataTable.NewRow();

            row["商品名"] = e.name;
            row["单价"] = e.price;
            row["条形码"] = e.code;
            row["允许打折"] = e.isDiscount;
            row["允许销售"] = e.isSaled;
            row["数量"] = e.quantity;
            if (e.pro_price!=-1)
            {
                row["促销起时间"] = e.start_time;
                row["促销止时间"] = e.end_time;
                row["促销价格"] = e.pro_price;
            }
            if (e.quan_planned!=-1)
            {
                row["计划进货数量"] = e.quan_planned;
            }
            if (e.quan_warning != -1)
            {
                row["库存警告数量"] = e.quan_warning;
            }
            //找到供应商ID
            DataTable tb_supplier = dataset.Tables["supplier"];
            DataRow[] rows = tb_supplier.Select("supplier_name = '" + e.supplier_name + "'");
            if(rows.Count() == 1)
            {
                row["供应商ID"] = rows[0]["supplier_id"];
            }
            dataTable.Rows.Add(row);
            return false;
        }

        public void Dispose()
        {
            dataTable.Dispose();
            dataset.Dispose();
            commodityDataAdapter.Dispose();
        }
    }
}
