using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaDAL
    {
        public static int InsertKhoa(string maKhoa, string tenKhoa, string namThanhLap)
        {
            string query = "INSERT INTO [dbo].[Khoa] ([MaKhoa] ,[TenKhoa] ,[NamThanhLap]) VALUES ";
            query += $"(N'{maKhoa}', N'{tenKhoa}', N'{namThanhLap}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetKhoaByMaKhoa(string maKhoa)
        {
            string query = "SELECT [MaKhoa], [TenKhoa], [NamThanhLap] FROM[dbo].[Khoa] ";
            query += $"WHERE [MaKhoa] = N'{maKhoa}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static SqlDataReader GetAllKhoa()
        {
            string query = "SELECT [MaKhoa], [TenKhoa], [NamThanhLap] FROM[dbo].[Khoa]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int DeleteKhoa(string maKhoa)
        {
            string query = "DELETE FROM [dbo].[Khoa] WHERE ";
            query += $"[MaKhoa] = N'{maKhoa}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int ModifyKhoa(string maKhoa, string tenKhoa, string namThanhLap)
        {
            string query = "UPDATE [dbo].[Khoa] SET ";
            query += $"[TenKhoa] = N'{tenKhoa}', [NamThanhLap] = N'{namThanhLap}' ";
            query += $" WHERE [MaKhoa] = N'{maKhoa}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
