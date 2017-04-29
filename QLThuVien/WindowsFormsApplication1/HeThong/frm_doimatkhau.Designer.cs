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
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.txtnhaplaimkmoi = new System.Windows.Forms.TextBox();
            this.cmbtaikhoan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntdoimatkhau
            // 
            this.bntdoimatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdoimatkhau.Location = new System.Drawing.Point(50, 237);
            this.bntdoimatkhau.Name = "bntdoimatkhau";
            this.bntdoimatkhau.Size = new System.Drawing.Size(112, 36);
            this.bntdoimatkhau.TabIndex = 0;
            this.bntdoimatkhau.Text = "Lưu";
            this.bntdoimatkhau.UseVisualStyleBackColor = true;
            this.bntdoimatkhau.Click += new System.EventHandler(this.bntdoimatkhau_Click);
            // 
            // txtmkcu
            // 
            this.txtmkcu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkcu.Location = new System.Drawing.Point(181, 69);
            this.txtmkcu.Multiline = true;
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(208, 25);
            this.txtmkcu.TabIndex = 2;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkmoi.Location = new System.Drawing.Point(181, 120);
            this.txtmkmoi.Multiline = true;
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(208, 25);
            this.txtmkmoi.TabIndex = 3;
            // 
            // txtnhaplaimkmoi
            // 
            this.txtnhaplaimkmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhaplaimkmoi.Location = new System.Drawing.Point(181, 171);
            this.txtnhaplaimkmoi.Multiline = true;
            this.txtnhaplaimkmoi.Name = "txtnhaplaimkmoi";
            this.txtnhaplaimkmoi.Size = new System.Drawing.Size(208, 25);
            this.txtnhaplaimkmoi.TabIndex = 4;
            // 
            // cmbtaikhoan
            // 
            this.cmbtaikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtaikhoan.FormattingEnabled = true;
            this.cmbtaikhoan.Location = new System.Drawing.Point(181, 16);
            this.cmbtaikhoan.Name = "cmbtaikhoan";
            this.cmbtaikhoan.Size = new System.Drawing.Size(208, 27);
            this.cmbtaikhoan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập lại MK mới:";
            // 
            // bntthoat
            // 
            this.bntthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntthoat.Location = new System.Drawing.Point(235, 237);
            this.bntthoat.Name = "bntthoat";
            this.bntthoat.Size = new System.Drawing.Size(112, 36);
            this.bntthoat.TabIndex = 10;
            this.bntthoat.Text = "Thoát";
            this.bntthoat.UseVisualStyleBackColor = true;
            this.bntthoat.Click += new System.EventHandler(this.bntthoat_Click);
            // 
            // frm_doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 285);
            this.Controls.Add(this.bntthoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbtaikhoan);
            this.Controls.Add(this.txtnhaplaimkmoi);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.bntdoimatkhau);
            this.Name = "frm_doimatkhau";
            this.Text = "frm_doimatkhau";
            this.Load += new System.EventHandler(this.frm_doimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntdoimatkhau;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.TextBox txtnhaplaimkmoi;
        private System.Windows.Forms.ComboBox cmbtaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntthoat;
    }
}