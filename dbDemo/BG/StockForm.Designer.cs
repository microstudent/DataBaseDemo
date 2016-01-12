namespace dbDemo
{
    partial class StockForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bt_update = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_purchase = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sale = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Controls.Add(this.bt_update);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 397);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "入库信息表";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 20);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(651, 337);
            this.dgv.TabIndex = 2;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(592, 363);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 5;
            this.bt_update.Text = "提交";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_purchase,
            this.menu_sale,
            this.menu_stock});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_purchase
            // 
            this.menu_purchase.Name = "menu_purchase";
            this.menu_purchase.Size = new System.Drawing.Size(68, 21);
            this.menu_purchase.Text = "进货管理";
            this.menu_purchase.Click += new System.EventHandler(this.menu_purchase_Click);
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
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 453);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.ToolStripMenuItem menu_purchase;
        private System.Windows.Forms.ToolStripMenuItem menu_sale;
        private System.Windows.Forms.ToolStripMenuItem menu_stock;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}