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
    public class MonHocBLL
    {
        public static bool InsertMonHoc(MonHoc monHoc)
        {
            string maMonHoc = DaBangHelper.Encrypt(monHoc.MaMonHoc, 9);
            string maKhoa = DonBangHelper.Encrypt(monHoc.MaKhoa, 1);
            string tenMonHoc = DaBangHelper.Encrypt(monHoc.TenMonHoc, 3);
            string soTinChi = CeasarHelper.Encrypt(monHoc.SoTinChi, 8);
            return MonHocDAL.InsertMonHoc(maMonHoc, maKhoa, tenMonHoc, soTinChi) > 0;
        }

        public static List<MonHoc> GetAllMonHoc()
        {
            List<MonHoc> listMonHoc = new List<MonHoc>();
            SqlDataReader data = MonHocDAL.GetAllMonHoc();
            while (data.Read())
            {
                MonHoc monHoc = new MonHoc
                {
                    MaMonHoc = DaBangHelper.Decrypt(data.GetString(0), 9),
                    MaKhoa = DonBangHelper.Decrypt(data.GetString(1), 1),
                    TenMonHoc = DaBangHelper.Decrypt(data.GetString(2), 3),
                    SoTinChi = CeasarHelper.Decrypt(data.GetString(3), 8)
                };
                listMonHoc.Add(monHoc);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listMonHoc;
        }

        public static bool DeleteMonHoc (string maMonHoc)
        {
            string MaMonHoc = DaBangHelper.Encrypt(maMonHoc, 9);
            return MonHocDAL.DeleteMonHoc(MaMonHoc) > 0;
        }

        public static bool ModiFyMonHoc(MonHoc monHoc)
        {
            string maMonHoc = DaBangHelper.Encrypt(monHoc.MaMonHoc, 9);
            string maKhoa = DonBangHelper.Encrypt(monHoc.MaKhoa, 1);
            string tenMonHoc = DaBangHelper.Encrypt(monHoc.TenMonHoc, 3);
            string soTinChi = CeasarHelper.Encrypt(monHoc.SoTinChi, 8);

            return MonHocDAL.ModifyClass(maMonHoc, maKhoa, tenMonHoc, soTinChi) > 0;
        }
    }
}
