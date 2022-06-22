using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class Class
    {
        private string maLop;
        private string tenLop;
        private string maKhoa;
        private string maKhoaHoc;
        private string maCT;

        public Class(string maLop, string tenLop, string maKhoa, string maKhoaHoc, string maCT)
        {
            MaLop = maLop;
            TenLop = tenLop;
            MaKhoa = maKhoa;
            MaKhoaHoc = maKhoaHoc;
            MaCT = maCT;
        }
        
        public Class()
        {

        }

        public string MaLop {
            get => maLop;
            set
            {
                if (value == "")
                    throw new Exception("không được bỏ trống mã lớp!");
                maLop = value;
            }
        }

        public string TenLop
        {
            get => tenLop;
            set
            {
                if (value == "")
                    throw new Exception("không được bỏ trống tên lớp!");

                Regex regex = new Regex(@"[!@#$%^&*()+=\[{\]};:<>|./?,\\'""]");
                if (regex.IsMatch(value))
                    throw new Exception("Tên lớp học không được chứa ký tự đặc biệt!");
                tenLop = value;
            }
        }
        public string MaKhoa {
            get => maKhoa;
            set
            {
                if (value == "")
                    throw new Exception("không được bỏ trống mã khoa!");
                maKhoa = value;
            }
        }
        public string MaKhoaHoc
        {
            get => maKhoaHoc;
            set
            {
                if (value == "")
                    throw new Exception("không được bỏ trống mã khóa học!");
                maKhoaHoc = value;
            }
        }
        public string MaCT
        {
            get => maCT;
            set
            {
                if (value == "")
                    throw new Exception("không được bỏ trống mã chương trình!");
                maCT = value;
            }
        }
    }
}
