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
    public partial class InputForm : Form
    {
        string username;
        InputManager manager;

        public InputForm(string username)
        {
            InitializeComponent();
            init();
            this.username = username;
            label_username.Text += username;
        }

        private void init()
        {
            manager = new InputManager(dgv, cb_supplier);

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                return;
            }
            InputManager.NewItemArgs args = new InputManager.NewItemArgs(tb_name.Text, tb_code.Text,
                 cb_supplier.Text, Convert.ToDecimal(tb_price.Text), rb_discount_yes.Checked, rb_sale_yes.Checked,Convert.ToInt32(tb_quan.Text));
            if (!string.IsNullOrEmpty(tb_pro_price.Text))
            {
                if (DateTime.Compare(dtp_start.Value ,dtp_end.Value)<=0)
                {
                    args.setDiscount(dtp_start.Value.ToString(), dtp_end.Value.ToString(), Convert.ToDecimal(tb_pro_price.Text));
                }
                else
                {
                    MessageBox.Show("时间区间错误", "错误");
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(tb_quan_planned.Text))
            {
                args.setQuanPlanned(Convert.ToInt32(tb_quan_planned.Text));
            }
            if (!string.IsNullOrWhiteSpace(tb_quan_warning.Text))
            {
                args.setQuanWarn(Convert.ToInt32(tb_quan_warning.Text));
            }
            manager.addToDataTable(args);
            resetAll();
        }

        private void resetAll()
        {
            tb_code.Text = tb_name.Text = 
                tb_price.Text= tb_pro_price.Text= tb_quan.Text = tb_quan_planned.Text = tb_quan_warning.Text =  "";
            tb_quan_warning.BackColor = tb_quan_planned.BackColor = tb_quan.BackColor = tb_pro_price.BackColor = 
                tb_price.BackColor = tb_name.BackColor = tb_code.BackColor = Color.White;
        }

        private bool check()
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                tb_name.BackColor = Color.Pink;
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_price.Text))
            {
                tb_price.BackColor = Color.Pink;
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_code.Text))
            {
                tb_code.BackColor = Color.Pink;
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_quan.Text))
            {
                tb_quan.BackColor = Color.Pink;
                return false;
            }
            if (string.IsNullOrWhiteSpace(cb_supplier.Text))
            {
                cb_supplier.BackColor = Color.Pink;
                return false;
            }
            return true;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            manager.update();
            MessageBox.Show("已更新");
        }


        private void menu_supplier_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new SupplierForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void menu_commodity_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                 new ThreadStart(delegate { System.Windows.Forms.Application.Run(new CommodityForm(username)); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }
    }
}
