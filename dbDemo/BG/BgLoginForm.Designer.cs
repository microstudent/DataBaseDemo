namespace dbDemo
{
    partial class BgLoginForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.cb_server_ip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_users = new System.Windows.Forms.RadioButton();
            this.rb_stock = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(112, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "后台管理系统";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(227, 299);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 19;
            this.bt_exit.Text = "退出";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(113, 299);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.TabIndex = 18;
            this.bt_login.Text = "登录";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // cb_server_ip
            // 
            this.cb_server_ip.FormattingEnabled = true;
            this.cb_server_ip.Items.AddRange(new object[] {
            "localhost"});
            this.cb_server_ip.Location = new System.Drawing.Point(161, 195);
            this.cb_server_ip.Name = "cb_server_ip";
            this.cb_server_ip.Size = new System.Drawing.Size(121, 20);
            this.cb_server_ip.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "服务器地址：";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(161, 156);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(121, 21);
            this.tb_password.TabIndex = 15;
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "密码：";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(161, 117);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(121, 21);
            this.tb_userName.TabIndex = 13;
            this.tb_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_userName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            // 
            // rb_users
            // 
            this.rb_users.AutoSize = true;
            this.rb_users.Location = new System.Drawing.Point(205, 20);
            this.rb_users.Name = "rb_users";
            this.rb_users.Size = new System.Drawing.Size(71, 16);
            this.rb_users.TabIndex = 10;
            this.rb_users.Text = "用户管理";
            this.rb_users.UseVisualStyleBackColor = true;
            // 
            // rb_stock
            // 
            this.rb_stock.AutoSize = true;
            this.rb_stock.Checked = true;
            this.rb_stock.Location = new System.Drawing.Point(28, 20);
            this.rb_stock.Name = "rb_stock";
            this.rb_stock.Size = new System.Drawing.Size(71, 16);
            this.rb_stock.TabIndex = 9;
            this.rb_stock.TabStop = true;
            this.rb_stock.Text = "库存管理";
            this.rb_stock.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_stock);
            this.groupBox1.Controls.Add(this.rb_users);
            this.groupBox1.Location = new System.Drawing.Point(54, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 48);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能选择";
            // 
            // BgLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.cb_server_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.label1);
            this.Name = "BgLoginForm";
            this.Text = "BgLoginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.ComboBox cb_server_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_stock;
        private System.Windows.Forms.RadioButton rb_users;
    }
}