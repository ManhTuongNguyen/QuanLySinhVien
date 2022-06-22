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
    public partial class frmQuanLyMonHoc : Form
    {
        public frmQuanLyMonHoc()
        {
            InitializeComponent();
            dgvMonHoc.AllowUserToResizeRows = false;
        }

        private void btnAddMonHoc_Click(object sender, EventArgs e)
        {
            if (cbbMaKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Không được bỏ trống khoa!", "Thông báo");
                return;
            }
            MonHoc monHoc;
            try
            {
                monHoc = new MonHoc();
                monHoc.MaMonHoc = txtMaMonHoc.Text;
                monHoc.MaKhoa = (cbbMaKhoa.SelectedItem as Khoa).MaKhoa;
                monHoc.TenMonHoc = txtTenMonHoc.Text;
                monHoc.SoTinChi = txtSoTinChi.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
            try
            {
                MonHocBLL.InsertMonHoc(monHoc);
                MessageBox.Show($"Đã thêm môn học {txtTenMonHoc.Text} thành công!", "Thông báo", MessageBoxButtons.OK);
                txtMaMonHoc.Clear();
                txtSoTinChi.Clear();
                txtTenMonHoc.Clear();
                LoadMonHoc();
            }
            catch
            {
                MessageBox.Show("Mã môn học đã tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaMonHoc_Click(object sender, EventArgs e)
        {
            MonHoc monHoc;
            try
            {
                monHoc = new MonHoc();
                monHoc.MaMonHoc = txtMaMonHoc.Text;
                monHoc.MaKhoa = (cbbMaKhoa.SelectedItem as Khoa).MaKhoa;
                monHoc.TenMonHoc = txtTenMonHoc.Text;
                monHoc.SoTinChi = txtSoTinChi.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
            if (!MonHocBLL.ModiFyMonHoc(monHoc))
            {
                MessageBox.Show("Mã môn học không tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Đã thay đổi thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadMonHoc();
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã môn học", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string message = "Xóa môn học sẽ xóa tất cả điểm của sinh viên đã học môn học này!\n";
            message += "Dữ liệu sẽ bị xóa vĩnh viễn và không thể khôi phục!\n";
            message += "Bạn có chắc chắn muốn xóa môn học này không?";
            var result = MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (MonHocBLL.DeleteMonHoc(txtMaMonHoc.Text))
                {
                    MessageBox.Show("Đã xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadMonHoc();
                    return;
                }
                MessageBox.Show("Mã môn học không tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void frmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();

            cbbMaKhoa.DataSource = KhoaBLL.GetAllKhoa();
            cbbMaKhoa.DisplayMember = "TenKhoa";
        }

        private void LoadMonHoc()
        {
            dgvMonHoc.DataSource = MonHocBLL.GetAllMonHoc();
            FormatDataGridView();
            dgvMonHoc.Columns[0].HeaderText = "Mã môn học";
            dgvMonHoc.Columns[1].HeaderText = "Mã khoa";
            dgvMonHoc.Columns[2].HeaderText = "Tên môn học";
            dgvMonHoc.Columns[3].HeaderText = "Số tín chỉ";
        }

        private void FormatDataGridView()
        {
            dgvMonHoc.Columns[0].Width = 75;
            dgvMonHoc.Columns[1].Width = 75;
            dgvMonHoc.Columns[2].Width = 150;
            dgvMonHoc.Columns[3].Width = 75;
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvMonHoc.Rows[e.RowIndex];

                txtMaMonHoc.Text = row.Cells[0].Value.ToString();
                List<Khoa> listKhoa = (List<Khoa>)cbbMaKhoa.DataSource;
                cbbMaKhoa.SelectedIndex = listKhoa.FindIndex(x => x.MaKhoa == row.Cells[1].Value.ToString());
                listKhoa = null;
                txtTenMonHoc.Text = row.Cells[2].Value.ToString();
                txtSoTinChi.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSearchMonHoc_Click(object sender, EventArgs e)
        {
            if (txtSearchMonHoc.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin mã khoa hoặc tên môn học để tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                var listMonHoc = MonHocBLL.GetAllMonHoc();
                dgvMonHoc.DataSource = listMonHoc.Where(x =>
                {
                    if (x.MaKhoa.ToUpper().Contains(txtSearchMonHoc.Text.ToUpper()))
                        return true;
                    if (x.TenMonHoc.ToUpper().Contains(txtSearchMonHoc.Text.ToUpper()))
                        return true;
                    return false;
                }).ToList();
            }
            catch
            {

            }
        }

        private void btnDefaultDataMonHoc_Click(object sender, EventArgs e)
        {
            LoadMonHoc();
        }

        private void pnContainDgv_SizeChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Created == false)
            {
                return;
            }

            if (dgvMonHoc.Size.Width > 375)
            {
                dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                FormatDataGridView();
            }
        }
    }
}
