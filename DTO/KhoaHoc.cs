using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaHoc
    {
        private string maKhoaHoc;
        private string namBatDau;
        private string namKetThuc;
        int thoiGianHoanThanhKhoaHoc = 4;
        public KhoaHoc(string maKhoaHoc, string namBatDau, string namKetThuc)
        {
            MaKhoaHoc = maKhoaHoc;
            NamBatDau = namBatDau;
            NamKetThuc = namKetThuc;
            if (int.Parse(NamKetThuc) - int.Parse(NamBatDau) != thoiGianHoanThanhKhoaHoc)
            {
                throw new Exception("Thời gian học của khóa học là không hợp lý!");
            }
        }

        public KhoaHoc()
        {

        }

        public string MaKhoaHoc
        {
            get => maKhoaHoc;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống mã khóa học!");
                maKhoaHoc = value; 
            }
        }

        public string NamBatDau
        {
            get => namBatDau;
            set
            {
                if (!IsValidNamBatDau(value))
                    throw new Exception("Thời gian bắt đầu khóa học không hợp lệ!");
                namBatDau = value;
            }
        }
        public string NamKetThuc
        {
            get => namKetThuc;
            set {
                if (!IsValidNamKetThuc(value))
                    throw new Exception("Thời gian kết thúc khóa học không hợp lệ!");
                namKetThuc = value;
            }
        }

        private bool IsValidNamKetThuc(string value)
        {
            bool result = int.TryParse(value, out int _NamKetThuc);
            if (!result)
                return false;
            if (_NamKetThuc < 1960 || _NamKetThuc > DateTime.Now.Year + 6)
                return false;
            return true;
        }

        private bool IsValidNamBatDau(string value)
        {
            bool result = int.TryParse(value, out int _NamBatDau);
            if (!result)
                return false;
            if (_NamBatDau < 1960 || _NamBatDau > DateTime.Now.Year + 2)
                return false;
            return true;
        }
    }
}
