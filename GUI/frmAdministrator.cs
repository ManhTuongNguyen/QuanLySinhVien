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
    public partial class frmAdministrator : Form
    {
        Account account;
        public frmAdministrator(Account acc)
        {
            InitializeComponent();
            account = acc;
        }


        private enum quanLy
        {
            Khoa = 0,
            KhoaHoc = 1,
            ChuongTrinhHoc = 2,
            LopHoc = 3,
            TaiKhoan = 4
        }

        #region Methods

        private void LoadKhoa()
        {
            List<Khoa> listKhoa = KhoaBLL.GetAllKhoa();
            dgvKhoa.DataSource = listKhoa;
            dgvKhoa.Columns[0].HeaderText = "Mã khoa";
            dgvKhoa.Columns[1].HeaderText = "Tên khoa";
            dgvKhoa.Columns[2].HeaderText = "Năm thành lập";
            dgvKhoa.Columns[0].Width = 110;
            dgvKhoa.Columns[1].Width = 184;
            dgvKhoa.Columns[2].Width = 103;

            listKhoa = null;
        }

        private void LoadKhoaHoc()
        {
            dgvKhoaHoc.DataSource = KhoaHocBLL.GetAllKhoaHoc();

            dgvKhoaHoc.Columns[0].HeaderText = "Mã khóa học";
            dgvKhoaHoc.Columns[1].HeaderText = "Năm bắt đầu";
            dgvKhoaHoc.Columns[2].HeaderText = "Năm kết thúc";
            //dgvKhoaHoc.Columns[0].Width = 133;
            //dgvKhoaHoc.Columns[1].Width = 133;
            //dgvKhoaHoc.Columns[2].Width = 132;
            dgvKhoaHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadChuongTrinhHoc()
        {
            var listChuongTrinhHoc = ChuongTrinhHocBLL.GetAllChuongTrinhHoc();
            dgvChuongTrinhHoc.DataSource = listChuongTrinhHoc;
            dgvChuongTrinhHoc.Columns[0].HeaderText = "Mã chương trình học";
            dgvChuongTrinhHoc.Columns[1].HeaderText = "Tên chương trình học";
            //dgvChuongTrinhHoc.Columns[0].Width = 150;
            //dgvChuongTrinhHoc.Columns[1].Width = 265;
            dgvChuongTrinhHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            listChuongTrinhHoc = null;
        }

        private void LoadClass()
        {
            //Load data gridview
            var listClass = ClassBLL.GetAllClass();
            dgvClass.DataSource = listClass;
            dgvClass.Columns[0].HeaderText = "Mã lớp";
            dgvClass.Columns[1].HeaderText = "Tên lớp";
            dgvClass.Columns[2].HeaderText = "Mã khoa";
            dgvClass.Columns[3].HeaderText = "Mã khóa học";
            dgvClass.Columns[4].HeaderText = "Mã chương trình";


            dgvClass.Columns[0].Width = 67;
            dgvClass.Columns[1].Width = 122;
            dgvClass.Columns[2].Width = 65;
            dgvClass.Columns[3].Width = 71;
            dgvClass.Columns[4].Width = 71;

            listClass = null;

            //Load combobox
            cbMaKhoa_Class.DataSource = KhoaBLL.GetAllKhoa();
            cbMaKhoa_Class.DisplayMember = "TenKhoa";

            cbMaChuongTrinh_Class.DataSource = ChuongTrinhHocBLL.GetAllChuongTrinhHoc();
            cbMaChuongTrinh_Class.DisplayMember = "TenChuongTrinhHoc";

            cbMaKhoaHoc_Class.DataSource = KhoaHocBLL.GetAllKhoaHoc();
            cbMaKhoaHoc_Class.DisplayMember = "NamBatDau";
        }

        private void LoadAccount()
        {
            var listAccount = AccountBLL.GetAllAccount();
            dgvAccount.DataSource = listAccount;
            dgvAccount.Columns[0].HeaderText = "Tên tài khoản";
            dgvAccount.Columns[1].HeaderText = "Mật khẩu";
            dgvAccount.Columns[2].HeaderText = "Tên hiển thị";
            dgvAccount.Columns[3].HeaderText = "Email";
            dgvAccount.Columns[4].HeaderText = "Loại tài khoản";

            dgvAccount.Columns[0].Width = 100;
            dgvAccount.Columns[1].Width = 100;
            dgvAccount.Columns[2].Width = 100;
            dgvAccount.Columns[3].Width = 130;
            dgvAccount.Columns[4].Width = 100;

            cbAccountType.Items.Add("Sinh viên");
            cbAccountType.Items.Add("Giáo viên");
            cbAccountType.Items.Add("Administrator");
            cbAccountType.SelectedIndex = 0;
            listAccount = null;
            
        }
        #endregion

        #region Events
        private void frmAdministrator_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            dgvKhoa.RowHeadersVisible = false;
            LoadKhoa();
            LoadKhoaHoc();
            LoadChuongTrinhHoc();
            LoadAccount();
            dgvKhoa.AllowUserToResizeRows = false;
            dgvChuongTrinhHoc.AllowUserToResizeRows = false;
            dgvKhoaHoc.AllowUserToResizeRows = false;
            dgvClass.AllowUserToResizeRows = false;
            dgvAccount.AllowUserToResizeRows = false;
        }

        #region events_Khoa

        private void btnAddKhoa_Click(object sender, EventArgs e)
        {
            Khoa khoa = null;
            try
            {
                khoa = new Khoa
                {
                    MaKhoa = txtMaKhoa.Text,
                    TenKhoa = txtTenKhoa.Text,
                    NamThanhLap = dtpKhoa.Value.ToShortDateString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                KhoaBLL.InsertKhoa(khoa);
                MessageBox.Show("Đã thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadKhoa();
            }
            catch
            {
                MessageBox.Show("Mã khoa đã tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteKhoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã khoa!");
                return;
            }

            string message = "Dữ liệu sẽ bị xóa vĩnh viễn và không thể khôi phục!\n" +
                "Bạn có chắc chắn muốn xóa không?";
            var result = MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!KhoaBLL.DeleteKhoa(txtMaKhoa.Text))
                {
                    MessageBox.Show("Mã khoa không tồn tại!\nVui lòng kiểm tra lại");
                    return;
                }
                MessageBox.Show("Đã xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadKhoa();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show($"Không thể xóa khoa đang chứa thông " +
                    $"tin của môn học hoặc lớp học\nVui lòng kiểm" +
                    $" tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnModifyKhoa_Click(object sender, EventArgs e)
        {
            Khoa khoa = null;
            try
            {
                khoa = new Khoa
                {
                    MaKhoa = txtMaKhoa.Text,
                    TenKhoa = txtTenKhoa.Text,
                    NamThanhLap = dtpKhoa.Value.ToShortDateString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (KhoaBLL.ModifyKhoa(khoa))
            {
                MessageBox.Show("Đã chỉnh sửa khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadKhoa();
            }
            else
            {
                MessageBox.Show("Mã khoa không tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDefaultDataKhoa_Click(object sender, EventArgs e)
        {
            LoadKhoa();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells[0].Value.ToString();
                txtTenKhoa.Text = row.Cells[1].Value.ToString();
                dtpKhoa.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnSearchKhoa_Click(object sender, EventArgs e)
        {
            if (txtSearchKhoa.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu tên" +
                    " khoa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }
            var listKhoa = KhoaBLL.GetAllKhoa();
            //var listFilterWithName = listKhoa.Where(x => x.TenKhoa.ToUpper().Contains(txtSearchKhoa.Text.ToUpper())).ToList();
            var listFilterWithName = listKhoa.Where(x =>
            {
                string nameRemovedSign = ApplicationHelper.RemoveSignForVietnameseString(x.TenKhoa.ToUpper());
                string searchKhoa = ApplicationHelper.RemoveSignForVietnameseString(txtSearchKhoa.Text.ToUpper());
                if (nameRemovedSign.Contains(searchKhoa))
                {
                    return true;
                }
                return false;
            }).ToList();
            dgvKhoa.DataSource = listFilterWithName;
        }
        private void pnContainDgvKhoa_SizeChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Created == false)
            {
                return;
            }
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion


        #region Events_KhoaHoc
        private void btnAddKhoaHoc_Click(object sender, EventArgs e)
        {
            KhoaHoc khoaHoc = null;
            try
            {
                khoaHoc = new KhoaHoc(txtMaKhoaHoc.Text, txtNamBatDauKhoaHoc.Text, txtNamKetThucKhoaHoc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                KhoaHocBLL.InsertKhoaHoc(khoaHoc);
                MessageBox.Show("Đã thêm khóa học thành công!", "Thành công", MessageBoxButtons.OK);
                LoadKhoaHoc();
            }
            catch
            {
                MessageBox.Show("Mã khóa học đã tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteKhoaHoc_Click(object sender, EventArgs e)
        {
            if (txtMaKhoaHoc.Text == "")
            {
                MessageBox.Show("Không được để trống mã khóa học!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string message = "Dữ liệu sẽ bị xóa vĩnh viễn và không thể khôi phục!\n" +
                "Bạn có chắc chắn muốn xóa không?";
            var result = MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!KhoaHocBLL.DeleteKhoaHoc(txtMaKhoaHoc.Text))
                {
                    MessageBox.Show("Mã khóa học không tồn tại!\nVui lòng kiểm tra lại");
                    return;
                }
                MessageBox.Show("Đã xóa khóa học thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadKhoaHoc();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show($"Không thể xóa khóa học " +
                    $"đang chứa thông tin của lớp học\nV" +
                    $"ui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnMidifyKhoaHoc_Click(object sender, EventArgs e)
        {
            KhoaHoc khoaHoc = null;
            try
            {
                khoaHoc = new KhoaHoc(txtMaKhoaHoc.Text, txtNamBatDauKhoaHoc.Text, txtNamKetThucKhoaHoc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (KhoaHocBLL.ModifyKhoaHoc(khoaHoc))
            {
                MessageBox.Show("Đã chỉnh sửa khóa học thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadKhoaHoc();
            }
            else
            {
                MessageBox.Show("Mã khóa học không tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDefaultDataKhoaHoc_Click(object sender, EventArgs e)
        {
            LoadKhoaHoc();
        }

        private void btnSearchKhoaHoc_Click(object sender, EventArgs e)
        {
            if (txtSearchKhoaHoc.Text == "")
            {
                MessageBox.Show("Bạn phải điền thông tin mã khóa học" +
                    " hoặc năm bắt đầu để tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var listKhoaHoc = KhoaHocBLL.GetAllKhoaHoc();
            //Lọc khóa học theo mã khóa học, năm bắt đầu và năm kết thúc
            var filterKhoaHoc = listKhoaHoc.Where(x =>
            {
                string value = txtSearchKhoaHoc.Text;
                if (x.MaKhoaHoc.ToUpper().Contains(value.ToUpper()))
                    return true;
                if (x.NamBatDau.Contains(value) || x.NamKetThuc.Contains(value))
                    return true;
                return false;
            }).ToList();
            dgvKhoaHoc.DataSource = filterKhoaHoc;
        }

        private void dgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvKhoaHoc.Rows[e.RowIndex];
                txtMaKhoaHoc.Text = row.Cells[0].Value.ToString();
                txtNamBatDauKhoaHoc.Text = row.Cells[1].Value.ToString();
                txtNamKetThucKhoaHoc.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
        #endregion

        #region Events_ChuongTrinhHoc


        private void btnAddChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            ChuongTrinhHoc chuongTrinhHoc = null;
            try
            {
                chuongTrinhHoc = new ChuongTrinhHoc()
                {
                    MaChuongTrinhHoc = txtMaChuongTrinhHoc.Text,
                    TenChuongTrinhHoc = txtTenChuongTrinhHoc.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                ChuongTrinhHocBLL.InsertChuongTrinhHoc(chuongTrinhHoc);
                MessageBox.Show("Đã thêm chương trình học thành công!", "Thành công", MessageBoxButtons.OK);
                LoadChuongTrinhHoc();
            }
            catch
            {
                MessageBox.Show("Mã chương trình học đã tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            if (txtMaChuongTrinhHoc.Text == "")
            {
                MessageBox.Show("Không được để trống mã chương trình học!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string message = "Dữ liệu sẽ bị xóa vĩnh viễn và không thể khôi phục!\n" +
                "Bạn có chắc chắn muốn xóa không?";
            var result = MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!ChuongTrinhHocBLL.DeleteChuongTrinhHoc(txtMaChuongTrinhHoc.Text))
                {
                    MessageBox.Show("Mã chương trình học không tồn tại!\nVui lòng kiểm tra lại");
                    return;
                }
                MessageBox.Show("Đã xóa khóa học thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadChuongTrinhHoc();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show($"Không thể xóa chương trình học đang chứa thông tin của lớp học\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnModifyChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            ChuongTrinhHoc chuongTrinhHoc = null;
            try
            {
                chuongTrinhHoc = new ChuongTrinhHoc()
                {
                    MaChuongTrinhHoc = txtMaChuongTrinhHoc.Text,
                    TenChuongTrinhHoc = txtTenChuongTrinhHoc.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (ChuongTrinhHocBLL.ModifyChuongTrinhHoc(chuongTrinhHoc))
            {
                MessageBox.Show("Đã chỉnh sửa chương trình học thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadChuongTrinhHoc();
            }
            else
            {
                MessageBox.Show("Mã chương trình học không tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDefaultDataChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            LoadChuongTrinhHoc();
        }

        private void btnSearchChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            if (txtSearchChuongTrinhHoc.Text == "")
            {
                MessageBox.Show("Điền tên mã chương trình" +
                    " hoặc tên chương trình để tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var listChuongTrinhHoc = ChuongTrinhHocBLL.GetAllChuongTrinhHoc();
            var listFilterChuongTrinhHoc = listChuongTrinhHoc.Where(x =>
            {
                if (x.MaChuongTrinhHoc.ToUpper().Contains(txtSearchChuongTrinhHoc.Text.ToUpper()))
                    return true;
                string nameRemovedSign = ApplicationHelper.RemoveSignForVietnameseString(x.TenChuongTrinhHoc.ToUpper());
                string searchTen = ApplicationHelper.RemoveSignForVietnameseString(txtSearchChuongTrinhHoc.Text.ToUpper());
                if (nameRemovedSign.Contains(searchTen))
                    return true;
                return false;
            }).ToList();
            dgvChuongTrinhHoc.DataSource = listFilterChuongTrinhHoc;
        }

        private void dgvChuongTrinhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvChuongTrinhHoc.Rows[e.RowIndex];
                txtMaChuongTrinhHoc.Text = row.Cells[0].Value.ToString();
                txtTenChuongTrinhHoc.Text = row.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
        #endregion

        #region Events_Class

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == (int)quanLy.LopHoc)
                LoadClass();
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (cbMaKhoa_Class.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khoa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (cbMaKhoaHoc_Class.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (cbMaChuongTrinh_Class.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chương trình học!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Class _class = null;
            try
            {
                _class = new Class()
                {
                    MaLop = txtMaLop.Text,
                    TenLop = txtTenLop.Text,
                    MaKhoa = (cbMaKhoa_Class.SelectedItem as Khoa).MaKhoa,
                    MaKhoaHoc = (cbMaKhoaHoc_Class.SelectedItem as KhoaHoc).MaKhoaHoc,
                    MaCT = (cbMaChuongTrinh_Class.SelectedItem as ChuongTrinhHoc).MaChuongTrinhHoc
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                ClassBLL.InsertClass(_class);
                MessageBox.Show("Đã thêm lớp học thành công!", "Thành công", MessageBoxButtons.OK);
                LoadClass();
                txtMaLop.Clear();
                txtTenLop.Clear();
            }
            catch
            {
                MessageBox.Show("Mã lớp học đã tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Không được để trống mã lớp!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string message = "Xóa lớp học sẽ xóa tất cả thông tin sinh viên ở trong lớp đó!\n";
            message += "Dữ liệu sẽ bị xóa vĩnh viễn và không thể khôi phục!\n";
            message += "Bạn có chắc chắn muốn xóa lớp học này không?";
            var result = MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if(ClassBLL.DeleteClass(txtMaLop.Text))
                {
                    MessageBox.Show("Đã xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadClass();
                }
                else
                {
                    MessageBox.Show("Mã lớp học không tồn tạ" +
                        "i!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnModifyClass_Click(object sender, EventArgs e)
        {
            Class _class = null;
            try
            {
                _class = new Class()
                {
                    MaLop = txtMaLop.Text,
                    TenLop = txtTenLop.Text,
                    MaKhoa = (cbMaKhoa_Class.SelectedItem as Khoa).MaKhoa,
                    MaKhoaHoc = (cbMaKhoaHoc_Class.SelectedItem as KhoaHoc).MaKhoaHoc,
                    MaCT = (cbMaChuongTrinh_Class.SelectedItem as ChuongTrinhHoc).MaChuongTrinhHoc
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (ClassBLL.ModifyClass(_class))
            {
                MessageBox.Show("Đã thay đổi thông tin lớp học thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadClass();
            }
            else
            {
                MessageBox.Show("Mã lớp học không tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDefaultDataClass_Click(object sender, EventArgs e)
        {
            LoadClass();
        }

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            if (txtSearchClass.Text == "")
            {
                MessageBox.Show("Điền mã lớp hoặc tên lớp để tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var listClass = ClassBLL.GetAllClass();
            var listFilterClass = listClass.Where(x =>
            {
                if (x.MaLop.ToUpper().Contains(txtSearchClass.Text.ToUpper()))
                    return true;
                string nameRemovedSign = ApplicationHelper.RemoveSignForVietnameseString(x.TenLop.ToUpper());
                string searchName = ApplicationHelper.RemoveSignForVietnameseString(txtSearchClass.Text.ToUpper());
                if (nameRemovedSign.Contains(searchName))
                    return true;
                return false;
            }
            ).ToList();
            dgvClass.DataSource = listFilterClass;
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvClass.Rows[e.RowIndex];
                
                txtMaLop.Text = row.Cells[0].Value.ToString();
                txtTenLop.Text = row.Cells[1].Value.ToString();

                List<Khoa> listKhoa = (List<Khoa>)cbMaKhoa_Class.DataSource;
                cbMaKhoa_Class.SelectedIndex = listKhoa.FindIndex(x => x.MaKhoa == row.Cells[2].Value.ToString());
                listKhoa = null;

                var listKhoaHoc = (List<KhoaHoc>)cbMaKhoaHoc_Class.DataSource;
                cbMaKhoaHoc_Class.SelectedIndex = listKhoaHoc.FindIndex(x => x.MaKhoaHoc == row.Cells[3].Value.ToString());
                listKhoaHoc = null;

                var listChuongTrinh = (List<ChuongTrinhHoc>)cbMaChuongTrinh_Class.DataSource;
                cbMaChuongTrinh_Class.SelectedIndex = listChuongTrinh.FindIndex(x => x.MaChuongTrinhHoc == row.Cells[4].Value.ToString());
                listChuongTrinh = null;
            }
            catch
            {

            }
        }

        private void pnContainDgvClass_SizeChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Created == false)
            {
                return;
            }
            if (dgvClass.Size.Width > 430)
            {
                dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        #endregion

        #region Events_Account
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Account _account;
            try
            {
                _account = new Account()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Displayname = txtDisplayName.Text,
                    Email = txtEmail.Text,
                    Type = cbAccountType.SelectedItem.ToString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                AccountBLL.InsertAccount(_account);
                MessageBox.Show("Đã thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadAccount();
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Tên tài khoản đã được sử dụng!"))
                {
                    MessageBox.Show(ex.Message + "\nVui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show(ex.Message + "\nVui lòng thay đổi địa chỉ email!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Không được để trống tên tài khoản!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtUsername.Text == account.Username)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string message = "Dữ liệu sẽ bị xóa vĩnh viễn và không thể khôi phục!\n" +
                "Bạn có chắc chắn muốn xóa không?";
            var result = MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            
            if (AccountBLL.DeleteAccount(txtUsername.Text))
            {
                MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnModifyAccount_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == account.Username)
            {
                MessageBox.Show("Không thể thay đổi thông tin " +
                    "tài khoản đang sử dụng đăng nhập!", "Thông báo");
                return;
            }
            Account _account;
            try
            {
                _account = new Account()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Displayname = txtDisplayName.Text,
                    Email = txtEmail.Text,
                    Type = cbAccountType.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (AccountBLL.ModifyAccount(_account))
            {
                MessageBox.Show("Đã thay đổi thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDefaultDataAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            if (txtSearchAccount.Text == "")
            {
                MessageBox.Show("Điền tên đăng nhập hoặc tên hiển thị để tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var listAccount = AccountBLL.GetAllAccount();
            var listFilterAccount = listAccount.Where(x =>
            {
                if (x.Username.ToUpper().Contains(txtSearchAccount.Text.ToUpper()))
                    return true;
                string nameRemovedSign = ApplicationHelper.RemoveSignForVietnameseString(x.Displayname.ToUpper());
                string searchName = ApplicationHelper.RemoveSignForVietnameseString(txtSearchAccount.Text.ToUpper());
                if (nameRemovedSign.Contains(searchName))
                    return true;
                return false;
            }).ToList();
            dgvAccount.DataSource = listFilterAccount;
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvAccount.Rows[e.RowIndex];

                txtUsername.Text = row.Cells[0].Value.ToString();
                txtDisplayName.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                cbAccountType.SelectedIndex = cbAccountType.FindString(row.Cells[4].Value.ToString());
            }
            catch
            {

            }
        }

        private void pnContainDgvAccount_SizeChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Created == false)
            {
                return;
            }
            if (dgvAccount.Size.Width > 550)
            {
                dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        #endregion

        #endregion
    }
}
