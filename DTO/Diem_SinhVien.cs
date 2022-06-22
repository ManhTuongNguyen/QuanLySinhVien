using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Diem_SinhVien
    {
        private string tenMonHoc;
        private string diemLanThuNhat;
        private string diemLanThuHai;

        public Diem_SinhVien()
        {
        }

        public Diem_SinhVien(string tenMonHoc, string diemLanThuNhat, string diemLanThuHai)
        {
            TenMonHoc = tenMonHoc;
            DiemLanThuNhat = diemLanThuNhat;
            DiemLanThuHai = diemLanThuHai;
        }

        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public string DiemLanThuNhat { get => diemLanThuNhat; set => diemLanThuNhat = value; }
        public string DiemLanThuHai { get => diemLanThuHai; set => diemLanThuHai = value; }
    }
}
