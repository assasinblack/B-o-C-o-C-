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
        private bool backuprestore()
        {
            if (cbbackup.Checked == true)
                return true;
            else
                return false;
        }
        private void frm_saoluuphuchoi_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
