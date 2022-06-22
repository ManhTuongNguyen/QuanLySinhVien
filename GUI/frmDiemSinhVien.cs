using BLL;
using DTO;
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
    public partial class frmDiemSinhVien : Form
    {
        string MaSinhVien;
        public frmDiemSinhVien(string maSinhVien)
        {
            InitializeComponent();
            MaSinhVien = maSinhVien;
        }

        private void frmDiemSinhVien_Load(object sender, EventArgs e)
        {
            var listDiem = Diem_SinhVienBLL.GetDiemByStudentCode(MaSinhVien);
            ListViewItem listViewItem;
            if (listDiem.Count == 0)
            {
                string message = "Có lỗi đã xảy ra!\n";
                message += "Bạn phải dùng tài khoản có " +
                    "tên đăng nhập trùng với mã sinh viên" +
                    " mới có thể xem được điểm tích lũy của mình!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            //Thêm danh sách điểm theo các môn vào list hiển thị
            foreach (Diem_SinhVien diem in listDiem)
            {
                listViewItem = new ListViewItem(diem.TenMonHoc);
                listViewItem.SubItems.Add(diem.DiemLanThuNhat);
                listViewItem.SubItems.Add(diem.DiemLanThuHai);
                lvDiem_SinhVien.Items.Add(listViewItem);
            }
        }
    }
}
