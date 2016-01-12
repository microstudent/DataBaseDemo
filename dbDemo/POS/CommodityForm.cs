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
    public partial class CommodityForm : Form
    {
        string username;
        CommodityManager manager;
        public CommodityForm(string username)
        {
            InitializeComponent();
            manager = new CommodityManager(dgv);
            this.username = username;
            label_username.Text += username;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            manager.update();
        }

        private void menu_input_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                new ThreadStart(delegate { System.Windows.Forms.Application.Run(new InputForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void menu_supplier_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new SupplierForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

    }
}
