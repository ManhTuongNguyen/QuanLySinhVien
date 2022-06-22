using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InfoContactStudentDAL
    {
        public static int InsertContactStudent(string maSV, string SDTSV, string emailSV, string tenNguoiThan, string SDTNguoiThan)
        {
            string query = "INSERT INTO [dbo].[LienHe] ([MaSV], [SDTSinhVien], [EmailSinhVien], [HoTenNguoiThan], [SDTNguoiThan]) VALUES ";
            query += $"(N'{maSV}', N'{SDTSV}', N'{emailSV}', N'{tenNguoiThan}', N'{SDTNguoiThan}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetAllContactStudent()
        {
            string query = "SELECT [MaSV], [SDTSinhVien], [EmailSinhVien], [HoTenNguoiThan], [SDTNguoiThan] FROM[dbo].[LienHe]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static SqlDataReader GetContactStudentByStudentCode(string maSV)
        {
            string query = "SELECT [MaSV], [SDTSinhVien], [EmailSinhVien], [HoTenNguoiThan], [SDTNguoiThan] FROM[dbo].[LienHe] ";
            query += $"WHERE [MaSV] = N'{maSV}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int DeleteContactByStudentCode(string mSV)
        {
            string query = "DELETE FROM [dbo].[LienHe] WHERE ";
            query += $"[MaSV] = N'{mSV}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int ModifyContactStudent(string maSV, string sDTSV, string emailSV, string tenNguoiThan, string sDTNguoiThan)
        {
            string query = $"UPDATE [dbo].[LienHe] SET [SDTSinhVien] = N'{sDTSV}'," +
                $" [EmailSinhVien] = N'{emailSV}', [HoTenNguoiThan] = N'{tenNguoiThan}'," +
                $" [SDTNguoiThan] = N'{sDTNguoiThan}' WHERE [MaSV] = N'{maSV}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
