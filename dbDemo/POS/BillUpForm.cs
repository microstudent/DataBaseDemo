using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo
{
    public partial class BillUpForm : Form
    {
        decimal sumFinal;
        public decimal charged
            {
            private set;
                get;
            }
        public BillUpForm(decimal sumFinal)
        {
            InitializeComponent();
            this.sumFinal = sumFinal;
            tb_sumFinal.Text = sumFinal.ToString();
            tb_charged.Focus();
        }

        

        private void bt_yes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_charged.Text))
            {
                if(!Validate(tb_charged.Text.Trim(), "^[0-9]+(.[0-9]{1,2})?$"))
                {
                    tb_charged.BackColor = Color.Pink;
                    tb_charged.Text = "";
                }
                else
                {
                    charged = Convert.ToDecimal(this.tb_charged.Text);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void bt_no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tb_charged_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bt_yes.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }


        static public bool Validate(string str, string regexStr)
        {
            Regex regex = new Regex(regexStr);
            Match match = regex.Match(str);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
