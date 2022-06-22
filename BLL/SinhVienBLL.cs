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
    public class SinhVienBLL
    {
        public static bool InsertStudent(SinhVien sinhVien)
        {
            string maSV = CeasarHelper.Encrypt(sinhVien.MaSV, 2);
            string hoTen = MD5Helper.Encrypt(sinhVien.HoTen, 3);
            string ngaySinh = DaBangHelper.Encrypt(sinhVien.NgaySinh, 4);
            string gioiTinh = MD5Helper.Encrypt(sinhVien.GioiTinh, 4);
            string queQuan = CeasarHelper.Encrypt(sinhVien.QueQuan, 5);
            string danToc = MD5Helper.Encrypt(sinhVien.DanToc, 6);
            string maLop = DaBangHelper.Encrypt(sinhVien.MaLop, 3);
            string tinhTrang = DonBangHelper.Encrypt(sinhVien.TinhTrang, 9);
            return SinhVienDAL.InsertSinhVien(maSV, hoTen, ngaySinh, gioiTinh, queQuan, danToc, maLop, tinhTrang) > 0;
        }

        public static SinhVien GetStudentByStudentCode(string maSV)
        {
            SqlDataReader data = SinhVienDAL.GetSinhVienByMaSV(CeasarHelper.Encrypt(maSV, 2));
            SinhVien sinhVien = new SinhVien();
            while (data.Read())
            {
                sinhVien.MaSV = CeasarHelper.Decrypt(data.GetString(0), 2);
                sinhVien.HoTen = MD5Helper.Decrypt(data.GetString(1), 3);
                sinhVien.NgaySinh = DaBangHelper.Decrypt(data.GetString(2), 4);
                sinhVien.GioiTinh = MD5Helper.Decrypt(data.GetString(3), 4);
                sinhVien.QueQuan = CeasarHelper.Decrypt(data.GetString(4), 5);
                sinhVien.DanToc = MD5Helper.Decrypt(data.GetString(5), 6);
                sinhVien.MaLop = DaBangHelper.Decrypt(data.GetString(6), 3);
                sinhVien.TinhTrang = DonBangHelper.Decrypt(data.GetString(7), 9);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return sinhVien;
        }

        public static List<SinhVien> GetAllStudent()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            SqlDataReader data = SinhVienDAL.GetAllSinhVien();
            while (data.Read())
            {
                SinhVien sinhVien = new SinhVien
                {
                    MaSV = CeasarHelper.Decrypt(data.GetString(0), 2),
                    HoTen = MD5Helper.Decrypt(data.GetString(1), 3),
                    NgaySinh = DaBangHelper.Decrypt(data.GetString(2), 4),
                    GioiTinh = MD5Helper.Decrypt(data.GetString(3), 4),
                    QueQuan = CeasarHelper.Decrypt(data.GetString(4), 5),
                    DanToc = MD5Helper.Decrypt(data.GetString(5), 6),
                    MaLop = DaBangHelper.Decrypt(data.GetString(6), 3),
                    TinhTrang = DonBangHelper.Decrypt(data.GetString(7), 9)
                };
                listSinhVien.Add(sinhVien);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listSinhVien;
        }

        public static bool DeleteStudentByStudentCode(string maSinhVien)
        {
            string MSV = CeasarHelper.Encrypt(maSinhVien, 2);
            return SinhVienDAL.DeleteSinhVien(MSV) > 0;
        }

        public static bool ModifyStudent(SinhVien sinhVien)
        {
            string maSV = CeasarHelper.Encrypt(sinhVien.MaSV, 2);
            string hoTen = MD5Helper.Encrypt(sinhVien.HoTen, 3);
            string ngaySinh = DaBangHelper.Encrypt(sinhVien.NgaySinh, 4);
            string gioiTinh = MD5Helper.Encrypt(sinhVien.GioiTinh, 4);
            string queQuan = CeasarHelper.Encrypt(sinhVien.QueQuan, 5);
            string danToc = MD5Helper.Encrypt(sinhVien.DanToc, 6);
            string maLop = DaBangHelper.Encrypt(sinhVien.MaLop, 3);
            string tinhTrang = DonBangHelper.Encrypt(sinhVien.TinhTrang, 9);

            return SinhVienDAL.ModifySinhVien(maSV, hoTen, ngaySinh, gioiTinh, queQuan, danToc, maLop, tinhTrang) > 0;
        }

        public static List<SinhVien> GetAllStudentByClassCode(string maLop)
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            SqlDataReader data = SinhVienDAL.GetAllStudentByClassCode(DaBangHelper.Encrypt(maLop, 3));
            while (data.Read())
            {
                SinhVien sinhVien = new SinhVien
                {
                    MaSV = CeasarHelper.Decrypt(data.GetString(0), 2),
                    HoTen = MD5Helper.Decrypt(data.GetString(1), 3),
                    NgaySinh = DaBangHelper.Decrypt(data.GetString(2), 4),
                    GioiTinh = MD5Helper.Decrypt(data.GetString(3), 4),
                    QueQuan = CeasarHelper.Decrypt(data.GetString(4), 5),
                    DanToc = MD5Helper.Decrypt(data.GetString(5), 6),
                    MaLop = DaBangHelper.Decrypt(data.GetString(6), 3),
                    TinhTrang = DonBangHelper.Decrypt(data.GetString(7), 9)
                };
                listSinhVien.Add(sinhVien);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listSinhVien;
        }

        public static List<SinhVien> GetAllStudentByStatus(string tinhTrang)
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            SqlDataReader data = SinhVienDAL.GetAllStudentByStatus(DonBangHelper.Encrypt(tinhTrang, 9));
            while (data.Read())
            {
                SinhVien sinhVien = new SinhVien
                {
                    MaSV = CeasarHelper.Decrypt(data.GetString(0), 2),
                    HoTen = MD5Helper.Decrypt(data.GetString(1), 3),
                    NgaySinh = DaBangHelper.Decrypt(data.GetString(2), 4),
                    GioiTinh = MD5Helper.Decrypt(data.GetString(3), 4),
                    QueQuan = CeasarHelper.Decrypt(data.GetString(4), 5),
                    DanToc = MD5Helper.Decrypt(data.GetString(5), 6),
                    MaLop = DaBangHelper.Decrypt(data.GetString(6), 3),
                    TinhTrang = DonBangHelper.Decrypt(data.GetString(7), 9)
                };
                listSinhVien.Add(sinhVien);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listSinhVien;
        }
    }
}
