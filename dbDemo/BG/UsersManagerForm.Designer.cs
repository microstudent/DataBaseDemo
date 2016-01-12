namespace dbDemo
{
    partial class UsersManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_newUser = new System.Windows.Forms.TabPage();
            this.tb_pw_confirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_userReset = new System.Windows.Forms.Button();
            this.bt_newUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tb_pw1 = new System.Windows.Forms.TextBox();
            this.tb_username1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TabPage();
            this.bt2 = new System.Windows.Forms.Button();
            this.tb_oldpw2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_newpw2 = new System.Windows.Forms.TextBox();
            this.tb_username2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tp_delUser = new System.Windows.Forms.TabPage();
            this.bt3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tp_newUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tb_password.SuspendLayout();
            this.tp_delUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_newUser);
            this.tabControl1.Controls.Add(this.tb_password);
            this.tabControl1.Controls.Add(this.tp_delUser);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_newUser
            // 
            this.tp_newUser.BackColor = System.Drawing.SystemColors.Control;
            this.tp_newUser.Controls.Add(this.tb_pw_confirm);
            this.tp_newUser.Controls.Add(this.label7);
            this.tp_newUser.Controls.Add(this.bt_userReset);
            this.tp_newUser.Controls.Add(this.bt_newUser);
            this.tp_newUser.Controls.Add(this.panel1);
            this.tp_newUser.Controls.Add(this.tb_pw1);
            this.tp_newUser.Controls.Add(this.tb_username1);
            this.tp_newUser.Controls.Add(this.label3);
            this.tp_newUser.Controls.Add(this.label2);
            this.tp_newUser.Controls.Add(this.label1);
            this.tp_newUser.Location = new System.Drawing.Point(4, 22);
            this.tp_newUser.Name = "tp_newUser";
            this.tp_newUser.Padding = new System.Windows.Forms.Padding(3);
            this.tp_newUser.Size = new System.Drawing.Size(499, 296);
            this.tp_newUser.TabIndex = 0;
            this.tp_newUser.Text = "增加新用户";
            // 
            // tb_pw_confirm
            // 
            this.tb_pw_confirm.Location = new System.Drawing.Point(101, 149);
            this.tb_pw_confirm.Name = "tb_pw_confirm";
            this.tb_pw_confirm.Size = new System.Drawing.Size(100, 21);
            this.tb_pw_confirm.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "密码确认：";
            // 
            // bt_userReset
            // 
            this.bt_userReset.Location = new System.Drawing.Point(302, 254);
            this.bt_userReset.Name = "bt_userReset";
            this.bt_userReset.Size = new System.Drawing.Size(75, 23);
            this.bt_userReset.TabIndex = 7;
            this.bt_userReset.Text = "重置";
            this.bt_userReset.UseVisualStyleBackColor = true;
            // 
            // bt_newUser
            // 
            this.bt_newUser.Location = new System.Drawing.Point(101, 254);
            this.bt_newUser.Name = "bt_newUser";
            this.bt_newUser.Size = new System.Drawing.Size(75, 23);
            this.bt_newUser.TabIndex = 6;
            this.bt_newUser.Text = "增加";
            this.bt_newUser.UseVisualStyleBackColor = true;
            this.bt_newUser.Click += new System.EventHandler(this.bt_newUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(101, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 27);
            this.panel1.TabIndex = 5;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(274, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "超级管理员";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(171, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "库存管理员";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(92, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "录入员";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "收银员";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tb_pw1
            // 
            this.tb_pw1.Location = new System.Drawing.Point(101, 92);
            this.tb_pw1.Name = "tb_pw1";
            this.tb_pw1.Size = new System.Drawing.Size(100, 21);
            this.tb_pw1.TabIndex = 4;
            // 
            // tb_username1
            // 
            this.tb_username1.Location = new System.Drawing.Point(101, 37);
            this.tb_username1.Name = "tb_username1";
            this.tb_username1.Size = new System.Drawing.Size(100, 21);
            this.tb_username1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户身份：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Control;
            this.tb_password.Controls.Add(this.bt2);
            this.tb_password.Controls.Add(this.tb_oldpw2);
            this.tb_password.Controls.Add(this.label6);
            this.tb_password.Controls.Add(this.tb_newpw2);
            this.tb_password.Controls.Add(this.tb_username2);
            this.tb_password.Controls.Add(this.label4);
            this.tb_password.Controls.Add(this.label5);
            this.tb_password.Location = new System.Drawing.Point(4, 22);
            this.tb_password.Name = "tb_password";
            this.tb_password.Padding = new System.Windows.Forms.Padding(3);
            this.tb_password.Size = new System.Drawing.Size(499, 296);
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "修改用户密码";
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(207, 228);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 11;
            this.bt2.Text = "修改";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // tb_oldpw2
            // 
            this.tb_oldpw2.Location = new System.Drawing.Point(234, 90);
            this.tb_oldpw2.Name = "tb_oldpw2";
            this.tb_oldpw2.Size = new System.Drawing.Size(100, 21);
            this.tb_oldpw2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "旧密码：";
            // 
            // tb_newpw2
            // 
            this.tb_newpw2.Location = new System.Drawing.Point(234, 131);
            this.tb_newpw2.Name = "tb_newpw2";
            this.tb_newpw2.Size = new System.Drawing.Size(100, 21);
            this.tb_newpw2.TabIndex = 8;
            // 
            // tb_username2
            // 
            this.tb_username2.Location = new System.Drawing.Point(234, 50);
            this.tb_username2.Name = "tb_username2";
            this.tb_username2.Size = new System.Drawing.Size(100, 21);
            this.tb_username2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "新密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "用户名：";
            // 
            // tp_delUser
            // 
            this.tp_delUser.BackColor = System.Drawing.SystemColors.Control;
            this.tp_delUser.Controls.Add(this.bt3);
            this.tp_delUser.Controls.Add(this.label8);
            this.tp_delUser.Controls.Add(this.cb3);
            this.tp_delUser.Location = new System.Drawing.Point(4, 22);
            this.tp_delUser.Name = "tp_delUser";
            this.tp_delUser.Size = new System.Drawing.Size(499, 296);
            this.tp_delUser.TabIndex = 2;
            this.tp_delUser.Text = "删除用户";
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(196, 248);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "删除";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "用户名：";
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(196, 111);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(121, 20);
            this.cb3.TabIndex = 0;
            // 
            // UsersManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 339);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UsersManagerForm";
            this.Text = "UsersManagerForm";
            this.tabControl1.ResumeLayout(false);
            this.tp_newUser.ResumeLayout(false);
            this.tp_newUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tb_password.ResumeLayout(false);
            this.tb_password.PerformLayout();
            this.tp_delUser.ResumeLayout(false);
            this.tp_delUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tp_newUser;
        private System.Windows.Forms.TextBox tb_pw_confirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_userReset;
        private System.Windows.Forms.Button bt_newUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tb_pw1;
        private System.Windows.Forms.TextBox tb_username1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tb_password;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.TextBox tb_oldpw2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_newpw2;
        private System.Windows.Forms.TextBox tb_username2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tp_delUser;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}