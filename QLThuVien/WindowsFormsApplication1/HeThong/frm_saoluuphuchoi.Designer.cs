namespace WindowsFormsApplication1.HeThong
{
    partial class frm_saoluuphuchoi
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnsaoluu = new System.Windows.Forms.ToolStripButton();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            this.lblpanel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlayfile = new System.Windows.Forms.TextBox();
            this.btnlayfile = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 108);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerr
            // 
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnsaoluu,
            this.tsbthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnsaoluu
            // 
            this.btnsaoluu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnsaoluu.Image = global::WindowsFormsApplication1.Properties.Resources.Restore_Window_Filled_50;
            this.btnsaoluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsaoluu.Name = "btnsaoluu";
            this.btnsaoluu.Size = new System.Drawing.Size(74, 22);
            this.btnsaoluu.Text = "Sao lưu";
            this.btnsaoluu.Click += new System.EventHandler(this.tsbsaoluu_Click);
            // 
            // tsbthoat
            // 
            this.tsbthoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.tsbthoat.Image = global::WindowsFormsApplication1.Properties.Resources.Exit_Filled_50;
            this.tsbthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthoat.Name = "tsbthoat";
            this.tsbthoat.Size = new System.Drawing.Size(63, 22);
            this.tsbthoat.Text = "Thoát";
            this.tsbthoat.Click += new System.EventHandler(this.tsbthoat_Click);
            // 
            // lblpanel
            // 
            this.lblpanel.BackColor = System.Drawing.Color.Turquoise;
            this.lblpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblpanel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpanel.Location = new System.Drawing.Point(0, 25);
            this.lblpanel.Name = "lblpanel";
            this.lblpanel.Size = new System.Drawing.Size(580, 33);
            this.lblpanel.TabIndex = 2;
            this.lblpanel.Text = "SAO LƯU";
            this.lblpanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL:";
            // 
            // txtlayfile
            // 
            this.txtlayfile.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlayfile.Location = new System.Drawing.Point(72, 67);
            this.txtlayfile.Name = "txtlayfile";
            this.txtlayfile.Size = new System.Drawing.Size(402, 29);
            this.txtlayfile.TabIndex = 4;
            // 
            // btnlayfile
            // 
            this.btnlayfile.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlayfile.Location = new System.Drawing.Point(480, 67);
            this.btnlayfile.Name = "btnlayfile";
            this.btnlayfile.Size = new System.Drawing.Size(88, 29);
            this.btnlayfile.TabIndex = 5;
            this.btnlayfile.Text = "Browers";
            this.btnlayfile.UseVisualStyleBackColor = true;
            this.btnlayfile.Click += new System.EventHandler(this.btnlayfile_Click);
            // 
            // frm_saoluuphuchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 130);
            this.Controls.Add(this.btnlayfile);
            this.Controls.Add(this.txtlayfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frm_saoluuphuchoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao Lưu - Phục Hồi";
            this.Load += new System.EventHandler(this.frm_saoluuphuchoi_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnsaoluu;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private System.Windows.Forms.Label lblpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlayfile;
        private System.Windows.Forms.Button btnlayfile;
        private System.Windows.Forms.ToolStripStatusLabel lblerr;
    }
}