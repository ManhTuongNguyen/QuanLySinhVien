using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa
    {
        private string maKhoa;
        private string tenKhoa;
        private string namThanhLap;

        public Khoa(string maKhoa, string tenKhoa, string namThanhLap)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            NamThanhLap = namThanhLap;
        }

        public Khoa()
        {

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
        public string TenKhoa { get => tenKhoa;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống tên khoa!");
                Regex regex = new Regex(@"[!@#$%^*()_+=\[{\]};:<>|./?,\\'""]");
                if (regex.IsMatch(value))
                    throw new Exception("Tên khoa không được chứa ký tự đặc biệt!");
                tenKhoa = value;
            }
        }
        public string NamThanhLap
        {
            get => namThanhLap;
            set
            {
                if (!IsValidNamThanhLap(value))
                    throw new Exception("Năm thành lập không hợp lệ!");
                namThanhLap = value;
            }
        }


        private bool IsValidNamThanhLap(string namThanhLap)
        {
            string[] value = namThanhLap.Split('/');
            bool ketQua = int.TryParse(value[2], out int NamThanhLap);
            if (!ketQua)
                return false;
            if (NamThanhLap < 1900 || NamThanhLap > DateTime.Now.Year)
                return false;
            return true;
        }
    }
}
