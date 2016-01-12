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
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                    new ThreadStart(delegate { System.Windows.Forms.Application.Run(new PosLoginForm()); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                    new ThreadStart(delegate { System.Windows.Forms.Application.Run(new BgLoginForm()); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
