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
    public class KhoaHocBLL
    {
        public static bool InsertKhoaHoc(KhoaHoc khoaHoc)
        {
            string maKhoaHoc = CeasarHelper.Encrypt(khoaHoc.MaKhoaHoc, 2);
            string namBatDau = DonBangHelper.Encrypt(khoaHoc.NamBatDau, 3);
            string namKetThuc = DaBangHelper.Encrypt(khoaHoc.NamKetThuc, 1);
            return KhoaHocDAL.InsertKhoaHoc(maKhoaHoc, namBatDau, namKetThuc) > 0;
        }

        public static List<KhoaHoc> GetAllKhoaHoc()
        {
            List<KhoaHoc> listKhoaHoc = new List<KhoaHoc>();
            SqlDataReader data = KhoaHocDAL.GetAllKhoaHoc();
            while (data.Read())
            {
                KhoaHoc khoaHoc = new KhoaHoc();
                khoaHoc.MaKhoaHoc = CeasarHelper.Decrypt(data.GetString(0), 2);
                khoaHoc.NamBatDau = DonBangHelper.Decrypt(data.GetString(1), 3);
                khoaHoc.NamKetThuc = DaBangHelper.Decrypt(data.GetString(2), 1);
                listKhoaHoc.Add(khoaHoc);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listKhoaHoc;
        }

        public static bool DeleteKhoaHoc(string maKhoaHoc)
        {
            string MaKhoaHoc = CeasarHelper.Encrypt(maKhoaHoc, 2);
            return KhoaHocDAL.DeleteKhoaHoc(MaKhoaHoc) > 0;
        }

        public static bool ModifyKhoaHoc(KhoaHoc khoaHoc)
        {
            string maKhoaHoc = CeasarHelper.Encrypt(khoaHoc.MaKhoaHoc, 2);
            string namBatDau = DonBangHelper.Encrypt(khoaHoc.NamBatDau, 3);
            string namKetThuc = DaBangHelper.Encrypt(khoaHoc.NamKetThuc, 1);

            return KhoaHocDAL.ModifyKhoaHoc(maKhoaHoc, namBatDau, namKetThuc) > 0;
        }
    }
}
