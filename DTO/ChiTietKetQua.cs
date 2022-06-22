using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKetQua
    {
        private string hoTen;
        private string tenLop;
        private string tenMonHoc;
        private string diem;

        public ChiTietKetQua(string hoTen, string tenLop, string tenMonHoc, string diem)
        {
            HoTen = hoTen;
            TenLop = tenLop;
            TenMonHoc = tenMonHoc;
            Diem = diem;
        }

        public ChiTietKetQua()
        {

        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public string Diem { get => diem; set => diem = value; }
    }
}
