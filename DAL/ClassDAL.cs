using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClassDAL
    {
        public static int InsertClass(string maLop, string tenLop, string maKhoa, string maKhoaHoc, string maCT)
        {
            string query = "INSERT INTO [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES ";
            query += $"(N'{maLop}', N'{tenLop}', N'{maKhoa}', N'{maKhoaHoc}', N'{maCT}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetClassByMaLop(string maLop)
        {
            string query = "SELECT [MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT] FROM[dbo].[Lop]";
            query += $"WHERE [MaLop] = N'{maLop}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static SqlDataReader GetClassByKhoa(string maKhoa)
        {
            string query = "SELECT [MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT] FROM[dbo].[Lop]";
            query += $"WHERE [MaKhoa] = N'{maKhoa}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static SqlDataReader GetAllClass()
        {
            string query = "SELECT [MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT] FROM[dbo].[Lop]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int ModifyClass(string maLop, string tenLop, string maKhoa, string maKhoaHoc, string maCT)
        {
            string query = "UPDATE [dbo].[Lop] SET ";
            query += $"[TenLop] = N'{tenLop}', [MaKhoa] = N'{maKhoa}', [MaKhoaHoc] = N'{maKhoaHoc}', [MaCT] = N'{maCT}' ";
            query += $"WHERE [MaLop] = N'{maLop}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int DeleteClass(string maLop)
        {
            string query = "DELETE FROM [dbo].[Lop] WHERE ";
            query += $"[MaLop] = N'{maLop}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
