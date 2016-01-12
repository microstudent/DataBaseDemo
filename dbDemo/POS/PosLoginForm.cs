﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace dbDemo
{
    public partial class PosLoginForm : Form
    {

        public PosLoginForm()
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
                }catch(Exception e)
                {
                    MessageBox.Show("连接至服务器失败，请检查连接。\n"+ e.ToString(), "连接错误");
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

                para1.Value = username;
                para2.Value = md5Pw;

                SqlCommand cmd = new SqlCommand(builder.ToString(), connection);

                cmd.Parameters.Add(para1);
                cmd.Parameters.Add(para2);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //检查身份
                    int userType = Convert.ToInt32(reader.GetValue(3));

                    if (rb_cashier.Checked)
                    {
                        if (userType != 0 && userType != 3)
                        {
                            MessageBox.Show("权限不足");
                            return;
                        }
                        Thread ShowMainThread = new Thread(
                        new ThreadStart(delegate { System.Windows.Forms.Application.Run(new PosForm(username)); }));
                        ShowMainThread.SetApartmentState(ApartmentState.STA);
                        ShowMainThread.Start();
                        Connection.ServerIP = cb_server_ip.Text;
                        this.Close();
                    }
                    else
                    {
                        //启动录入系统
                        if (userType != 1 && userType != 3)
                        {
                            MessageBox.Show("权限不足");
                            return;
                        }
                        Thread ShowMainThread = new Thread(
                              new ThreadStart(delegate { System.Windows.Forms.Application.Run(new InputForm(username)); }));
                        ShowMainThread.SetApartmentState(ApartmentState.STA);
                        ShowMainThread.Start();
                        Connection.ServerIP = cb_server_ip.Text;
                        this.Close();
                    }
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
