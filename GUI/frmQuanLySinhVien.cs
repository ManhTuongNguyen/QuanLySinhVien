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
    public partial class frmQuanLySinhVien : Form
    {
        private enum DataComboboxSearch_SortStudent
        {
            Lop = 0,
            Ten = 1,
            MaSinhVien = 2,
            DangHoc = 3,
            BaoLuu = 4
        };

        private Point LocationOfControlSearchStudent = new Point(140, 25);
        private Size SizeOfControlSearchStudent = new Size(166, 27);
        #region Events
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            dgvSinhVien.AllowUserToResizeRows = false;
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            ReloadDataGridViewData();
            LoadForm();
        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            if (cbbMaLop_SV.SelectedIndex == -1)
            {
                MessageBox.Show("Không được bỏ trống mã lớp!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            SinhVien sinhVien;
            try
            {
                sinhVien = new SinhVien
                {
                    MaSV = txtMaSinhVien.Text,
                    HoTen = txtHoTenSV.Text,
                    NgaySinh = dtpNgaySinhSV.Value.ToShortDateString(),
                    GioiTinh = cbbGioiTinhSV.SelectedItem.ToString(),
                    QueQuan = txtQueQuanSV.Text,
                    DanToc = txtDanToc.Text,
                    MaLop = (cbbMaLop_SV.SelectedItem as Class).MaLop,
                    TinhTrang = cbbTinhTrangSV.SelectedItem.ToString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                SinhVienBLL.InsertStudent(sinhVien);
                MessageBox.Show($"Đã thêm sinh viên {txtHoTenSV.Text} thành công!", "Thông báo", MessageBoxButtons.OK);
                ReloadDataGridViewData();
                ClearTextBox();
            }
            catch
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!\nVui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnModiFySinhVien_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien;
            try
            {
                sinhVien = new SinhVien
                {
                    MaSV = txtMaSinhVien.Text,
                    HoTen = txtHoTenSV.Text,
                    NgaySinh = dtpNgaySinhSV.Value.ToShortDateString(),
                    GioiTinh = cbbGioiTinhSV.SelectedItem.ToString(),
                    QueQuan = txtQueQuanSV.Text,
                    DanToc = txtDanToc.Text,
                    MaLop = (cbbMaLop_SV.SelectedItem as Class).MaLop,
                    TinhTrang = cbbTinhTrangSV.SelectedItem.ToString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (!SinhVienBLL.ModifyStudent(sinhVien))
            {
                string message = "Không tìm thấy thông tin sinh viên này trên hệ thống\n";
                message += "Vui lòng kiểm tra lại!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Đã thay đổi thông tin thành công!");
                ClearTextBox();
                ReloadDataGridViewData();
            }
        }

        private void btnDeleteSinhVien_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã sinh viên!");
                return;
            }
            string message = "Sau khi loại sinh viên khỏi danh sách sẽ xóa tất cả\n" +
                " thông tin như điểm và thông tin cá nhân của sinh viên này.\n";
            message += "Dữ liệu sẽ bị xóa vĩnh viễn và không thể khôi phục!\n";
            message += "Bạn có chắc chắn muốn loại sinh viên này khỏi danh sách không?";
            var result = MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!SinhVienBLL.DeleteStudentByStudentCode(txtMaSinhVien.Text.ToUpper()))
                {
                    MessageBox.Show("Mã sinh viên không tồn tại!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Đã xóa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                ReloadDataGridViewData();
            }
        }
                

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSinhVien.Text = row.Cells[0].Value.ToString();
                txtHoTenSV.Text = row.Cells[1].Value.ToString();
                dtpNgaySinhSV.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                cbbGioiTinhSV.SelectedIndex = cbbGioiTinhSV.FindString(row.Cells[3].Value.ToString());
                txtQueQuanSV.Text = row.Cells[4].Value.ToString();
                txtDanToc.Text = row.Cells[5].Value.ToString();
                var listClass = (List<Class>)cbbMaLop_SV.DataSource;
                cbbMaLop_SV.SelectedIndex = listClass.FindIndex(x => x.MaLop == row.Cells[6].Value.ToString());
                listClass = null;

                cbbTinhTrangSV.SelectedIndex = cbbTinhTrangSV.FindString(row.Cells[7].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnDefaultDataStudent_Click(object sender, EventArgs e)
        {
            ReloadDataGridViewData();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            switch (cbbSearchStudent.SelectedIndex)
            {
                case (int)DataComboboxSearch_SortStudent.Lop:
                    SearchStudentByClassCode();
                    break;
                case (int)DataComboboxSearch_SortStudent.Ten:
                    SearchStudentByStudentName();
                    break;
                case (int)DataComboboxSearch_SortStudent.MaSinhVien:
                    SearchStudentByStudentCode();
                    break;
                case (int)DataComboboxSearch_SortStudent.DangHoc:
                    dgvSinhVien.DataSource = SinhVienBLL.GetAllStudentByStatus("Đang học");
                    break;
                default:
                    dgvSinhVien.DataSource = SinhVienBLL.GetAllStudentByStatus("Bảo lưu");
                    break;
            }
        }

        private void cbbSearchStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbSearchStudent.SelectedIndex)
            {
                case (int)DataComboboxSearch_SortStudent.Lop:
                    //Tạo controls comboBox chứa dữ liệu tên lớp cho người dùng lựa chọn
                    CreateComboBoxSearchStudentByClass();
                    break;
                case (int)DataComboboxSearch_SortStudent.Ten:
                    {
                        //Tạo textbox dùng để nhập tên sinh viên cần tìm
                        string name = "txtStudentName";
                        CreateTextBoxSearchStudent(name);
                        break;
                    }

                case (int)DataComboboxSearch_SortStudent.MaSinhVien:
                    {
                        //Tạo textbox dùng để nhập mã sinh viên cần tìm
                        string name = "txtStudentCode";
                        CreateTextBoxSearchStudent(name);
                        break;
                    }

                default:
                    DeleteOldControl();
                    break;
            }
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            switch (cbbSortStudent.SelectedIndex)
            {
                case (int)DataComboboxSearch_SortStudent.Lop:
                    SortStudentByClassCode();
                    break;
                case (int)DataComboboxSearch_SortStudent.Ten:
                    SortStudentByStudentName();
                    break;
                case (int)DataComboboxSearch_SortStudent.MaSinhVien:
                    SortStudentByStudentCode();
                    break;
            }
        }

        private void btnSortDes_Click(object sender, EventArgs e)
        {
            switch (cbbSortStudent.SelectedIndex)
            {
                case (int)DataComboboxSearch_SortStudent.Lop:
                    SortStudentByClassCode(-1);
                    break;
                case (int)DataComboboxSearch_SortStudent.Ten:
                    SortStudentByStudentName(-1);
                    break;
                case (int)DataComboboxSearch_SortStudent.MaSinhVien:
                    SortStudentByStudentCode(-1);
                    break;
            }
        }

        private void pnContainerDgv_SizeChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Created == false)
            {
                return;
            }

            if (dgvSinhVien.Size.Width > 500)
            {
                dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        #endregion

        #region Methods

        private void SearchStudentByStudentCode()
        {
            string maSV = "";
            foreach (Control control in pnSearchSinhVien.Controls)
            {
                if (control.Name == "txtStudentCode")
                {
                    maSV = ((TextBox)control).Text;
                    if (maSV == "")
                    {
                        MessageBox.Show("Phải điền thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    break;
                }
            }
            var listSinhVien = SinhVienBLL.GetAllStudent();
            dgvSinhVien.DataSource = listSinhVien.Where(x => x.MaSV.Contains(maSV.ToUpper())).ToList();
            listSinhVien = null;
        }

        private void SearchStudentByStudentName()
        {
            //Tìm kiếm sinh viên theo tên
            string tenSV = "";
            //Tìm control được tạo khi chọn combobox
            foreach (Control control in pnSearchSinhVien.Controls)
            {
                if (control.Name == "txtStudentName")
                {
                    tenSV = ((TextBox)control).Text;
                    if (tenSV == "")
                    {
                        MessageBox.Show("Phải điền thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    break;
                }
            }

            var listSinhVien = SinhVienBLL.GetAllStudent();

            //dgvSinhVien.DataSource = listSinhVien.Where(x => x.HoTen.ToUpper().Contains(tenSV.ToUpper())).ToList();

            dgvSinhVien.DataSource = listSinhVien.Where(x =>
            {
                string nameRemovedSign = ApplicationHelper.RemoveSignForVietnameseString(x.HoTen.ToUpper());
                string searchName = ApplicationHelper.RemoveSignForVietnameseString(tenSV.ToUpper());
                if (nameRemovedSign.Contains(searchName))
                {
                    return true;
                }
                return false;
            }).ToList();
            listSinhVien = null;
        }

        private void SearchStudentByClassCode()
        {
            //Tìm kiếm sinh viên theo lớp
            string maLop = "";
            //Tìm control được tạo khi chọn combobox
            foreach (Control control in pnSearchSinhVien.Controls)
            {
                if (control.Name == "cbbSearchStudentByClass")
                {
                    if (((ComboBox)control).SelectedIndex == -1)
                    {
                        string message = "Nội dung tìm kiếm không hợp lệ!\n" +
                            "Vui lòng kiểm tra lại!";
                        MessageBox.Show(message, "Thông báo");
                        return;
                    }
                    //Cast control sang ComboBox, sau đó cast sang đối tượng Class rồi lấy mã lớp
                    maLop = (((ComboBox)control).SelectedItem as Class).MaLop;
                    break;
                }
            }

            dgvSinhVien.DataSource = SinhVienBLL.GetAllStudentByClassCode(maLop);
        }


        /// <summary>
        /// Sắp xếp danh sách sinh viên theo mã lớp
        /// </summary>
        /// <param name="sort">Kiểu sắp xếp (tăng dần = 1| giảm dần = -1)</param>
        private void SortStudentByClassCode(int sort = 1)
        {
            var listStudent = (List<SinhVien>)dgvSinhVien.DataSource;
            listStudent.Sort((s1, s2) =>
            {
                return string.Compare(s1.MaLop, s2.MaLop) * sort;
            });
            dgvSinhVien.DataSource = listStudent;
            dgvSinhVien.Refresh();
        }

        /// <summary>
        /// Sắp xếp sinh viên theo tên
        /// </summary>
        /// <param name="sort">Kiểu sắp xếp (tăng dần = 1 | giảm dần = -1)</param>
        private void SortStudentByStudentName(int sort = 1)
        {
            var listStudent = (List<SinhVien>)dgvSinhVien.DataSource;
            listStudent.Sort((s1, s2) =>
            {
                return string.Compare(s1.HoTen, s2.HoTen) * sort;
            });
            dgvSinhVien.DataSource = listStudent;
            dgvSinhVien.Refresh();
        }

        /// <summary>
        /// Sắp xếp sinh viên theo mã sinh viên
        /// </summary>
        /// <param name="sort">Kiểu sắp xếp (tăng dần = 1| giảm dần = -1)</param>
        private void SortStudentByStudentCode(int sort = 1)
        {
            var listStudent = (List<SinhVien>)dgvSinhVien.DataSource;
            listStudent.Sort((s1, s2) =>
            {
                return string.Compare(s1.MaSV, s2.MaSV) * sort;
            });
            dgvSinhVien.DataSource = listStudent;
            dgvSinhVien.Refresh();
        }

        private void LoadForm()
        {
            dgvSinhVien.DataSource = SinhVienBLL.GetAllStudent();
            FormatDataGridView();

            cbbGioiTinhSV.SelectedIndex = 0;
            cbbTinhTrangSV.SelectedIndex = 0;
            cbbSearchStudent.SelectedIndex = 0;
            cbbSortStudent.SelectedIndex = 0;
        }

        private void FormatDataGridView()
        {
            dgvSinhVien.Columns[0].HeaderText = "Mã SV";
            dgvSinhVien.Columns[1].HeaderText = "Họ tên";
            dgvSinhVien.Columns[2].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns[3].HeaderText = "Giới tính";
            dgvSinhVien.Columns[4].HeaderText = "Quê quán";
            dgvSinhVien.Columns[5].HeaderText = "Dân tộc";
            dgvSinhVien.Columns[6].HeaderText = "Mã lớp";
            dgvSinhVien.Columns[7].HeaderText = "Tình trạng";

            dgvSinhVien.Columns[0].Width = 70;
            dgvSinhVien.Columns[1].Width = 150;
            dgvSinhVien.Columns[2].Width = 110;
            dgvSinhVien.Columns[3].Width = 70;
            dgvSinhVien.Columns[4].Width = 130;
            dgvSinhVien.Columns[5].Width = 70;
            dgvSinhVien.Columns[6].Width = 70;
            dgvSinhVien.Columns[7].Width = 70;
        }

        private void ReloadDataGridViewData()
        {
            dgvSinhVien.DataSource = SinhVienBLL.GetAllStudent();
        }

        private void ClearTextBox()
        {
            txtHoTenSV.Clear();
            txtDanToc.Clear();
            txtMaSinhVien.Clear();
            txtQueQuanSV.Clear();
            cbbTinhTrangSV.SelectedIndex = 0;
        }

        private void LoadComboBox()
        {
            cbbGioiTinhSV.Items.Add("Nam");
            cbbGioiTinhSV.Items.Add("Nữ");

            cbbTinhTrangSV.Items.Add("Đang học");
            cbbTinhTrangSV.Items.Add("Bảo lưu");

            cbbMaLop_SV.DataSource = ClassBLL.GetAllClass();
            cbbMaLop_SV.DisplayMember = "TenLop";

            cbbSearchStudent.Items.Add("Lớp");
            cbbSearchStudent.Items.Add("Tên");
            cbbSearchStudent.Items.Add("Mã sinh viên");
            cbbSearchStudent.Items.Add("Đang học");
            cbbSearchStudent.Items.Add("Bảo lưu");

            cbbSortStudent.Items.Add("Mã lớp");
            cbbSortStudent.Items.Add("Tên sinh viên");
            cbbSortStudent.Items.Add("Mã sinh viên");

        }

        private void CreateComboBoxSearchStudentByClass()
        {
            DeleteOldControl();
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            //Không cast được datasource từ cbbMaLop_SV do 2 combobox này tự đồng bộ SelectedIndex với nhau
            var listClass = ClassBLL.GetAllClass();
            ComboBox comboBox = new ComboBox
            {
                DataSource = listClass,
                DisplayMember = "TenLop",
                Size = SizeOfControlSearchStudent,
                AutoCompleteSource = AutoCompleteSource.ListItems,
                Location = LocationOfControlSearchStudent,
                Name = "cbbSearchStudentByClass",
                Font = font,
                DropDownStyle = ComboBoxStyle.DropDown,
                AutoCompleteMode = AutoCompleteMode.SuggestAppend,
                Enabled = listClass.Count == 0 ? false : true,
            };
            pnSearchSinhVien.Controls.Add(comboBox);
        }

        private void CreateTextBoxSearchStudent(string name)
        {
            DeleteOldControl();
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            TextBox textBox = new TextBox
            {
                Size = SizeOfControlSearchStudent,
                Location = LocationOfControlSearchStudent,
                Name = name,
                Font = font
            };
            pnSearchSinhVien.Controls.Add(textBox);
        }

        /// <summary>
        /// Xóa controls cũ được tạo ra khi thay đổi selectedIndex của cbbSearchStudent
        /// </summary>
        private void DeleteOldControl()
        {
            foreach (Control control in pnSearchSinhVien.Controls)
            {
                if (control.Location == LocationOfControlSearchStudent)
                {
                    pnSearchSinhVien.Controls.Remove(control);
                    break;
                }
            }
        }

        #endregion
    }
}
