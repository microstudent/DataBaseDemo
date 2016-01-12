using dbDemo.BG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo
{
    public partial class PurchaseForm : Form
    {
        string username;
        PurchaseManager manager;

        public PurchaseForm(string username)
        {
            InitializeComponent();
            this.username = username;
            manager = new PurchaseManager(dgv);
        }

        private void menu_sale_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new SaleForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void menu_stock_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new StockForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_s_name.Text = dgv.CurrentRow.Cells["商品名"].Value.ToString();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            manager.newPurchasePlan(dgv.CurrentRow.Index, tb_quantity_planned.Text, tb_price.Text, dtp_stock_time.Value, dtp_arr_time.Value);
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_price.Text = tb_quantity_planned.Text = tb_s_name.Text = "";
        }
    }
}
