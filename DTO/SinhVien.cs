using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        private string maSV;
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string queQuan;
        private string danToc;
        private string maLop;
        private string tinhTrang;

        public SinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, string queQuan, string danToc, string maLop, string tinhTrang)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            QueQuan = queQuan;
            DanToc = danToc;
            MaLop = maLop;
            TinhTrang = tinhTrang;
        }

        public SinhVien()
        {

        }

        public string MaSV {
            get => maSV;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống mã sinh viên!");
                if (value.Contains(" "))
                    throw new Exception("Mã sinh viên không được có khoảng trống!");

                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]");
                if (regex.IsMatch(value))
                    throw new Exception("Mã sinh viên không được chứa ký tự đặc biệt!");

                maSV = value.ToUpper();
            }
        }
        public string HoTen { get => hoTen;
            set
            {
                if (value == null)
                    throw new Exception("Không được bỏ trống họ tên sinh viên!");

                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]");
                if (regex.IsMatch(value))
                    throw new Exception("Họ tên sinh viên không được chứa ký tự đặc biệt!");
                hoTen = value;
            }
        }
        public string NgaySinh { get => ngaySinh;
            set
            {
                if (!IsValidNamSinh(value))
                    throw new Exception("Năm sinh của sinh viên không hợp lệ!");
                ngaySinh = value;
            }
        }

        public string GioiTinh { get => gioiTinh;
            set
            {
                if (value.ToUpper() != "NAM" && value.ToUpper() != "NỮ")
                    throw new Exception("Giới tính không hợp lệ!");
                gioiTinh = value;
            }
        }

        public string QueQuan
        {
            get => queQuan;
            set
            {
                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?\\'""]");
                if (regex.IsMatch(value))
                    throw new Exception("Quê quán không được chứa ký tự đặc biệt!");
                queQuan = value;
            }
        }
        public string DanToc
        {
            get => danToc;
            set
            {
                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]");
                if (regex.IsMatch(value))
                    throw new Exception("Tên dân tộc không được chứa ký tự đặc biệt!");
                danToc = value;
            }
        }
        public string MaLop { get => maLop;
            set
            {
                if (value == null)
                    throw new Exception("Không được bỏ trống mã lớp!");
                maLop = value;
            }
        }

        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        private bool IsValidNamSinh(string ngaySinh)
        {
            string[] temp = ngaySinh.Split('/');
            bool result = int.TryParse(temp[2], out int NamSinh);
            if (!result)
                return false;
            //Sinh viên phải có độ tuổi lớn hơn 16
            if (NamSinh < 1940 || NamSinh > DateTime.Now.Year - 16)
                return false;
            return true;
        }
    }
}
