namespace WindowsFormsApplication1.HeThong
{
    partial class frm_dangnhap
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
            this.bntdangnhap = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntdangnhap
            // 
            this.bntdangnhap.Location = new System.Drawing.Point(203, 159);
            this.bntdangnhap.Name = "bntdangnhap";
            this.bntdangnhap.Size = new System.Drawing.Size(75, 23);
            this.bntdangnhap.TabIndex = 0;
            this.bntdangnhap.Text = "button1";
            this.bntdangnhap.UseVisualStyleBackColor = true;
            this.bntdangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(203, 45);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(203, 105);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 2;
            // 
            // frm_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 356);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.bntdangnhap);
            this.Name = "frm_dangnhap";
            this.Text = "frm_dangnhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntdangnhap;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
    }
}