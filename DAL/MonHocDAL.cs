using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonHocDAL
    {
        public static int InsertMonHoc(string maMonHoc, string maKhoa, string tenMonHoc, string soTinChi)
        {
            string query = "INSERT INTO [dbo].[MonHoc] ([MaMH], [MaKhoa], [TenMH], [SoTinChi]) VALUES ";
            query += $"(N'{maMonHoc}', N'{maKhoa}', N'{tenMonHoc}', N'{soTinChi}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetAllMonHoc()
        {
            string query = "SELECT [MaMH], [MaKhoa], [TenMH], [SoTinChi] FROM[dbo].[MonHoc]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int ModifyClass(string maMonHoc, string maKhoa, string tenMonHoc, string soTinChi)
        {
            string query = "UPDATE [dbo].[MonHoc] SET ";
            query += $"[MaKhoa] = N'{maKhoa}', [TenMH] = N'{tenMonHoc}', [SoTinChi] = N'{soTinChi}' ";
            query += $"WHERE [MaMH] = N'{maMonHoc}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int DeleteMonHoc(string maMonHoc)
        {
            string query = "DELETE FROM [dbo].[MonHoc] WHERE ";
            query += $"[MaMH] = N'{maMonHoc}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
