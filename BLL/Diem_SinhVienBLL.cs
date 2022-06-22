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
    public class Diem_SinhVienBLL
    {
        public static List<Diem_SinhVien> GetDiemByStudentCode(string maSinhVien)
        {
            string MaSinhVien = CeasarHelper.Encrypt(maSinhVien, 2);
            SqlDataReader data = Diem_SinhVienDAL.GetDiemByStudentCode(MaSinhVien);
            List<Diem_SinhVien> listDiem = new List<Diem_SinhVien>();
            while (data.Read())
            {
                Diem_SinhVien diem = new Diem_SinhVien()
                {
                    TenMonHoc = DaBangHelper.Decrypt(data.GetString(0), 3),
                    DiemLanThuNhat = DonBangHelper.Decrypt(data.GetString(1), 6),
                    DiemLanThuHai = DonBangHelper.Decrypt(data.GetString(2), 6),
                };
                listDiem.Add(diem);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listDiem;
        }
    }
}
