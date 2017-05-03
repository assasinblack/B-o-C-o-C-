namespace WindowsFormsApplication1
{
    partial class frm_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tctHeThong = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMuonTraSach = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnTacGia = new System.Windows.Forms.Button();
            this.btnQLHS = new System.Windows.Forms.Button();
            this.dgvChoThue = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tctHeThong.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tctHeThong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 131);
            this.panel1.TabIndex = 3;
            // 
            // tctHeThong
            // 
            this.tctHeThong.Controls.Add(this.tabPage1);
            this.tctHeThong.Controls.Add(this.tabPage2);
            this.tctHeThong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctHeThong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tctHeThong.Location = new System.Drawing.Point(0, 0);
            this.tctHeThong.Name = "tctHeThong";
            this.tctHeThong.SelectedIndex = 0;
            this.tctHeThong.Size = new System.Drawing.Size(1325, 131);
            this.tctHeThong.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1317, 99);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hệ Thống";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OldLace;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Image = global::WindowsFormsApplication1.Properties.Resources.Exit_Filled_50;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(569, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 81);
            this.button5.TabIndex = 1;
            this.button5.Text = "Thoát";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OldLace;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Image = global::WindowsFormsApplication1.Properties.Resources.Receive_Cash_Filled_50;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(430, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 81);
            this.button4.TabIndex = 2;
            this.button4.Text = "Phân quyền";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OldLace;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Image = global::WindowsFormsApplication1.Properties.Resources.Restore_Window_Filled_50;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(291, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 81);
            this.button3.TabIndex = 3;
            this.button3.Text = "Phục hồi";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OldLace;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.Data_Backup_Filled_50;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(152, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 81);
            this.button2.TabIndex = 4;

            this.button2.Text = "Sau lưu      ";

            this.button2.Text = "Sao lưu";

            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.Key_Filled_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(13, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 81);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OldLace;
            this.tabPage2.Controls.Add(this.btnMuonTraSach);
            this.tabPage2.Controls.Add(this.btnSach);
            this.tabPage2.Controls.Add(this.btnTacGia);
            this.tabPage2.Controls.Add(this.btnQLHS);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1317, 99);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh Mục";
            // 
            // btnMuonTraSach
            // 
            this.btnMuonTraSach.BackColor = System.Drawing.Color.OldLace;
            this.btnMuonTraSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMuonTraSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuonTraSach.FlatAppearance.BorderSize = 0;
            this.btnMuonTraSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnMuonTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTraSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuonTraSach.Image = global::WindowsFormsApplication1.Properties.Resources.Borrow_Book_Filled_50;
            this.btnMuonTraSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMuonTraSach.Location = new System.Drawing.Point(509, 5);
            this.btnMuonTraSach.Name = "btnMuonTraSach";
            this.btnMuonTraSach.Size = new System.Drawing.Size(149, 91);
            this.btnMuonTraSach.TabIndex = 2;
            this.btnMuonTraSach.Text = "Mượn - Trả Sách";
            this.btnMuonTraSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuonTraSach.UseVisualStyleBackColor = false;
            this.btnMuonTraSach.Click += new System.EventHandler(this.btnMuonTraSach_Click);
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.OldLace;
            this.btnSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSach.Image = global::WindowsFormsApplication1.Properties.Resources.Courses_Filled_50;
            this.btnSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSach.Location = new System.Drawing.Point(344, 6);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(149, 91);
            this.btnSach.TabIndex = 2;
            this.btnSach.Text = "Quản lý Sách";
            this.btnSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.BackColor = System.Drawing.Color.OldLace;
            this.btnTacGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTacGia.FlatAppearance.BorderSize = 0;
            this.btnTacGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTacGia.Image = global::WindowsFormsApplication1.Properties.Resources.Pen_Filled_50;
            this.btnTacGia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTacGia.Location = new System.Drawing.Point(176, 6);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(149, 91);
            this.btnTacGia.TabIndex = 2;
            this.btnTacGia.Text = "Quản lý Tác Giả";
            this.btnTacGia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTacGia.UseVisualStyleBackColor = false;
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // btnQLHS
            // 
            this.btnQLHS.BackColor = System.Drawing.Color.OldLace;
            this.btnQLHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQLHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHS.FlatAppearance.BorderSize = 0;
            this.btnQLHS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnQLHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLHS.Image = global::WindowsFormsApplication1.Properties.Resources.Student_Male_Filled_50;
            this.btnQLHS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLHS.Location = new System.Drawing.Point(8, 6);
            this.btnQLHS.Name = "btnQLHS";
            this.btnQLHS.Size = new System.Drawing.Size(149, 91);
            this.btnQLHS.TabIndex = 2;
            this.btnQLHS.Text = "Quản lý Học Sinh";
            this.btnQLHS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLHS.UseVisualStyleBackColor = false;
            this.btnQLHS.Click += new System.EventHandler(this.btnQLHS_Click);
            // 
            // dgvChoThue
            // 
            this.dgvChoThue.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChoThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChoThue.Location = new System.Drawing.Point(0, 131);
            this.dgvChoThue.Name = "dgvChoThue";
            this.dgvChoThue.Size = new System.Drawing.Size(1325, 603);
            this.dgvChoThue.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.BG;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.BG;
            this.pictureBox1.Location = new System.Drawing.Point(0, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1325, 603);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1325, 734);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvChoThue);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tctHeThong.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tctHeThong;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnTacGia;
        private System.Windows.Forms.Button btnQLHS;
        private System.Windows.Forms.DataGridView dgvChoThue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMuonTraSach;


    }
}

