using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoaBLL
    {
        public static bool InsertKhoa(Khoa khoa)
        {
            string maKhoa = DonBangHelper.Encrypt(khoa.MaKhoa, 1);
            string tenKhoa = RSAHelper.Encrypt(khoa.TenKhoa, 1);
            string namThanhLap = DaBangHelper.Encrypt(khoa.NamThanhLap, 7);
            return KhoaDAL.InsertKhoa(maKhoa, tenKhoa, namThanhLap) > 0;
        }

        public static List<Khoa> GetAllKhoa()
        {
            List<Khoa> listKhoa = new List<Khoa>();
            SqlDataReader data = KhoaDAL.GetAllKhoa();
            while (data.Read())
            {
                Khoa khoa = new Khoa();
                khoa.MaKhoa = DonBangHelper.Decrypt(data.GetString(0), 1);
                khoa.TenKhoa = RSAHelper.Decrypt(data.GetString(1), 1);
                khoa.NamThanhLap = DaBangHelper.Decrypt(data.GetString(2), 7);
                listKhoa.Add(khoa);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listKhoa;
        }

        public static bool DeleteKhoa(string maKhoa)
        {
            string MaKhoa = DonBangHelper.Encrypt(maKhoa, 1);
            return KhoaDAL.DeleteKhoa(MaKhoa) > 0;
        }

        public static bool ModifyKhoa(Khoa khoa)
        {
            string maKhoa = DonBangHelper.Encrypt(khoa.MaKhoa, 1);
            string tenKhoa = RSAHelper.Encrypt(khoa.TenKhoa, 1);
            string namThanhLap = DaBangHelper.Encrypt(khoa.NamThanhLap, 7);
            return KhoaDAL.ModifyKhoa(maKhoa, tenKhoa, namThanhLap) > 0;
        }
    }
}
