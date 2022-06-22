using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChuongTrinhHocDAL
    {
        public static int InsertChuongTrinhHoc(string maChuongTrinhHoc, string tenChuongTrinhHoc)
        {
            string query = "INSERT INTO [dbo].[ChuongTrinhHoc] ([MaCT], [TenCT]) VALUES ";
            query += $"(N'{maChuongTrinhHoc}', N'{tenChuongTrinhHoc}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int DeleteChuongTrinhHoc(string maChuongTrinhHoc)
        {
            string query = "DELETE FROM [dbo].[ChuongTrinhHoc] ";
            query += $"WHERE [MaCT] = N'{maChuongTrinhHoc}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetAllChuongTrinhHoc()
        {
            string query = "SELECT [MaCT], [TenCT] FROM[dbo].[ChuongTrinhHoc]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int ModifyChuongTrinhHoc(string maChuongTrinhHoc, string tenChuongTrinhHoc)
        {
            string query = "UPDATE [dbo].[ChuongTrinhHoc] SET ";
            query += $"[TenCT] = N'{tenChuongTrinhHoc}' WHERE [MaCT] = N'{maChuongTrinhHoc}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
