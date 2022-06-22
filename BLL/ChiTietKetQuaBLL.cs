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
    public class ChiTietKetQuaBLL
    {
        public static List<ChiTietKetQua> GetAllKetQuaDetails()
        {
            SqlDataReader data = ChiTietKetQuaDAL.GetAllKetQuaDetail();
            List<ChiTietKetQua> listKetQua = new List<ChiTietKetQua>();
            while (data.Read())
            {
                ChiTietKetQua ketQua = new ChiTietKetQua
                {
                    HoTen = MD5Helper.Decrypt(data.GetString(0), 3),
                    TenLop = MD5Helper.Decrypt(data.GetString(1), 1),
                    TenMonHoc = DaBangHelper.Decrypt(data.GetString(2), 3),
                    Diem = DonBangHelper.Decrypt(data.GetString(3), 6)
                };
                listKetQua.Add(ketQua);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listKetQua;
        }
    }
}
