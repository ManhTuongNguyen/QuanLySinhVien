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
    public class ClassBLL
    {
        public static bool InsertClass(Class _class)
        {
            string maLop = DaBangHelper.Encrypt(_class.MaLop, 3);
            string tenLop = MD5Helper.Encrypt(_class.TenLop, 1);
            string maKhoa = DonBangHelper.Encrypt(_class.MaKhoa, 1);
            string maKhoaHoc = CeasarHelper.Encrypt(_class.MaKhoaHoc, 2);
            string maCT = DaBangHelper.Encrypt(_class.MaCT, 6);
            return ClassDAL.InsertClass(maLop, tenLop, maKhoa, maKhoaHoc, maCT) > 0;
        }

        public static Class GetClassByMaLop(string maLop)
        {
            SqlDataReader data = ClassDAL.GetClassByMaLop(DaBangHelper.Encrypt(maLop, 3));
            Class _class = new Class();
            while (data.Read())
            {
                _class.MaLop = DaBangHelper.Decrypt(data.GetString(0), 3);
                _class.TenLop = MD5Helper.Decrypt(data.GetString(1), 1);
                _class.MaKhoa = DonBangHelper.Decrypt(data.GetString(2), 1);
                _class.MaKhoaHoc = CeasarHelper.Decrypt(data.GetString(3), 2);
                _class.MaCT = DaBangHelper.Decrypt(data.GetString(4), 6);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return _class;
        }

        public static List<Class> GetClassByMaKhoa(string maKhoa)
        {
            List<Class> listClass = new List<Class>();
            SqlDataReader data = ClassDAL.GetClassByKhoa(DonBangHelper.Encrypt(maKhoa, 1));
            while (data.Read())
            {
                Class _class = new Class
                {
                    MaLop = DaBangHelper.Decrypt(data.GetString(0), 3),
                    TenLop = MD5Helper.Decrypt(data.GetString(1), 1),
                    MaKhoa = DonBangHelper.Decrypt(data.GetString(2), 1),
                    MaKhoaHoc = CeasarHelper.Decrypt(data.GetString(3), 2),
                    MaCT = DaBangHelper.Decrypt(data.GetString(4), 6)
                };
                listClass.Add(_class);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listClass;
        }

        public static List<Class> GetAllClass()
        {
            List<Class> listClass = new List<Class>();
            SqlDataReader data = ClassDAL.GetAllClass();
            while (data.Read())
            {
                Class _class = new Class
                {
                    MaLop = DaBangHelper.Decrypt(data.GetString(0), 3),
                    TenLop = MD5Helper.Decrypt(data.GetString(1), 1),
                    MaKhoa = DonBangHelper.Decrypt(data.GetString(2), 1),
                    MaKhoaHoc = CeasarHelper.Decrypt(data.GetString(3), 2),
                    MaCT = DaBangHelper.Decrypt(data.GetString(4), 6)
                };
                listClass.Add(_class);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listClass;
        }

        public static bool ModifyClass(Class _class)
        {
            string maLop = DaBangHelper.Encrypt(_class.MaLop, 3);
            string tenLop = MD5Helper.Encrypt(_class.TenLop, 1);
            string maKhoa = DonBangHelper.Encrypt(_class.MaKhoa, 1);
            string maKhoaHoc = CeasarHelper.Encrypt(_class.MaKhoaHoc, 2);
            string maCT = DaBangHelper.Encrypt(_class.MaCT, 6);

            return ClassDAL.ModifyClass(maLop, tenLop, maKhoa, maKhoaHoc, maCT) > 0;
        }

        public static bool DeleteClass(string maLop)
        {
            string MaLop = DaBangHelper.Encrypt(maLop, 3);

            return ClassDAL.DeleteClass(MaLop) > 0;
        }
    }
}
