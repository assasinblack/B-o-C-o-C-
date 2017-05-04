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
            this.label1 = new System.Windows.Forms.Label();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.cbbackup = new System.Windows.Forms.CheckBox();
            this.cbrestore = new System.Windows.Forms.CheckBox();
            this.bntbackup = new System.Windows.Forms.Button();
            this.bntrestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn:";
            // 
            // txtduongdan
            // 
            this.txtduongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtduongdan.Location = new System.Drawing.Point(244, 79);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(240, 23);
            this.txtduongdan.TabIndex = 1;
            // 
            // cbbackup
            // 
            this.cbbackup.AutoSize = true;
            this.cbbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cbbackup.Location = new System.Drawing.Point(147, 156);
            this.cbbackup.Name = "cbbackup";
            this.cbbackup.Size = new System.Drawing.Size(73, 21);
            this.cbbackup.TabIndex = 2;
            this.cbbackup.Text = "backup";
            this.cbbackup.UseVisualStyleBackColor = true;
            // 
            // cbrestore
            // 
            this.cbrestore.AutoSize = true;
            this.cbrestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cbrestore.Location = new System.Drawing.Point(403, 156);
            this.cbrestore.Name = "cbrestore";
            this.cbrestore.Size = new System.Drawing.Size(72, 21);
            this.cbrestore.TabIndex = 3;
            this.cbrestore.Text = "restore";
            this.cbrestore.UseVisualStyleBackColor = true;
            // 
            // bntbackup
            // 
            this.bntbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntbackup.Location = new System.Drawing.Point(147, 350);
            this.bntbackup.Name = "bntbackup";
            this.bntbackup.Size = new System.Drawing.Size(111, 30);
            this.bntbackup.TabIndex = 4;
            this.bntbackup.Text = "BACKUP";
            this.bntbackup.UseVisualStyleBackColor = true;
            // 
            // bntrestore
            // 
            this.bntrestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntrestore.Location = new System.Drawing.Point(302, 350);
            this.bntrestore.Name = "bntrestore";
            this.bntrestore.Size = new System.Drawing.Size(111, 30);
            this.bntrestore.TabIndex = 5;
            this.bntrestore.Text = "RESTORE";
            this.bntrestore.UseVisualStyleBackColor = true;
            this.bntrestore.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_saoluuphuchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 453);
            this.Controls.Add(this.bntrestore);
            this.Controls.Add(this.bntbackup);
            this.Controls.Add(this.cbrestore);
            this.Controls.Add(this.cbbackup);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.label1);
            this.Name = "frm_saoluuphuchoi";
            this.Text = "frm_saoluuphuchoi";
            this.Load += new System.EventHandler(this.frm_saoluuphuchoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.CheckBox cbbackup;
        private System.Windows.Forms.CheckBox cbrestore;
        private System.Windows.Forms.Button bntbackup;
        private System.Windows.Forms.Button bntrestore;
    }
}