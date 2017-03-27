using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Bussiness
{
    public class BLL_DangNhap
    {
        Cls_DataLayer data;
        public BLL_DangNhap(string path)
        {
            data = new Cls_DataLayer(path);
        }
        public bool KTraKetNoi(ref string err)
        {
            return data.kiemtraketnoi(ref err);
        }
        public SqlDataReader KTraLogin(ref string err, string taikhoan,string matkhau)
        {
            return data.MyExcuteReader(ref err, "SP_KiemTraDangNhap", CommandType.StoredProcedure,
                new SqlParameter("@taikhoan", taikhoan),
                new SqlParameter("@matkhau", matkhau));
        }
    }
}
