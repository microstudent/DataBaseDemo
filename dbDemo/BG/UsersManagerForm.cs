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
    public partial class UsersManagerForm : Form
    {
        
        public UsersManagerForm(int userType)
        {
            InitializeComponent();
            if(userType != 3)
            {
                //不是超级管理员，只允许修改密码
                tabControl1.TabPages.RemoveByKey("tp_newUser");
                tabControl1.TabPages.RemoveByKey("tp_delUser");
            }
        }
    }
}
