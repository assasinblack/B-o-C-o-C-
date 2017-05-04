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
            this.bnttienhanh = new System.Windows.Forms.Button();
            this.bntrestore = new System.Windows.Forms.Button();
            this.bntgetlink = new System.Windows.Forms.Button();
            this.rdobackup = new System.Windows.Forms.RadioButton();
            this.radiorestore = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn:";
            // 
            // txtduongdan
            // 
            this.txtduongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtduongdan.Location = new System.Drawing.Point(197, 129);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(240, 23);
            this.txtduongdan.TabIndex = 1;
            // 
            // bnttienhanh
            // 
            this.bnttienhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnttienhanh.Location = new System.Drawing.Point(65, 258);
            this.bnttienhanh.Name = "bnttienhanh";
            this.bnttienhanh.Size = new System.Drawing.Size(111, 30);
            this.bnttienhanh.TabIndex = 4;
            this.bnttienhanh.Text = "Tiến hành";
            this.bnttienhanh.UseVisualStyleBackColor = true;
            this.bnttienhanh.Click += new System.EventHandler(this.bnttienhanh_Click);
            // 
            // bntrestore
            // 
            this.bntrestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntrestore.Location = new System.Drawing.Point(239, 258);
            this.bntrestore.Name = "bntrestore";
            this.bntrestore.Size = new System.Drawing.Size(111, 30);
            this.bntrestore.TabIndex = 5;
            this.bntrestore.Text = "Thoát";
            this.bntrestore.UseVisualStyleBackColor = true;
            this.bntrestore.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntgetlink
            // 
            this.bntgetlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntgetlink.Location = new System.Drawing.Point(168, 166);
            this.bntgetlink.Name = "bntgetlink";
            this.bntgetlink.Size = new System.Drawing.Size(111, 30);
            this.bntgetlink.TabIndex = 6;
            this.bntgetlink.Text = "get link";
            this.bntgetlink.UseVisualStyleBackColor = true;
            this.bntgetlink.Click += new System.EventHandler(this.bntgetlink_Click);
            // 
            // rdobackup
            // 
            this.rdobackup.AutoSize = true;
            this.rdobackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobackup.Location = new System.Drawing.Point(87, 202);
            this.rdobackup.Name = "rdobackup";
            this.rdobackup.Size = new System.Drawing.Size(79, 24);
            this.rdobackup.TabIndex = 8;
            this.rdobackup.TabStop = true;
            this.rdobackup.Text = "backup";
            this.rdobackup.UseVisualStyleBackColor = true;
            // 
            // radiorestore
            // 
            this.radiorestore.AutoSize = true;
            this.radiorestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiorestore.Location = new System.Drawing.Point(273, 202);
            this.radiorestore.Name = "radiorestore";
            this.radiorestore.Size = new System.Drawing.Size(77, 24);
            this.radiorestore.TabIndex = 9;
            this.radiorestore.TabStop = true;
            this.radiorestore.Text = "restore";
            this.radiorestore.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "BACKUP VÀ RESTORE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_saoluuphuchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdobackup);
            this.Controls.Add(this.radiorestore);
            this.Controls.Add(this.bntgetlink);
            this.Controls.Add(this.bntrestore);
            this.Controls.Add(this.bnttienhanh);
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
        private System.Windows.Forms.Button bnttienhanh;
        private System.Windows.Forms.Button bntrestore;
        private System.Windows.Forms.Button bntgetlink;
        private System.Windows.Forms.RadioButton rdobackup;
        private System.Windows.Forms.RadioButton radiorestore;
        private System.Windows.Forms.Label label2;
    }
}