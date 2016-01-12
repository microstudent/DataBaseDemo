using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo
{
    public partial class StockForm : Form
    {
        string username;

        SqlDataAdapter dataAdapter;
        DataSet dataset;
        DataTable dataTable;    //当前的表

        public StockForm(string username)
        {
            InitializeComponent();
            this.username = username;

            dataset = new DataSet();
            connectToServer();
            dgv.DataSource = dataTable;
        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from view_stock", conn);

                dataAdapter.Fill(dataset, "stock");
                dataTable = dataset.Tables["stock"];
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


        public void update()
        {
            dataAdapter.Update(dataTable);
            dataTable.AcceptChanges();
        }

        private void menu_purchase_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new PurchaseForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void menu_sale_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new SaleForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
