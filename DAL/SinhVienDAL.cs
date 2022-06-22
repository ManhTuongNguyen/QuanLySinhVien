using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVienDAL
    {
        public static int InsertSinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, string queQuan, string danToc, string maLop, string tinhTrang)
        {
            string query = "INSERT INTO [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES ";
            query += $"(N'{maSV}', N'{hoTen}', N'{ngaySinh}', N'{gioiTinh}', N'{queQuan}', N'{danToc}', N'{maLop}', N'{tinhTrang}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetSinhVienByMaSV(string maSV)
        {
            string query = "SELECT [MaSV] ,[HoTen] ,[NgaySinh] ,[GioiTinh], [QueQuan] ,[DanToc] ,[MaLop], [TinhTrang] FROM[dbo].[SinhVien] ";
            query += $"where [MaSV] = N'{maSV}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int DeleteSinhVien(string maSinhVien)
        {
            string query = "DELETE FROM [dbo].[SinhVien] WHERE ";
            query += $"[MaSV] = N'{maSinhVien}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int ModifySinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, string queQuan, string danToc, string maLop, string tinhTrang)
        {
            string query = $"UPDATE [dbo].[SinhVien] SET [HoTen] = N'{hoTen}', [NgaySinh] = N'{ngaySinh}', ";
            query += $"[GioiTinh] = N'{gioiTinh}', [QueQuan] = N'{queQuan}', [DanToc] = N'{danToc}', ";
            query += $"[MaLop] = N'{maLop}', [TinhTrang] = N'{tinhTrang}' WHERE [MaSV] = N'{maSV}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetAllSinhVien()
        {
            string query = "SELECT [MaSV] ,[HoTen] ,[NgaySinh] ,[GioiTinh], [QueQuan] ,[DanToc] ,[MaLop], [TinhTrang] FROM[dbo].[SinhVien]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static SqlDataReader GetAllStudentByClassCode(string maLop)
        {
            string query = "SELECT [MaSV] ,[HoTen] ,[NgaySinh] ,[GioiTinh], [QueQuan] ,[DanToc] ,[MaLop], [TinhTrang] FROM [dbo].[SinhVien] ";
            query += $"WHERE [MaLop] = N'{maLop}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static SqlDataReader GetAllStudentByStatus(string tinhTrang)
        {
            string query = "SELECT [MaSV] ,[HoTen] ,[NgaySinh] ,[GioiTinh], [QueQuan] ,[DanToc] ,[MaLop], [TinhTrang] FROM [dbo].[SinhVien] ";
            query += $"WHERE [TinhTrang] = N'{tinhTrang}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
