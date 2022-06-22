using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoSoSinhVienDAL
    {
        public static SqlDataReader GetHoSoSinhVien(string maSinhVien)
        {
            string query = "exec USP_GetInfoStudentByStudentCode @maSV";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maSinhVien });
        }
    }
}
