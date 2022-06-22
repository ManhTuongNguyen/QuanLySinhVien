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
    public class ChuongTrinhHocBLL
    {
        public static bool InsertChuongTrinhHoc(ChuongTrinhHoc chuongTrinhHoc)
        {
            string maCT = DaBangHelper.Encrypt(chuongTrinhHoc.MaChuongTrinhHoc, 6);
            string tenCT = MD5Helper.Encrypt(chuongTrinhHoc.TenChuongTrinhHoc, 1);
            return ChuongTrinhHocDAL.InsertChuongTrinhHoc(maCT, tenCT) > 0;
        }

        public static List<ChuongTrinhHoc> GetAllChuongTrinhHoc()
        {
            List<ChuongTrinhHoc> listChuongTrinhHoc = new List<ChuongTrinhHoc>();
            SqlDataReader data = ChuongTrinhHocDAL.GetAllChuongTrinhHoc();
            while (data.Read())
            {
                ChuongTrinhHoc chuongTrinhHoc = new ChuongTrinhHoc();
                chuongTrinhHoc.MaChuongTrinhHoc = DaBangHelper.Decrypt(data.GetString(0), 6);
                chuongTrinhHoc.TenChuongTrinhHoc = MD5Helper.Decrypt(data.GetString(1), 1);
                listChuongTrinhHoc.Add(chuongTrinhHoc);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listChuongTrinhHoc;
        }

        public static bool DeleteChuongTrinhHoc(string maChuongTrinhHoc)
        {
            string MaChuongTrinhHoc = DaBangHelper.Encrypt(maChuongTrinhHoc, 6);
            return ChuongTrinhHocDAL.DeleteChuongTrinhHoc(MaChuongTrinhHoc) > 0;
        }

        public static bool ModifyChuongTrinhHoc(ChuongTrinhHoc chuongTrinhHoc)
        {
            string maCT = DaBangHelper.Encrypt(chuongTrinhHoc.MaChuongTrinhHoc, 6);
            string tenCT = MD5Helper.Encrypt(chuongTrinhHoc.TenChuongTrinhHoc, 1);
            return ChuongTrinhHocDAL.ModifyChuongTrinhHoc(maCT, tenCT) > 0;
        }
    }
}
