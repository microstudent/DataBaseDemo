namespace dbDemo
{
    partial class PurchaseForm
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
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.dtp_arr_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_stock_time = new System.Windows.Forms.DateTimePicker();
            this.tb_quantity_planned = new System.Windows.Forms.TextBox();
            this.tb_s_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_purchase = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sale = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Controls.Add(this.tb_price);
            this.groupBox1.Controls.Add(this.dtp_arr_time);
            this.groupBox1.Controls.Add(this.dtp_stock_time);
            this.groupBox1.Controls.Add(this.tb_quantity_planned);
            this.groupBox1.Controls.Add(this.tb_s_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改进货信息";
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(224, 308);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 11;
            this.bt_reset.Text = "重置";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(34, 308);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 10;
            this.bt_add.Text = "提交";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(130, 138);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 21);
            this.tb_price.TabIndex = 9;
            // 
            // dtp_arr_time
            // 
            this.dtp_arr_time.Location = new System.Drawing.Point(130, 240);
            this.dtp_arr_time.Name = "dtp_arr_time";
            this.dtp_arr_time.Size = new System.Drawing.Size(128, 21);
            this.dtp_arr_time.TabIndex = 8;
            // 
            // dtp_stock_time
            // 
            this.dtp_stock_time.Location = new System.Drawing.Point(130, 189);
            this.dtp_stock_time.Name = "dtp_stock_time";
            this.dtp_stock_time.Size = new System.Drawing.Size(128, 21);
            this.dtp_stock_time.TabIndex = 7;
            // 
            // tb_quantity_planned
            // 
            this.tb_quantity_planned.Location = new System.Drawing.Point(130, 87);
            this.tb_quantity_planned.Name = "tb_quantity_planned";
            this.tb_quantity_planned.Size = new System.Drawing.Size(100, 21);
            this.tb_quantity_planned.TabIndex = 6;
            // 
            // tb_s_name
            // 
            this.tb_s_name.Location = new System.Drawing.Point(130, 36);
            this.tb_s_name.Name = "tb_s_name";
            this.tb_s_name.ReadOnly = true;
            this.tb_s_name.Size = new System.Drawing.Size(100, 21);
            this.tb_s_name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "进货商品名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "进货单价*：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "计划进货日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "入库日期*：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "计划进货数量*：";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 20);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(361, 332);
            this.dgv.TabIndex = 2;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(370, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 358);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "需要进货的商品";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_purchase,
            this.menu_sale,
            this.menu_stock});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_purchase
            // 
            this.menu_purchase.Name = "menu_purchase";
            this.menu_purchase.Size = new System.Drawing.Size(68, 21);
            this.menu_purchase.Text = "进货管理";
            // 
            // menu_sale
            // 
            this.menu_sale.Name = "menu_sale";
            this.menu_sale.Size = new System.Drawing.Size(68, 21);
            this.menu_sale.Text = "销售管理";
            this.menu_sale.Click += new System.EventHandler(this.menu_sale_Click);
            // 
            // menu_stock
            // 
            this.menu_stock.Name = "menu_stock";
            this.menu_stock.Size = new System.Drawing.Size(68, 21);
            this.menu_stock.Text = "库存管理";
            this.menu_stock.Click += new System.EventHandler(this.menu_stock_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 398);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.DateTimePicker dtp_arr_time;
        private System.Windows.Forms.DateTimePicker dtp_stock_time;
        private System.Windows.Forms.TextBox tb_quantity_planned;
        private System.Windows.Forms.TextBox tb_s_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem menu_purchase;
        private System.Windows.Forms.ToolStripMenuItem menu_sale;
        private System.Windows.Forms.ToolStripMenuItem menu_stock;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}