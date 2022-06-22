using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KetQua
    {
        private string maSinhVien;
        private string maMonHoc;
        private string diemLan1;
        private string diemLan2;

        public KetQua(string maSinhVien, string maMonHoc, string diemLan1, string diemLan2)
        {
            MaSinhVien = maSinhVien;
            MaMonHoc = maMonHoc;
            DiemLan1 = diemLan1;
            DiemLan2 = diemLan2;
        }

        public KetQua()
        {

        }

        public string MaSinhVien
        {
            get => maSinhVien;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống mã sinh viên!");
                maSinhVien = value;
            }
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
        public string DiemLan1
        {
            get => diemLan1;
            set
            {
                if (!IsValidDiem(value) || value == "")
                    throw new Exception("Điểm lần 1 không hợp lệ!");
                diemLan1 = value;
            }
        }
        public string DiemLan2
        {
            get => diemLan2;
            set
            {
                if (!IsValidDiem(value))
                    throw new Exception("Điểm lần 2 không hợp lệ!");
                diemLan2 = value;
            }
        }

        private bool IsValidDiem(string diem)
        {
            if (diem == "")
                return true;
            bool result = float.TryParse(diem, out float Diem);
            if (!result)
                return false;
            if (Diem < 0 || Diem > 10)
                return false;
            return true;
        }
    }
}
