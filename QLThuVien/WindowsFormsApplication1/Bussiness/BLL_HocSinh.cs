using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TestThuVien.QLThuVienDTO;

namespace WindowsFormsApplication1.Bussiness
{
    public class BLL_HocSinh
    {

        KetNoiDT data;

       

        public DataTable GetDSHocSinh(ref string err)
        {
            return data.sqlLayDuLieu("PSP_HocSinh_Select", null);
        }

    }
}
