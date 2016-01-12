namespace dbDemo
{
    partial class InputForm
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
                manager.Dispose();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_supplier = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_sale_yes = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_discount_yes = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tb_quan_planned = new System.Windows.Forms.TextBox();
            this.tb_quan_warning = new System.Windows.Forms.TextBox();
            this.tb_quan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.tb_pro_price = new System.Windows.Forms.TextBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_username = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bt_update = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menu_input = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_commodity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_supplier);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tb_quan_planned);
            this.groupBox1.Controls.Add(this.tb_quan_warning);
            this.groupBox1.Controls.Add(this.tb_quan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.tb_pro_price);
            this.groupBox1.Controls.Add(this.tb_code);
            this.groupBox1.Controls.Add(this.tb_price);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // cb_supplier
            // 
            this.cb_supplier.FormattingEnabled = true;
            this.cb_supplier.Location = new System.Drawing.Point(126, 367);
            this.cb_supplier.Name = "cb_supplier";
            this.cb_supplier.Size = new System.Drawing.Size(177, 20);
            this.cb_supplier.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "供应商名称：";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(205, 412);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 13;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(320, 412);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 14;
            this.bt_reset.Text = "重置";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_sale_yes);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(126, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 30);
            this.panel2.TabIndex = 11;
            // 
            // rb_sale_yes
            // 
            this.rb_sale_yes.AutoSize = true;
            this.rb_sale_yes.Checked = true;
            this.rb_sale_yes.Location = new System.Drawing.Point(0, 6);
            this.rb_sale_yes.Name = "rb_sale_yes";
            this.rb_sale_yes.Size = new System.Drawing.Size(35, 16);
            this.rb_sale_yes.TabIndex = 22;
            this.rb_sale_yes.TabStop = true;
            this.rb_sale_yes.Text = "是";
            this.rb_sale_yes.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(119, 6);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(35, 16);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.Text = "否";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_discount_yes);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(126, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 29);
            this.panel1.TabIndex = 7;
            // 
            // rb_discount_yes
            // 
            this.rb_discount_yes.AutoSize = true;
            this.rb_discount_yes.Location = new System.Drawing.Point(3, 8);
            this.rb_discount_yes.Name = "rb_discount_yes";
            this.rb_discount_yes.Size = new System.Drawing.Size(35, 16);
            this.rb_discount_yes.TabIndex = 20;
            this.rb_discount_yes.Text = "是";
            this.rb_discount_yes.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(119, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "否";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tb_quan_planned
            // 
            this.tb_quan_planned.Location = new System.Drawing.Point(126, 302);
            this.tb_quan_planned.Name = "tb_quan_planned";
            this.tb_quan_planned.Size = new System.Drawing.Size(100, 21);
            this.tb_quan_planned.TabIndex = 10;
            // 
            // tb_quan_warning
            // 
            this.tb_quan_warning.Location = new System.Drawing.Point(126, 271);
            this.tb_quan_warning.Name = "tb_quan_warning";
            this.tb_quan_warning.Size = new System.Drawing.Size(100, 21);
            this.tb_quan_warning.TabIndex = 9;
            // 
            // tb_quan
            // 
            this.tb_quan.Location = new System.Drawing.Point(126, 240);
            this.tb_quan.Name = "tb_quan";
            this.tb_quan.Size = new System.Drawing.Size(100, 21);
            this.tb_quan.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "是否允许售卖*：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "计划进货数量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "库存报警数量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "库存数量*：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "是否允许促销*：";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(126, 178);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(134, 21);
            this.dtp_end.TabIndex = 6;
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(126, 147);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(134, 21);
            this.dtp_start.TabIndex = 5;
            // 
            // tb_pro_price
            // 
            this.tb_pro_price.Location = new System.Drawing.Point(126, 116);
            this.tb_pro_price.Name = "tb_pro_price";
            this.tb_pro_price.Size = new System.Drawing.Size(100, 21);
            this.tb_pro_price.TabIndex = 4;
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(126, 85);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(194, 21);
            this.tb_code.TabIndex = 3;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(126, 54);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 21);
            this.tb_price.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "促销止日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "促销起日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "促销价格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "条形码*：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品单价*：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(126, 23);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(194, 21);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称*：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_username});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1096, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_username
            // 
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(56, 17);
            this.label_username.Text = "录入员：";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 20);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(634, 363);
            this.dgv.TabIndex = 2;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(575, 412);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 5;
            this.bt_update.Text = "提交";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Controls.Add(this.bt_update);
            this.groupBox2.Location = new System.Drawing.Point(428, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 441);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新商品列表";
            // 
            // menu_input
            // 
            this.menu_input.Name = "menu_input";
            this.menu_input.Size = new System.Drawing.Size(92, 21);
            this.menu_input.Text = "录入商品信息";
            // 
            // menu_supplier
            // 
            this.menu_supplier.Name = "menu_supplier";
            this.menu_supplier.Size = new System.Drawing.Size(80, 21);
            this.menu_supplier.Text = "录入供应商";
            this.menu_supplier.Click += new System.EventHandler(this.menu_supplier_Click);
            // 
            // menu_commodity
            // 
            this.menu_commodity.Name = "menu_commodity";
            this.menu_commodity.Size = new System.Drawing.Size(92, 21);
            this.menu_commodity.Text = "管理商品目录";
            this.menu_commodity.Click += new System.EventHandler(this.menu_commodity_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_input,
            this.menu_supplier,
            this.menu_commodity});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label_username;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.TextBox tb_pro_price;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rb_sale_yes;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rb_discount_yes;
        private System.Windows.Forms.TextBox tb_quan_planned;
        private System.Windows.Forms.TextBox tb_quan_warning;
        private System.Windows.Forms.TextBox tb_quan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_supplier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_commodity;
        private System.Windows.Forms.ToolStripMenuItem menu_supplier;
        private System.Windows.Forms.ToolStripMenuItem menu_input;
    }
}