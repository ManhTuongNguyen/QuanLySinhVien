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
    public class HoSoSinhVienBLL
    {
        public static string[] GetHoSoSinhVienByStudentCode(string maSinhVien)
        {
            string MaSinhVien = CeasarHelper.Encrypt(maSinhVien, 2);
            SqlDataReader data = HoSoSinhVienDAL.GetHoSoSinhVien(MaSinhVien);
            string[] hoSoSinhVien = new string[11];
            while (data.Read())
            {
                hoSoSinhVien[0] = CeasarHelper.Decrypt(data.GetString(0), 2);
                hoSoSinhVien[1] = MD5Helper.Decrypt(data.GetString(1), 3);
                hoSoSinhVien[2] = DaBangHelper.Decrypt(data.GetString(2), 4);
                hoSoSinhVien[3] = MD5Helper.Decrypt(data.GetString(3), 4);
                hoSoSinhVien[4] = CeasarHelper.Decrypt(data.GetString(4), 5);
                hoSoSinhVien[5] = MD5Helper.Decrypt(data.GetString(5), 6);
                hoSoSinhVien[6] = MD5Helper.Decrypt(data.GetString(6), 1);
                hoSoSinhVien[7] = DaBangHelper.Decrypt(data.GetString(7), 9);
                hoSoSinhVien[8] = MD5Helper.Decrypt(data.GetString(8), 2);
                hoSoSinhVien[9] = MD5Helper.Decrypt(data.GetString(9), 5);
                hoSoSinhVien[10] = DonBangHelper.Decrypt(data.GetString(10), 1);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return hoSoSinhVien;
        }
    }
}
