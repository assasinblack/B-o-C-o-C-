namespace WindowsFormsApplication1.HeThong
{
    partial class frm_doimatkhau
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
            this.bntdoimatkhau = new System.Windows.Forms.Button();
            this.txtmaukhaucu = new System.Windows.Forms.TextBox();
            this.txtnhaplai = new System.Windows.Forms.TextBox();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bntdoimatkhau
            // 
            this.bntdoimatkhau.Location = new System.Drawing.Point(82, 236);
            this.bntdoimatkhau.Name = "bntdoimatkhau";
            this.bntdoimatkhau.Size = new System.Drawing.Size(75, 23);
            this.bntdoimatkhau.TabIndex = 0;
            this.bntdoimatkhau.Text = "Lưu";
            this.bntdoimatkhau.UseVisualStyleBackColor = true;
            // 
            // txtmaukhaucu
            // 
            this.txtmaukhaucu.Location = new System.Drawing.Point(129, 88);
            this.txtmaukhaucu.Multiline = true;
            this.txtmaukhaucu.Name = "txtmaukhaucu";
            this.txtmaukhaucu.Size = new System.Drawing.Size(208, 33);
            this.txtmaukhaucu.TabIndex = 2;
            // 
            // txtnhaplai
            // 
            this.txtnhaplai.Location = new System.Drawing.Point(129, 132);
            this.txtnhaplai.Multiline = true;
            this.txtnhaplai.Name = "txtnhaplai";
            this.txtnhaplai.Size = new System.Drawing.Size(208, 33);
            this.txtnhaplai.TabIndex = 3;
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Location = new System.Drawing.Point(129, 171);
            this.txtmatkhaumoi.Multiline = true;
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(208, 33);
            this.txtmatkhaumoi.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // frm_doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 285);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtmatkhaumoi);
            this.Controls.Add(this.txtnhaplai);
            this.Controls.Add(this.txtmaukhaucu);
            this.Controls.Add(this.bntdoimatkhau);
            this.Name = "frm_doimatkhau";
            this.Text = "frm_doimatkhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntdoimatkhau;
        private System.Windows.Forms.TextBox txtmaukhaucu;
        private System.Windows.Forms.TextBox txtnhaplai;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}