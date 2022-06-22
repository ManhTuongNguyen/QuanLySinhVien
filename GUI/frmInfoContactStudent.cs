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
    public partial class frmInfoContactStudent : Form
    {
        public frmInfoContactStudent()
        {
            InitializeComponent();
            dgvInfoContactStudent.AllowUserToResizeRows = false;
        }
        #region Methods
        private void LoadCombobox()
        {
            var listSinhVien = SinhVienBLL.GetAllStudent();
            cbbMaSV.DataSource = listSinhVien;
            cbbMaSV.DisplayMember = "HoTen";


            foreach (SinhVien sinhVien in listSinhVien)
            {
                cbbSearchStudentContact.Items.Add(sinhVien.MaSV + " - " + sinhVien.HoTen);
            }
        }

        private void LoadData()
        {
            dgvInfoContactStudent.DataSource = InfoContactStudentBLL.GetAllContactOfStudent();
        }

        private void FormatDataGridView()
        {
            dgvInfoContactStudent.Columns[0].HeaderText = "MSV";
            dgvInfoContactStudent.Columns[1].HeaderText = "SDT SV";
            dgvInfoContactStudent.Columns[2].HeaderText = "Email SV";
            dgvInfoContactStudent.Columns[3].HeaderText = "Tên người thân";
            dgvInfoContactStudent.Columns[4].HeaderText = "SDT người thân";

            dgvInfoContactStudent.Columns[0].Width = 60;
            dgvInfoContactStudent.Columns[1].Width = 75;
            dgvInfoContactStudent.Columns[2].Width = 120;
            dgvInfoContactStudent.Columns[3].Width = 140;
            dgvInfoContactStudent.Columns[4].Width = 80;
        }
        private void ClearTextBox()
        {
            txtEmailSV.Clear();
            txtNameRelativeOfStudent.Clear();
            txtPhoneNumberRelativeOfStudent.Clear();
            txtSDTSV.Clear();
        }

        #endregion

        #region Events
        private void frmInfoContactStudent_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData();
            FormatDataGridView();
        }

        private void btnAddContactStudent_Click(object sender, EventArgs e)
        {
            if (cbbMaSV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            ContactOfStudent contact;
            try
            {
                contact = new ContactOfStudent();
                contact.StudentCode = (cbbMaSV.SelectedItem as SinhVien).MaSV;
                contact.StudentPhoneNumber = txtSDTSV.Text;
                contact.StudentEmailAddress = txtEmailSV.Text;
                contact.NameOfRelativeStudent = txtNameRelativeOfStudent.Text;
                contact.PhoneNumberOfRelativeStudent = txtPhoneNumberRelativeOfStudent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                InfoContactStudentBLL.InsertContactStudent(contact);
                MessageBox.Show("Đã thêm thông tin liên lạc của sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                ClearTextBox();
                LoadData();
            }
            catch (Exception)
            {
                string message = "Thông tin liên lạc của sinh " +
                    "viên này đã tồn tại!\nVui lòng kiểm tra lại!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            }
        }


        private void btnModifyContactStudent_Click(object sender, EventArgs e)
        {
            ContactOfStudent contact;
            try
            {
                contact = new ContactOfStudent();
                contact.StudentCode = (cbbMaSV.SelectedItem as SinhVien).MaSV;
                contact.StudentPhoneNumber = txtSDTSV.Text;
                contact.StudentEmailAddress = txtEmailSV.Text;
                contact.NameOfRelativeStudent = txtNameRelativeOfStudent.Text;
                contact.PhoneNumberOfRelativeStudent = txtPhoneNumberRelativeOfStudent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (InfoContactStudentBLL.ModifyInfoContactStudent(contact))
            {
                MessageBox.Show("Đã thay đổi thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Có lỗi đã xảy ra!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteContactStudent_Click(object sender, EventArgs e)
        {
            string maSV = (cbbMaSV.SelectedItem as SinhVien).MaSV;
            if (InfoContactStudentBLL.DeleteContactByStudentCode(maSV))
            {
                MessageBox.Show("Đã xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Có lỗi đã xảy ra!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            var listContact = InfoContactStudentBLL.GetAllContactOfStudent();
            if (cbbSearchStudentContact.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên trước!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string studentCode = cbbSearchStudentContact.SelectedItem.ToString().Split('-')[0];
            studentCode = studentCode.Substring(0, studentCode.Length - 1);
            dgvInfoContactStudent.DataSource = listContact.Where(x =>
            {
                if (x.StudentCode.Equals(studentCode))
                    return true;
                return false;
            }).ToList();
        }

        private void btnDefaultDataContactStudent_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvInfoContactStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvInfoContactStudent.Rows[e.RowIndex];
            try
            {
                List<SinhVien> listSinhVien = (List<SinhVien>)cbbMaSV.DataSource;
                cbbMaSV.SelectedIndex = listSinhVien.FindIndex(x => x.MaSV.Equals(row.Cells[0].Value.ToString()));
                txtSDTSV.Text = row.Cells[1].Value.ToString();
                txtEmailSV.Text = row.Cells[2].Value.ToString();
                txtNameRelativeOfStudent.Text = row.Cells[3].Value.ToString();
                txtPhoneNumberRelativeOfStudent.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }
        private void pnContainDgv_SizeChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Created == false)
            {
                return;
            }
            if (dgvInfoContactStudent.Size.Width > 500)
            {
                dgvInfoContactStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgvInfoContactStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        #endregion

    }
}
