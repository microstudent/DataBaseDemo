using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo
{
    public partial class UsersManagerForm : Form
    {
        DataSet dataset = new DataSet();
        SqlDataAdapter dataAdapter;

        public UsersManagerForm(int userType)
        {
            InitializeComponent();
            if(userType != 3)
            {
                //不是超级管理员，只允许修改密码
                tabControl1.TabPages.RemoveByKey("tp_newUser");
                tabControl1.TabPages.RemoveByKey("tp_delUser");
            }
            connectToServer();
            ArrayList list = new ArrayList();
            foreach(DataRow row in dataset.Tables["users"].Rows)
            {
                list.Add(row["users_name"].ToString());
            }
            cb3.DataSource = list;
        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from tb_users", conn);

                dataAdapter.Fill(dataset, "users");

                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(dataAdapter);
            }
            catch (Exception e)
            {
                MessageBox.Show("连接至服务器失败，请检查连接！错误：" + e.ToString(), "错误");
            }
            finally
            {
                conn.Close();
            }
        }

        private bool newUser(string username,string pw, int type)
        {
            try
            {
                DataRow row = dataset.Tables["users"].NewRow();
                row["users_name"] = username;
                row["users_password"] = PasswordUtil.toMd5(pw);
                row["users_type"] = type;
                dataset.Tables["users"].Rows.Add(row);
                dataAdapter.Update(dataset, "users");
            }
            catch(Exception e)
            {
              MessageBox.Show(e.ToString());
              return false;
            }
            return true;
        }

        private void bt_newUser_Click(object sender, EventArgs e)
        {
            //check
            if (string.Compare(tb_pw1.Text, tb_pw_confirm.Text) != 0)
            {
                MessageBox.Show("两次密码不一致，请核对");
                return;
            }
            int userType = 0;
            if (radioButton1.Checked)
                userType = 0;
            if (radioButton2.Checked)
                userType = 1;
            if (radioButton3.Checked)
                userType = 2;
            if (radioButton4.Checked)
                userType = 3;
           if(newUser(tb_username1.Text, tb_pw1.Text, userType))
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            DataRow[] rows = dataset.Tables["users"].Select("users_name = '" + tb_username2.Text + "'");
            if (rows.Count() == 1)
            {
                if(string.Compare(rows[0]["users_password"].ToString(),PasswordUtil.toMd5(tb_oldpw2.Text))==0)
                {
                    rows[0]["users_password"] = PasswordUtil.toMd5(tb_newpw2.Text);
                    dataAdapter.Update(dataset, "users");

                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("旧密码输入错误");
                }
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {

            dataset.Tables["users"].Rows[cb3.SelectedIndex].Delete();

            dataAdapter.Update(dataset, "users");

            ArrayList list = new ArrayList();
            foreach (DataRow row in dataset.Tables["users"].Rows)
            {
                list.Add(row["users_name"].ToString());
            }
            cb3.DataSource = list;

            MessageBox.Show("已删除");
        }
    }
}
