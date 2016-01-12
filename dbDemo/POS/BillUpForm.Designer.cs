namespace dbDemo
{
    partial class BillUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_charged = new System.Windows.Forms.TextBox();
            this.bt_yes = new System.Windows.Forms.Button();
            this.bt_no = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sumFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "收取金额：";
            // 
            // tb_charged
            // 
            this.tb_charged.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_charged.Location = new System.Drawing.Point(124, 63);
            this.tb_charged.Name = "tb_charged";
            this.tb_charged.Size = new System.Drawing.Size(153, 35);
            this.tb_charged.TabIndex = 1;
            this.tb_charged.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_charged_KeyDown);
            // 
            // bt_yes
            // 
            this.bt_yes.Location = new System.Drawing.Point(52, 118);
            this.bt_yes.Name = "bt_yes";
            this.bt_yes.Size = new System.Drawing.Size(75, 23);
            this.bt_yes.TabIndex = 2;
            this.bt_yes.Text = "确定";
            this.bt_yes.UseVisualStyleBackColor = true;
            this.bt_yes.Click += new System.EventHandler(this.bt_yes_Click);
            // 
            // bt_no
            // 
            this.bt_no.Location = new System.Drawing.Point(161, 118);
            this.bt_no.Name = "bt_no";
            this.bt_no.Size = new System.Drawing.Size(75, 23);
            this.bt_no.TabIndex = 3;
            this.bt_no.Text = "取消";
            this.bt_no.UseVisualStyleBackColor = true;
            this.bt_no.Click += new System.EventHandler(this.bt_no_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "实收金额：";
            // 
            // tb_sumFinal
            // 
            this.tb_sumFinal.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_sumFinal.Location = new System.Drawing.Point(124, 16);
            this.tb_sumFinal.Name = "tb_sumFinal";
            this.tb_sumFinal.ReadOnly = true;
            this.tb_sumFinal.Size = new System.Drawing.Size(153, 35);
            this.tb_sumFinal.TabIndex = 5;
            // 
            // BillUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 153);
            this.Controls.Add(this.tb_sumFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_no);
            this.Controls.Add(this.bt_yes);
            this.Controls.Add(this.tb_charged);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "BillUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BillUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_charged;
        private System.Windows.Forms.Button bt_yes;
        private System.Windows.Forms.Button bt_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sumFinal;
    }
}