using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHoSoSinhVien : Form
    {
        private string maSinhVien;
        public frmHoSoSinhVien(string MSV)
        {
            InitializeComponent();
            maSinhVien = MSV;
        }

        private void frmHoSoSinhVien_Load(object sender, EventArgs e)
        {
            string[] hoSoSV = HoSoSinhVienBLL.GetHoSoSinhVienByStudentCode(maSinhVien);
            if (hoSoSV[0] == null)
            {
                string message = "Có lỗi đã xảy ra!\n";
                message += "Bạn phải dùng tài khoản có " +
                    "tên đăng nhập trùng với mã sinh viên" +
                    " mới có thể xem được thông tin cá nhân của mình!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }

            LoadData(hoSoSV);
            hoSoSV = null;
        }

        private void LoadData(string[] hoSo)
        {
            txtMaSV.Text = hoSo[0];
            txtHoTen.Text = hoSo[1];
            txtBirthDay.Text = hoSo[2];
            txtGioiTinh.Text = hoSo[3];
            txtQueQuan.Text = hoSo[4];
            txtDanToc.Text = hoSo[5];
            txtTenLop.Text = hoSo[6];
            txtSDTCaNhan.Text = hoSo[7];
            txtEmailCaNhan.Text = hoSo[8];
            txtTenNguoiThan.Text = hoSo[9];
            txtSDTNguoiThan.Text = hoSo[10];
        }
    }
}
