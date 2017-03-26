using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.HeThong
{
    public partial class frm_saoluuphuchoi : Form
    {
        public frm_saoluuphuchoi()
        {
            InitializeComponent();
        }

        private void tsbsaoluu_Click(object sender, EventArgs e)
        {

        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool saoluu = true;
        private void btnlayfile_Click(object sender, EventArgs e)
        {
            if (saoluu == true)
            {
                SaveFileDialog _save = new SaveFileDialog();
                _save.Filter = "Text backup (*.bak)|*.bak|All files (*.*)|*.*";
                _save.FileName = "Filebackup" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + ".bak";
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    txtlayfile.Text = _save.FileName;
                }
            }
            else
            {
                OpenFileDialog _save = new OpenFileDialog();
                _save.Filter = "Text backup (*.bak)|*.bak|All files (*.*)|*.*";
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    txtlayfile.Text = _save.FileName;
                }
            }
        }

        private void frm_saoluuphuchoi_Load(object sender, EventArgs e)
        {
            if (saoluu == false)
            {
                btnsaoluu.Text = "Phục hồi";
                lblpanel.Text = "Phục hồi lại dữ liệu";
            }
            else
            {
                btnsaoluu.Text = "Sao Lưu";
                lblpanel.Text = "Sao lưu dữ liệu";
                
            }

        }
    }
}
