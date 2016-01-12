namespace dbDemo
{
    partial class SaleForm
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
            this.dgv_sale = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_purchase = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sale = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_sale);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 358);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品销量排行榜";
            // 
            // dgv_sale
            // 
            this.dgv_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sale.Location = new System.Drawing.Point(6, 20);
            this.dgv_sale.Name = "dgv_sale";
            this.dgv_sale.RowTemplate.Height = 23;
            this.dgv_sale.Size = new System.Drawing.Size(361, 332);
            this.dgv_sale.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_user);
            this.groupBox1.Location = new System.Drawing.Point(410, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 358);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "销售员排行榜";
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(6, 20);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowTemplate.Height = 23;
            this.dgv_user.Size = new System.Drawing.Size(361, 332);
            this.dgv_user.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_purchase,
            this.menu_sale,
            this.menu_stock});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 25);
            this.menuStrip1.TabIndex = 10;
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
            // 
            // menu_stock
            // 
            this.menu_stock.Name = "menu_stock";
            this.menu_stock.Size = new System.Drawing.Size(68, 21);
            this.menu_stock.Text = "库存管理";
            this.menu_stock.Click += new System.EventHandler(this.menu_stock_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 443);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_sale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.ToolStripMenuItem menu_purchase;
        private System.Windows.Forms.ToolStripMenuItem menu_sale;
        private System.Windows.Forms.ToolStripMenuItem menu_stock;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}