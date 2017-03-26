using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_capnhat : Form
    {
        public frm_capnhat()
        {
            InitializeComponent();
        }
        public bool them = true;

        private void frm_capnhat_Load(object sender, EventArgs e)
        {
            if(them==true)
            {
                lblPanel.Text = "Thêm Sách";
            }
            else
            {
                lblPanel.Text = "Sửa Sách";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
