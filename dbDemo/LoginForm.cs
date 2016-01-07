using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbDemo
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            init();            
        }

        private void init()
        {
            cb_server_ip.SelectedIndex = 0;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            login(tb_userName.Text, tb_password.Text);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login(string username,string pw)
        {
            SqlConnectionStringBuilder sqlbuilder = new SqlConnectionStringBuilder();
            sqlbuilder.DataSource = cb_server_ip.Text;
            sqlbuilder.InitialCatalog = "PosDB";   //数据库名
            sqlbuilder.IntegratedSecurity = true;

            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    connection.ConnectionString = sqlbuilder.ConnectionString;
                    connection.Open();
                }catch(Exception ex)
                {
                    MessageBox.Show("连接至服务器失败，请检查连接.", "连接错误");
                }

                if (connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("连接至服务器失败，请检查连接.", "连接错误");
                    return;
                }

                string md5Pw = PasswordUtil.toMd5(pw);

                StringBuilder builder = new StringBuilder();
                builder.Append("select * from tb_users where users_name = ");
                builder.Append("@users_name ");
                builder.Append("and users_password = ");
                builder.Append("@users_pw");

                SqlParameter para1 = new SqlParameter("@users_name",SqlDbType.Char);
                SqlParameter para2 = new SqlParameter("@users_pw", SqlDbType.Char);

                para1.Value = tb_userName.Text;
                para2.Value = md5Pw;

                SqlCommand cmd = new SqlCommand(builder.ToString(), connection);

                cmd.Parameters.Add(para1);
                cmd.Parameters.Add(para2);

                if (null != cmd.ExecuteScalar())
                {
                    MessageBox.Show("登录成功", "成功");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "错误");
                }
            }
        }

        private void tb_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tb_password.Focus();
            }
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_login.PerformClick();
            }
        }
    }
}
