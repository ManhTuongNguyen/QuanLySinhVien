using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        private string maMonHoc;
        private string maKhoa;
        private string tenMonHoc;
        private string soTinChi;

        public MonHoc(string maMonHoc, string maKhoa, string tenMonHoc, string soTinChi)
        {
            MaMonHoc = maMonHoc;
            MaKhoa = maKhoa;
            TenMonHoc = tenMonHoc;
            SoTinChi = soTinChi;
        }

        public MonHoc()
        {

        }

        public string MaMonHoc
        {
            get => maMonHoc;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống mã môn học!");
                maMonHoc = value;
            }
        }
        public string MaKhoa
        {
            get => maKhoa;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống mã khoa!");
                maKhoa = value;
            }
        }
        public string TenMonHoc
        {
            get => tenMonHoc;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống tên môn học!");

                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]");
                if (regex.IsMatch(value))
                    throw new Exception("Tên môn học không được chứa ký tự đặc biệt!");
                tenMonHoc = value;
            }
        }
        public string SoTinChi
        {
            get => soTinChi;
            set
            {
                if (!IsValidSoTinChi(value))
                    throw new Exception("Số tín chỉ của môn học không hợp lệ!");
                soTinChi = value;
            }
        }

        private bool IsValidSoTinChi(string soTinChi)
        {
            bool result = int.TryParse(soTinChi, out int _soTinChi);
            if (!result)
                return false;
            if (_soTinChi < 1 || _soTinChi > 5)
                return false;
            return true;
        }
    }
}
