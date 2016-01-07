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
    public partial class SupplierForm : Form
    {
        string username;
        SupplierManager manager;
        public SupplierForm(string username)
        {
            InitializeComponent();
            manager = new SupplierManager(dgv);
            this.username = username;
            label_username.Text += username;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            NewItemArgs args = new NewItemArgs(tb_supplier_name.Text, tb_supplier_addr.Text, tb_supplier_phone.Text);
            manager.addToDataTable(args);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            manager.update();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_supplier_addr.Clear();
            tb_supplier_name.Clear();
            tb_supplier_phone.Clear();
        }

        private void menu_input_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                new ThreadStart(delegate { System.Windows.Forms.Application.Run(new InputForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
            this.Dispose();
        }

        private void menu_commodity_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new CommodityForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
            this.Dispose();
        }
    }
}
