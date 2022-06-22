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
    public partial class frmDiemDetails : Form
    {
        public frmDiemDetails()
        {
            InitializeComponent();
            dgvDiemDetails.AllowUserToResizeRows = false;
        }

        private enum DataComboBoxSearch_SortDiem
        {
            TenSinhVien = 0,
            TenLop = 1,
            TenMonHoc = 2,
            Diem = 3
        }
        private void pnContainerDgv_SizeChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Created == false)
            {
                return;
            }
            if (pnContainerDgv.Size.Width > 450)
            {
                dgvDiemDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                FormatDataGridView();
            }
        }

        #region Events
        private void frmDiemDetails_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            cbbSearchDiemDetails.SelectedIndex = 0;
            cbbSortDiemDetails.SelectedIndex = 0;
            LoadDataDiemDetails();
            FormatDataGridView();
        }

        private void btnSearchKetQua_Click(object sender, EventArgs e)
        {
            switch (cbbSearchDiemDetails.SelectedIndex)
            {
                case (int)DataComboBoxSearch_SortDiem.TenSinhVien:
                    SearchKetQuaByStudentName();
                    break;
                case (int)DataComboBoxSearch_SortDiem.TenLop:
                    SearchKetQuaByClassName();
                    break;
                case (int)DataComboBoxSearch_SortDiem.TenMonHoc:
                    SearchKetQuaBySubjectName();
                    break;
                case (int)DataComboBoxSearch_SortDiem.Diem:
                    SearchKetQuaByDiem();
                    break;
            }
        }


        private void btnDefaultDataKetQua_Click(object sender, EventArgs e)
        {
            LoadDataDiemDetails();
        }

        private void btnSortDiemDetails_Asc_Click(object sender, EventArgs e)
        {
            switch (cbbSortDiemDetails.SelectedIndex)
            {
                case (int)DataComboBoxSearch_SortDiem.TenSinhVien:
                    SortKetQuaByStudentName();
                    break;
                case (int)DataComboBoxSearch_SortDiem.TenLop:
                    SortKetQuaByClassName();
                    break;
                case (int)DataComboBoxSearch_SortDiem.TenMonHoc:
                    SortKetQuaBySubjectName();
                    break;
                case (int)DataComboBoxSearch_SortDiem.Diem:
                    SortKetQuaByDiem();
                    break;
            }
        }

        private void btnSortDiemDetails_Des_Click(object sender, EventArgs e)
        {
            switch (cbbSortDiemDetails.SelectedIndex)
            {
                case (int)DataComboBoxSearch_SortDiem.TenSinhVien:
                    SortKetQuaByStudentName(-1);
                    break;
                case (int)DataComboBoxSearch_SortDiem.TenLop:
                    SortKetQuaByClassName(-1);
                    break;
                case (int)DataComboBoxSearch_SortDiem.TenMonHoc:
                    SortKetQuaBySubjectName(-1);
                    break;
                case (int)DataComboBoxSearch_SortDiem.Diem:
                    SortKetQuaByDiem(-1);
                    break;
            }
        }
        #endregion
        //-------------------------------------------------------------------
        #region Methods

        /// <summary>
        /// Sắp xếp danh sách kết quả theo tên sinh viên
        /// </summary>
        /// <param name="sort">Kiểu sắp xếp (tăng dần = 1 | giảm dần = -1)</param>
        private void SortKetQuaByStudentName(int sort = 1)
        {
            var listKetQuaDetails = (List<ChiTietKetQua>)dgvDiemDetails.DataSource;
            listKetQuaDetails.Sort((kq1, kq2) =>
            {
                return String.Compare(kq1.HoTen, kq2.HoTen) * sort;
            });
            dgvDiemDetails.DataSource = listKetQuaDetails;
            dgvDiemDetails.Refresh();
        }

        /// <summary>
        /// Sắp xếp danh sách kết quả theo tên lớp
        /// </summary>
        /// <param name="sort">Kiểu sắp xếp (tăng dần = 1 | giảm dần = -1)</param>
        private void SortKetQuaByClassName(int sort = 1)
        {
            var listKetQuaDetails = (List<ChiTietKetQua>)dgvDiemDetails.DataSource;
            listKetQuaDetails.Sort((kq1, kq2) =>
            {
                return String.Compare(kq1.TenLop, kq2.TenLop) * sort;
            });
            dgvDiemDetails.DataSource = listKetQuaDetails;
            dgvDiemDetails.Refresh();
        }

        /// <summary>
        /// Sắp xếp danh sách kết quả theo tên môn học
        /// </summary>
        /// <param name="sort">Kiểu sắp xếp (tăng dần = 1 | giảm dần = -1)</param>
        private void SortKetQuaBySubjectName(int sort = 1)
        {
            var listKetQuaDetails = (List<ChiTietKetQua>)dgvDiemDetails.DataSource;
            listKetQuaDetails.Sort((kq1, kq2) =>
            {
                return String.Compare(kq1.TenMonHoc, kq2.TenMonHoc) * sort;
            });
            dgvDiemDetails.DataSource = listKetQuaDetails;
            dgvDiemDetails.Refresh();
        }

        /// <summary>
        /// Sắp xếp danh sách kết quả theo điểm
        /// </summary>
        /// <param name="sort">Kiểu sắp xếp (tăng dần = 1 | giảm dần = -1)</param>
        private void SortKetQuaByDiem(int sort = 1)
        {
            var listKetQuaDetails = (List<ChiTietKetQua>)dgvDiemDetails.DataSource;
            listKetQuaDetails.Sort((kq1, kq2) =>
            {
                if (kq1.Diem == "10" || kq2.Diem == "10")
                {
                    if (kq1.Diem == kq2.Diem)
                        return 0;
                    if (kq1.Diem == "10")
                        return 1 * sort;
                    return -1 * sort;
                }
                return String.Compare(kq1.Diem, kq2.Diem) * sort;
            });
            dgvDiemDetails.DataSource = listKetQuaDetails;
            dgvDiemDetails.Refresh();
        }

        private void LoadDataDiemDetails()
        {
            dgvDiemDetails.DataSource = ChiTietKetQuaBLL.GetAllKetQuaDetails();
        }

        private void FormatDataGridView()
        {
            dgvDiemDetails.Columns[0].HeaderText = "Họ tên";
            dgvDiemDetails.Columns[1].HeaderText = "Lớp";
            dgvDiemDetails.Columns[2].HeaderText = "Môn học";
            dgvDiemDetails.Columns[3].HeaderText = "Điểm";

            dgvDiemDetails.Columns[0].Width = 124;
            dgvDiemDetails.Columns[1].Width = 116;
            dgvDiemDetails.Columns[2].Width = 117;
            dgvDiemDetails.Columns[3].Width = 42;
        }

        private void LoadComboBox()
        {
            cbbSearchDiemDetails.Items.Add("Tên sinh viên");
            cbbSearchDiemDetails.Items.Add("Tên lớp");
            cbbSearchDiemDetails.Items.Add("Tên môn học");
            cbbSearchDiemDetails.Items.Add("Điểm");


            cbbSortDiemDetails.Items.Add("Tên sinh viên");
            cbbSortDiemDetails.Items.Add("Tên lớp");
            cbbSortDiemDetails.Items.Add("Tên môn học");
            cbbSortDiemDetails.Items.Add("Điểm");
        }

        private void SearchKetQuaByStudentName()
        {
            var listKetQua = ChiTietKetQuaBLL.GetAllKetQuaDetails();
            //dgvDiemDetails.DataSource = listKetQua.Where(x => x.HoTen.ToUpper().Contains(txtSearchKetQua.Text.ToUpper())).ToList();
            dgvDiemDetails.DataSource = listKetQua.Where(x =>
            {
                string nameRemovedSign = ApplicationHelper.RemoveSignForVietnameseString(x.HoTen.ToUpper());
                string searchStudentName = ApplicationHelper.RemoveSignForVietnameseString(txtSearchKetQua.Text.ToUpper());
                if (nameRemovedSign.Contains(searchStudentName))
                {
                    return true;
                }
                return false;
            }).ToList();
            listKetQua = null;
        }

        private void SearchKetQuaByClassName()
        {
            var listKetQua = ChiTietKetQuaBLL.GetAllKetQuaDetails();
            //dgvDiemDetails.DataSource = listKetQua.Where(x => x.TenLop.ToUpper().Contains(txtSearchKetQua.Text.ToUpper())).ToList();
            dgvDiemDetails.DataSource = listKetQua.Where(x =>
            {
                string nameRemovedSign = ApplicationHelper.RemoveSignForVietnameseString(x.TenLop.ToUpper());
                string searchClassName = ApplicationHelper.RemoveSignForVietnameseString(txtSearchKetQua.Text.ToUpper());
                if (nameRemovedSign.Contains(searchClassName))
                {
                    return true;
                }
                return false;
            }).ToList();
            listKetQua = null;
        }

        private void SearchKetQuaBySubjectName()
        {
            var listKetQua = ChiTietKetQuaBLL.GetAllKetQuaDetails();
            //dgvDiemDetails.DataSource = listKetQua.Where(x => x.TenMonHoc.ToUpper().Contains(txtSearchKetQua.Text.ToUpper())).ToList();
            dgvDiemDetails.DataSource = listKetQua.Where(x =>
            {
                string nameRemovedSign = ApplicationHelper.RemoveSignForVietnameseString(x.TenMonHoc.ToUpper());
                string searchSubjectName = ApplicationHelper.RemoveSignForVietnameseString(txtSearchKetQua.Text.ToUpper());
                if (nameRemovedSign.Contains(searchSubjectName))
                {
                    return true;
                }
                return false;
            }).ToList();
            listKetQua = null;
        }


        private void SearchKetQuaByDiem()
        {
            var listKetQua = ChiTietKetQuaBLL.GetAllKetQuaDetails();
            dgvDiemDetails.DataSource = listKetQua.Where(x => x.Diem.Contains(txtSearchKetQua.Text)).ToList();
            listKetQua = null;
        }

        #endregion

    }
}
