using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo
{
    public partial class VipForm : Form
    {
        public string vipCode
        {
            private set;
            get;
        }
        public VipForm()
        {
            InitializeComponent();
        }

        private void bt_yes_Click(object sender, EventArgs e)
        {
            vipCode = tb_vipCode.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void bt_no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tb_vipCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bt_yes.PerformClick();
            }else if(e.KeyCode == Keys.Escape)
            {
                bt_no.PerformClick();
            }
        }
    }
}
