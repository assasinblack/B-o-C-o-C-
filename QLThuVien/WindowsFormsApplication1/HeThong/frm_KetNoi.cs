using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.HeThong
{
    public partial class frm_KetNoi : Form
    {
        public frm_KetNoi()
        {
            InitializeComponent();
        }

        private void ckbKetNoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKetNoi.Checked == true)
            {
                txtID.Enabled = true;
                txtPass.Enabled = true;
                ckbKetNoi.Text = "Kết nối theo quyền SQL";
            }
            else
            {
                txtID.Enabled = false;
                txtPass.Enabled = false;
                ckbKetNoi.Text = "Kết nối theo quyền Windows";
            }
        }

        private void frm_KetNoi_Load(object sender, EventArgs e)
        {
            if (File.Exists(Cls_Main.duongdanfileketnoi))
            {
                Cls_DataLayer data = new Cls_DataLayer(Cls_Main.duongdanfileketnoi);
                if (data.Demsothuoctinh > 2)
                {
                    ckbKetNoi.Checked = true;
                    txtServer.Text = data.Servername;
                    txtDatabase.Text = data.Databasename;
                    txtID.Text = data.Uid;
                    txtPass.Text = data.Pwd;
                }
                else
                {
                    ckbKetNoi.Checked = false;
                    txtServer.Text = data.Servername;
                    txtDatabase.Text = data.Databasename;
                }
            }
            else
            {
                txtServer.Focus();
            }
        }
        private void LuuKetNoi(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                if (ckbKetNoi.Checked == true)
                {
                    sw.WriteLine("servername=" + txtServer.Text);
                    sw.WriteLine("database=" + txtDatabase.Text);
                    sw.WriteLine("userid=" + txtID.Text);
                    sw.Write("password=" + txtPass.Text);
                }
                else
                {
                    sw.WriteLine("servername=" + txtServer.Text);
                    sw.Write("database=" + txtDatabase.Text);
                }
            }
        }
        private void btnLuuKetNoi_Click(object sender, EventArgs e)
        {
            LuuKetNoi(Cls_Main.duongdanfileketnoi);
        }
        string err = "";

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"servername=" + txtServer.Text +";database=" + txtDatabase.Text +";userid=" + txtID.Text + ";password=" + txtPass.Text;
            Cls_DataLayer data = new Cls_DataLayer(cs);
            if(data.kiemtraketnoi(ref err)==true)
                MessageBox.Show("Thành Công.");
            else
                MessageBox.Show("Thất Bại.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
