namespace dbDemo
{
    partial class PosForm
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
                manager.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.dgv_s = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_sumFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_changed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_charged = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_sumFinal1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_fav = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_s_code = new System.Windows.Forms.TextBox();
            this.bt_bill = new System.Windows.Forms.Button();
            this.bt_delOne = new System.Windows.Forms.Button();
            this.bt_delAll = new System.Windows.Forms.Button();
            this.bt_vip = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel_username = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_s)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_s
            // 
            this.dgv_s.AllowUserToAddRows = false;
            this.dgv_s.AllowUserToDeleteRows = false;
            this.dgv_s.AllowUserToResizeRows = false;
            this.dgv_s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_s.Location = new System.Drawing.Point(12, 110);
            this.dgv_s.Name = "dgv_s";
            this.dgv_s.ReadOnly = true;
            this.dgv_s.RowTemplate.Height = 23;
            this.dgv_s.Size = new System.Drawing.Size(647, 341);
            this.dgv_s.TabIndex = 0;
            this.dgv_s.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_s_CellEnter);
            this.dgv_s.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_s_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_sumFinal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 83);
            this.panel1.TabIndex = 2;
            // 
            // tb_sumFinal
            // 
            this.tb_sumFinal.BackColor = System.Drawing.SystemColors.Window;
            this.tb_sumFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sumFinal.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_sumFinal.Location = new System.Drawing.Point(73, 14);
            this.tb_sumFinal.Name = "tb_sumFinal";
            this.tb_sumFinal.Size = new System.Drawing.Size(261, 55);
            this.tb_sumFinal.TabIndex = 1;
            this.tb_sumFinal.Text = "0.00";
            this.tb_sumFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "合计 :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_count);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tb_changed);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_charged);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_sumFinal1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_fav);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_sum);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(359, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 83);
            this.panel2.TabIndex = 5;
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(249, 53);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(100, 21);
            this.tb_count.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "商品数量：";
            // 
            // tb_changed
            // 
            this.tb_changed.Location = new System.Drawing.Point(249, 28);
            this.tb_changed.Name = "tb_changed";
            this.tb_changed.Size = new System.Drawing.Size(100, 21);
            this.tb_changed.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "应找余额：";
            // 
            // tb_charged
            // 
            this.tb_charged.Location = new System.Drawing.Point(249, 3);
            this.tb_charged.Name = "tb_charged";
            this.tb_charged.Size = new System.Drawing.Size(100, 21);
            this.tb_charged.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "已付金额：";
            // 
            // tb_sumFinal1
            // 
            this.tb_sumFinal1.Location = new System.Drawing.Point(74, 53);
            this.tb_sumFinal1.Name = "tb_sumFinal1";
            this.tb_sumFinal1.Size = new System.Drawing.Size(100, 21);
            this.tb_sumFinal1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "实收金额：";
            // 
            // tb_fav
            // 
            this.tb_fav.Location = new System.Drawing.Point(74, 28);
            this.tb_fav.Name = "tb_fav";
            this.tb_fav.Size = new System.Drawing.Size(100, 21);
            this.tb_fav.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "优惠金额：";
            // 
            // tb_sum
            // 
            this.tb_sum.Location = new System.Drawing.Point(74, 3);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(100, 21);
            this.tb_sum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "应收金额：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "商品编号：";
            // 
            // tb_s_code
            // 
            this.tb_s_code.BackColor = System.Drawing.SystemColors.Window;
            this.tb_s_code.Location = new System.Drawing.Point(736, 117);
            this.tb_s_code.Name = "tb_s_code";
            this.tb_s_code.Size = new System.Drawing.Size(141, 21);
            this.tb_s_code.TabIndex = 7;
            this.tb_s_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_s_code_KeyDown);
            // 
            // bt_bill
            // 
            this.bt_bill.Location = new System.Drawing.Point(667, 156);
            this.bt_bill.Name = "bt_bill";
            this.bt_bill.Size = new System.Drawing.Size(210, 23);
            this.bt_bill.TabIndex = 8;
            this.bt_bill.Text = "结账  F5";
            this.bt_bill.UseVisualStyleBackColor = true;
            this.bt_bill.Click += new System.EventHandler(this.bt_bill_Click);
            // 
            // bt_delOne
            // 
            this.bt_delOne.Enabled = false;
            this.bt_delOne.Location = new System.Drawing.Point(667, 264);
            this.bt_delOne.Name = "bt_delOne";
            this.bt_delOne.Size = new System.Drawing.Size(210, 23);
            this.bt_delOne.TabIndex = 9;
            this.bt_delOne.Text = "单一删除 Del";
            this.bt_delOne.UseVisualStyleBackColor = true;
            this.bt_delOne.Click += new System.EventHandler(this.bt_delOne_Click);
            // 
            // bt_delAll
            // 
            this.bt_delAll.Location = new System.Drawing.Point(667, 318);
            this.bt_delAll.Name = "bt_delAll";
            this.bt_delAll.Size = new System.Drawing.Size(210, 23);
            this.bt_delAll.TabIndex = 10;
            this.bt_delAll.Text = "整单作废  F10";
            this.bt_delAll.UseVisualStyleBackColor = true;
            this.bt_delAll.Click += new System.EventHandler(this.bt_delAll_Click);
            // 
            // bt_vip
            // 
            this.bt_vip.Location = new System.Drawing.Point(667, 210);
            this.bt_vip.Name = "bt_vip";
            this.bt_vip.Size = new System.Drawing.Size(210, 23);
            this.bt_vip.TabIndex = 11;
            this.bt_vip.Text = "刷会员卡 F4";
            this.bt_vip.UseVisualStyleBackColor = true;
            this.bt_vip.Click += new System.EventHandler(this.bt_vip_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(667, 426);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(210, 23);
            this.bt_exit.TabIndex = 12;
            this.bt_exit.Text = "退出  Esc";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(667, 372);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(210, 23);
            this.bt_logout.TabIndex = 13;
            this.bt_logout.Text = "锁定系统  F12";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_username,
            this.statusLabel_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(889, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel_username
            // 
            this.statusLabel_username.Name = "statusLabel_username";
            this.statusLabel_username.Size = new System.Drawing.Size(56, 17);
            this.statusLabel_username.Text = "收银员：";
            // 
            // statusLabel_time
            // 
            this.statusLabel_time.Name = "statusLabel_time";
            this.statusLabel_time.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_vip);
            this.Controls.Add(this.bt_delAll);
            this.Controls.Add(this.bt_delOne);
            this.Controls.Add(this.bt_bill);
            this.Controls.Add(this.tb_s_code);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_s);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PosForm";
            this.Text = "小型超市POS收银系统";
            this.Activated += new System.EventHandler(this.PosForm_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PosForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_s)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_s;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_sumFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_changed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_charged;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_sumFinal1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_fav;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_s_code;
        private System.Windows.Forms.Button bt_bill;
        private System.Windows.Forms.Button bt_delOne;
        private System.Windows.Forms.Button bt_delAll;
        private System.Windows.Forms.Button bt_vip;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_username;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_time;
        private System.Windows.Forms.Timer timer1;
    }
}