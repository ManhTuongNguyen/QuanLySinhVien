using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KetQuaDAL
    {
        public static int InsertKetQua(string maSinhVien, string maMonHoc, string diemLan1, string diemLan2)
        {
            string query = "INSERT INTO [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES ";
            query += $"(N'{maSinhVien}', N'{maMonHoc}', N'{diemLan1}', N'{diemLan2}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetKetQuaByMaSV()
        {
            string query = "SELECT [MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2] FROM[dbo].[KetQua]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int DeleteKetQua(string maSinhVien, string maMonHoc)
        {
            string query = "DELETE FROM [dbo].[KetQua] WHERE ";
            query += $"[MaSV] = N'{maSinhVien}' and [MaMH] = N'{maMonHoc}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int ModifyKetQua(string maSinhVien, string maMonHoc, string diemLan1, string diemLan2)
        {
            string query = "UPDATE [dbo].[KetQua] SET ";
            query += $"[DiemThiLan1] = N'{diemLan1}', [DiemThiLan2] = N'{diemLan2}' ";
            query += $"WHERE [MaSV] = N'{maSinhVien}' and [MaMH] = N'{maMonHoc}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
