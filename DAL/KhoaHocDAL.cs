using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaHocDAL
    {
        public static int InsertKhoaHoc(string maKhoaHoc, string namBatDau, string namKetThuc)
        {
            string query = "INSERT INTO[dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES ";
            query += $"(N'{maKhoaHoc}', N'{namBatDau}', N'{namKetThuc}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetAllKhoaHoc()
        {
            string query = "SELECT [MaKhoaHoc], [NamBatDau], [NamKetThuc] FROM[dbo].[KhoaHoc]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int DeleteKhoaHoc(string maKhoaHoc)
        {
            string query = "DELETE FROM [dbo].[KhoaHoc] WHERE ";
            query += $"[MaKhoaHoc] = N'{maKhoaHoc}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int ModifyKhoaHoc(string maKhoaHoc, string namBatDau, string namKetThuc)
        {
            string query = "UPDATE [dbo].[KhoaHoc] SET ";
            query += $"[NamBatDau] = N'{namBatDau}', [NamKetThuc] = N'{namKetThuc}' WHERE [MaKhoaHoc] = N'{maKhoaHoc}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
