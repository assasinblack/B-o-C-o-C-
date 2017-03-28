using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication1.Bussiness
{
   public  class BLL_tacgia
    {
       Cls_DataLayer data;
       public BLL_tacgia(string path)
       {
           data = new Cls_DataLayer(path);
       }
       public DataTable GetTacGia(ref string err)
       {
           return data.GetDataTable(ref err, "PSP_TacGia_Select", CommandType.StoredProcedure, null);
       }
       public bool insertNewSanPham(ref string err, DTO.DTO_tacgia _tacgia, double dongia,string MaTG)
       {
           return data.MyExcuteNonQuery(ref err, "PSP_TacGia_Insert", CommandType.StoredProcedure,
                 new SqlParameter("@MaTG", _tacgia.MaTG1),
                   new SqlParameter("@DVT", _tacgia.HoTenTG1));
                     
       }
    }
}
