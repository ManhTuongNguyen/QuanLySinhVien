using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Diem_SinhVienDAL
    {
        public static SqlDataReader GetDiemByStudentCode(string maSinhVien)
        {
            string query = "exec USP_GetDiemByStudentCode @maSV";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maSinhVien });
        }
    }
}
