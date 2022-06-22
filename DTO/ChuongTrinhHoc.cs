using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuongTrinhHoc
    {
        private string maChuongTrinhHoc;
        private string tenChuongTrinhHoc;

        public ChuongTrinhHoc(string maChuongTrinhHoc, string tenChuongTrinhHoc)
        {
            MaChuongTrinhHoc = maChuongTrinhHoc;
            TenChuongTrinhHoc = tenChuongTrinhHoc;
        }

        public ChuongTrinhHoc()
        {

        }
        public string MaChuongTrinhHoc
        {
            get => maChuongTrinhHoc;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống mã chương trình học!");
                maChuongTrinhHoc = value;
            }
        }
        public string TenChuongTrinhHoc
        {
            get => tenChuongTrinhHoc;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống tên chương trình học!");

                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]");
                if (regex.IsMatch(value))
                    throw new Exception("Tên chương trình học không được chứa ký tự đặc biệt!");
                tenChuongTrinhHoc = value;
            }
        }
    }
}
