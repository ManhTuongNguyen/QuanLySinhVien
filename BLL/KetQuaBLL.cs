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
    public class KetQuaBLL
    {
        public static bool InsertKetQua(KetQua ketQua)
        {
            string maSinhVien = CeasarHelper.Encrypt(ketQua.MaSinhVien, 2);
            string maMonHoc = DaBangHelper.Encrypt(ketQua.MaMonHoc, 9);
            string diemLan1 = DonBangHelper.Encrypt(ketQua.DiemLan1, 6);
            string diemLan2 = DonBangHelper.Encrypt(ketQua.DiemLan2, 6);
            return KetQuaDAL.InsertKetQua(maSinhVien, maMonHoc, diemLan1, diemLan2) > 0;
        }

        public static List<KetQua> GetAllKetQua()
        {
            List<KetQua> listKetQua = new List<KetQua>();
            SqlDataReader data = KetQuaDAL.GetKetQuaByMaSV();
            while (data.Read())
            {
                KetQua ketQua = new KetQua
                {
                    MaSinhVien = CeasarHelper.Decrypt(data.GetString(0), 2),
                    MaMonHoc = DaBangHelper.Decrypt(data.GetString(1), 9),
                    DiemLan1 = DonBangHelper.Decrypt(data.GetString(2), 6),
                    DiemLan2 = DonBangHelper.Decrypt(data.GetString(3), 6)
                };
                listKetQua.Add(ketQua);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listKetQua;
        }

        public static bool DeleteKetQua(string maSinhVien, string maMonHoc)
        {
            string MaSinhVien = CeasarHelper.Encrypt(maSinhVien, 2);
            string MaMonHoc = DaBangHelper.Encrypt(maMonHoc, 9);
            return KetQuaDAL.DeleteKetQua(maSinhVien, maMonHoc) > 0;
        }

        public static bool ModifyKetQua(KetQua ketQua)
        {
            string maSinhVien = CeasarHelper.Encrypt(ketQua.MaSinhVien, 2);
            string maMonHoc = DaBangHelper.Encrypt(ketQua.MaMonHoc, 9);
            string diemLan1 = DonBangHelper.Encrypt(ketQua.DiemLan1, 6);
            string diemLan2 = DonBangHelper.Encrypt(ketQua.DiemLan2, 6);

            return KetQuaDAL.ModifyKetQua(maSinhVien, maMonHoc, diemLan1, diemLan2) > 0;
        }
    }
}
