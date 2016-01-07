namespace dbDemo
{
    partial class SupplierForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_supplier_phone = new System.Windows.Forms.TextBox();
            this.tb_supplier_addr = new System.Windows.Forms.TextBox();
            this.tb_supplier_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_username = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_input = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_commodity = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Controls.Add(this.tb_supplier_phone);
            this.groupBox1.Controls.Add(this.tb_supplier_addr);
            this.groupBox1.Controls.Add(this.tb_supplier_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "供应商信息";
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(180, 212);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 7;
            this.bt_reset.Text = "重置";
            this.bt_reset.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(52, 213);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 6;
            this.bt_add.Text = "增加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_supplier_phone
            // 
            this.tb_supplier_phone.Location = new System.Drawing.Point(114, 129);
            this.tb_supplier_phone.Name = "tb_supplier_phone";
            this.tb_supplier_phone.Size = new System.Drawing.Size(205, 21);
            this.tb_supplier_phone.TabIndex = 5;
            // 
            // tb_supplier_addr
            // 
            this.tb_supplier_addr.Location = new System.Drawing.Point(114, 83);
            this.tb_supplier_addr.Name = "tb_supplier_addr";
            this.tb_supplier_addr.Size = new System.Drawing.Size(205, 21);
            this.tb_supplier_addr.TabIndex = 4;
            // 
            // tb_supplier_name
            // 
            this.tb_supplier_name.Location = new System.Drawing.Point(114, 37);
            this.tb_supplier_name.Name = "tb_supplier_name";
            this.tb_supplier_name.Size = new System.Drawing.Size(205, 21);
            this.tb_supplier_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "供应商电话*：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "供应商地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商名称*：";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 20);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(355, 219);
            this.dgv.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_update);
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(373, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 287);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "供应商表";
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(272, 245);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 2;
            this.bt_update.Text = "提交";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_username});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_username
            // 
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(56, 17);
            this.label_username.Text = "录入员：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_input,
            this.menu_supplier,
            this.menu_commodity});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_input
            // 
            this.menu_input.Name = "menu_input";
            this.menu_input.Size = new System.Drawing.Size(92, 21);
            this.menu_input.Text = "录入商品信息";
            this.menu_input.Click += new System.EventHandler(this.menu_input_Click);
            // 
            // menu_supplier
            // 
            this.menu_supplier.Name = "menu_supplier";
            this.menu_supplier.Size = new System.Drawing.Size(80, 21);
            this.menu_supplier.Text = "录入供应商";
            // 
            // menu_commodity
            // 
            this.menu_commodity.Name = "menu_commodity";
            this.menu_commodity.Size = new System.Drawing.Size(92, 21);
            this.menu_commodity.Text = "管理商品目录";
            this.menu_commodity.Click += new System.EventHandler(this.menu_commodity_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_supplier_phone;
        private System.Windows.Forms.TextBox tb_supplier_addr;
        private System.Windows.Forms.TextBox tb_supplier_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label_username;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_input;
        private System.Windows.Forms.ToolStripMenuItem menu_supplier;
        private System.Windows.Forms.ToolStripMenuItem menu_commodity;
    }
}