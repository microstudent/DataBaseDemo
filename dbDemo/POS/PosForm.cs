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
    public partial class PosForm : Form
    {
        PosManager manager;

        public PosForm(string username)
        {
            InitializeComponent();
            init();
            statusLabel_username.Text += username;
        }

        private void init()
        {
            manager = new PosManager(tb_sumFinal, tb_count, dgv_s);

            //注册处理方法
            manager.dataChanged += upDateUI;
            manager.BillUp += upDateUI;
        }

        //结账时更新UI
        private void upDateUI(object sender, PosManager.BillUpEventArgs e)
        {
            tb_charged.Text = e.chargedSum.ToString();
            tb_changed.Text = e.changeSum.ToString();
        }

        //数据改变时更新UI
        private void upDateUI(object sender, PosManager.DataChangedEventArgs e)
        {
            tb_sumFinal.Text = e.billFinal;
            tb_sum.Text = e.billSum;
            tb_sumFinal1.Text = e.billFinal;
            tb_fav.Text = e.Fav;
            tb_count.Text = e.count;
        }

        private void PosForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    //结账
                    bt_bill.PerformClick();
                    break;
                case Keys.F10:
                    //此单作废
                    bt_delAll.PerformClick();
                    break;
                case Keys.F12:
                    //锁定系统
                    bt_logout.PerformClick();
                    break;
                case Keys.F4:
                    //刷会员卡
                    bt_vip.PerformClick();
                    break;
                case Keys.Escape:
                    bt_exit.PerformClick();
                    break;
            }
        }

        private void bt_bill_Click(object sender, EventArgs e)
        {
            DataSet set = new DataSet();
            BillUpForm billform = new BillUpForm(Convert.ToDecimal(tb_sumFinal.Text));
            if(billform.ShowDialog() == DialogResult.OK)
            {
                //TODO
                manager.settle(billform.charged);
            }
        }


        

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_s_code_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!manager.addToShopList(tb_s_code.Text))
                {
                    MessageBox.Show("添加失败，请检查条形码！", "错误");
                }
                else
                {
                    tb_s_code.Text = "";
                }
            }
        }

        private void bt_delOne_Click(object sender, EventArgs e)
        {
            manager.deleteOne(dgv_s.CurrentCell.RowIndex);
            bt_delOne.Enabled = false;
        }

        private void dgv_s_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bt_delOne.Enabled = true;
        }

        private void dgv_s_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (dgv_s.CurrentCell == null)
                    return;
                manager.deleteOne(dgv_s.CurrentCell.RowIndex);
                bt_delOne.Enabled = false;
            }
        }

        private void bt_delAll_Click(object sender, EventArgs e)
        {
            manager.deleteAll();
        }

        private void PosForm_Activated(object sender, EventArgs e)
        {
            tb_s_code.Focus();
        }

        private void bt_vip_Click(object sender, EventArgs e)
        {
            VipForm vipForm = new VipForm();
            DialogResult result = vipForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (!manager.enterVipMode(vipForm.vipCode))
                {
                    MessageBox.Show("会员卡号输入错误，请检查后重试!", "错误");
                }
            }
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
            new ThreadStart(delegate { System.Windows.Forms.Application.Run(new PosLoginForm()); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusLabel_time.Text = DateTime.Now.ToString();
        }
    }
}
