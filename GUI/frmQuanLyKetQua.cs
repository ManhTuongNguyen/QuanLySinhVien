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
    public partial class frmQuanLyKetQua : Form
    {
        public frmQuanLyKetQua()
        {
            InitializeComponent();
            dgvKetQua.AllowUserToResizeRows = false;
        }

        private void btnAddKetQua_Click(object sender, EventArgs e)
        {
            if (cbbMaSinhVien_MH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên!");
                return;
            }
            if (cbbMaMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã môn học!");
                return;
            }
            KetQua ketQua;
            try
            {
                ketQua = new KetQua
                {
                    MaSinhVien = (cbbMaSinhVien_MH.SelectedItem as SinhVien).MaSV,
                    MaMonHoc = (cbbMaMonHoc.SelectedItem as MonHoc).MaMonHoc,
                    DiemLan1 = txtDiemThiLan1.Text,
                    DiemLan2 = txtDiemThiLan2.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                KetQuaBLL.InsertKetQua(ketQua);
                MessageBox.Show("Đã thêm kết quả thành công!", "Message", MessageBoxButtons.OK);
                LoadKetQua();
                txtDiemThiLan1.Clear();
                txtDiemThiLan2.Clear();
                LoadKetQua();
            }
            catch
            {
                string message = "Đã có kết quả của sinh viên với môn học này!\n";
                message += "Vui lòng kiểm tra lại!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void LoadKetQua()
        {
            dgvKetQua.DataSource = KetQuaBLL.GetAllKetQua();
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dgvKetQua.Columns[0].HeaderText = "Mã sinh viên";
            dgvKetQua.Columns[1].HeaderText = "Mã môn học";
            dgvKetQua.Columns[2].HeaderText = "Điểm lần 1";
            dgvKetQua.Columns[3].HeaderText = "Điểm lần 2";

            dgvKetQua.Columns[0].Width = 100;
            dgvKetQua.Columns[1].Width = 87;
            dgvKetQua.Columns[2].Width = 50;
            dgvKetQua.Columns[3].Width = 50;
        }

        private void frmQuanLyKetQua_Load(object sender, EventArgs e)
        {
            LoadKetQua();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbbMaSinhVien_MH.DataSource = SinhVienBLL.GetAllStudent();
            cbbMaSinhVien_MH.DisplayMember = "HoTen";

            cbbMaMonHoc.DataSource = MonHocBLL.GetAllMonHoc();
            cbbMaMonHoc.DisplayMember = "TenMonHoc";
        }

        private void btnModifyKetQua_Click(object sender, EventArgs e)
        {
            KetQua ketQua;
            try
            {
                ketQua = new KetQua
                {
                    MaSinhVien = (cbbMaSinhVien_MH.SelectedItem as SinhVien).MaSV,
                    MaMonHoc = (cbbMaMonHoc.SelectedItem as MonHoc).MaMonHoc,
                    DiemLan1 = txtDiemThiLan1.Text,
                    DiemLan2 = txtDiemThiLan2.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (!KetQuaBLL.ModifyKetQua(ketQua))
            {
                string message = $"Không có thông tin kết quả môn học {cbbMaMonHoc.SelectedItem}\n" +
                    $"của sinh viên {cbbMaSinhVien_MH.SelectedItem} trên hệ thống!\n";
                message += "Vui lòng kiểm tra lại thông tin!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Đã thay đổi thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadKetQua();
            }
        }

        private void btnDeleteKetQua_Click(object sender, EventArgs e)
        {
            string maSV = (cbbMaSinhVien_MH.SelectedItem as SinhVien).MaSV;
            string maMH = (cbbMaMonHoc.SelectedItem as MonHoc).MaMonHoc;
            if (!KetQuaBLL.DeleteKetQua(maSV, maMH))
            {
                string message = $"Không có thông tin kết quả môn học {cbbMaMonHoc.SelectedItem}\n" +
                    $"của sinh viên {cbbMaSinhVien_MH.SelectedItem} trên hệ thống!\n";
                message += "Vui lòng kiểm tra lại thông tin!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Đã xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadKetQua();
            }
        }

        private void btnSearchKetQua_Click(object sender, EventArgs e)
        {
            if (txtSearchKetQua.Text == "")
            {
                MessageBox.Show("Phải điền mã môn học hoặc mã sinh viên để tìm kiếm!", "Thông báo");
                return;
            }
            var listKetQua = KetQuaBLL.GetAllKetQua();
            var listKetQuaFilter = listKetQua.Where(x =>
            {
                //Search kết quả theo mã sinh viên hoặc mã môn học
                if (x.MaMonHoc.ToUpper().Contains(txtSearchKetQua.Text.ToUpper()))
                    return true;
                if (x.MaSinhVien.ToUpper().Contains(txtSearchKetQua.Text.ToUpper()))
                    return true;
                return false;
            }).ToList();
            dgvKetQua.DataSource = listKetQuaFilter;
            listKetQuaFilter = null;
            listKetQua = null;
        }

        private void btnDefaultDataKetQua_Click(object sender, EventArgs e)
        {
            LoadKetQua();
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvKetQua.Rows[e.RowIndex];
                var listStudent = (List<SinhVien>)cbbMaSinhVien_MH.DataSource;
                cbbMaSinhVien_MH.SelectedIndex = listStudent.FindIndex(x => x.MaSV == row.Cells[0].Value.ToString());
                listStudent = null;
                var listMonHoc = (List<MonHoc>)cbbMaMonHoc.DataSource;
                cbbMaMonHoc.SelectedIndex = listMonHoc.FindIndex(x => x.MaMonHoc == row.Cells[1].Value.ToString());
                listMonHoc = null;
                txtDiemThiLan1.Text = row.Cells[2].Value.ToString();
                txtDiemThiLan2.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void pnContainerDgv_SizeChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Created == false)
            {
                return;
            }

            if (pnContainerDgv.Size.Width > 300)
            {
                dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                FormatDataGridView();
            }
        }
    }
}
