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
    public partial class SaleForm : Form
    {
        string username;
        DataSet dataset;
        DataTable dt_sale,dt_user;
        SqlDataAdapter saleDataAdapter;
        public SaleForm(string username)
        {
            InitializeComponent();
            this.username = username;

            dataset = new DataSet();

            init();

        }

        private void init()
        {
            connectToServer();
            dgv_sale.DataSource = dt_sale;
            dgv_sale.Columns["s_id"].Visible = false;
            dgv_sale.Sort(dgv_sale.Columns["总销量额"], ListSortDirection.Ascending);

            dgv_user.DataSource = dt_user;
            dgv_user.Columns["users_id"].Visible = false;
            dgv_user.Sort(dgv_user.Columns["总销量额"], ListSortDirection.Ascending);
        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();

                
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM view_commodity_sale");
                saleDataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                saleDataAdapter.Fill(dataset, "sale");
                dt_sale = dataset.Tables["sale"];

                builder.Clear();
                builder.Append("SELECT * FROM view_users_sale");
                SqlDataAdapter userDataAdapter = new SqlDataAdapter(builder.ToString(), conn);
                userDataAdapter.Fill(dataset, "user");
                dt_user = dataset.Tables["user"];

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

        private void menu_purchase_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new PurchaseForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            saleDataAdapter.Update(dataset, "sale");
        }

        private void menu_stock_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new StockForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }
    }
}
