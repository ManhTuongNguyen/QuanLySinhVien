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
    public partial class frmMain : Form
    {
        Account currentAccount;
        public frmMain(Account account)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.iconManageStudent;
            currentAccount = account;
            thoongToolStripMenuItem.Text = $"Thông tin cá nhân ({account.Displayname})";

            switch (currentAccount.Type)
            {
                case "Administrator":
                    pnThongTinSinhVien.Visible = false;
                    pnQuanLy.BackColor = Color.Transparent;
                    break;
                case "Giáo viên":
                    adminToolStripMenuItem.Enabled = false;
                    pnThongTinSinhVien.Visible = false;
                    pnQuanLy.BackColor = Color.Transparent;
                    break;
                case "Sinh viên":
                    adminToolStripMenuItem.Enabled = false;
                    pnQuanLy.Visible = false;
                    pnThongTinSinhVien.BackColor = Color.Transparent;
                    pnThongTinSinhVien.Location = new Point(420, 103);
                    break;
                default:
                    throw new Exception("Please don't hack my software!");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thayĐổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAccountProfile form = new frmAccountProfile(currentAccount))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Cập nhật lại thông tin tên hiển thị
                    Account newAccount = AccountBLL.GetAccountByUsername(currentAccount.Username);
                    thoongToolStripMenuItem.Text = $"Thông tin cá nhân ({newAccount.Displayname})";
                }
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formAdministrator = new frmAdministrator(currentAccount))
            {
                formAdministrator.ShowDialog();
            }
        }

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            using (var form = new frmQuanLyMonHoc())
            {
                form.ShowDialog();
            }
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            using (var form = new frmQuanLySinhVien())
            {
                form.ShowDialog();
            }
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            using (var form = new frmQuanLyKetQua())
            {
                form.ShowDialog();
            }
        }

        private void btnDiemDetails_Click(object sender, EventArgs e)
        {
            using (var form = new frmDiemDetails())
            {
                form.ShowDialog();
            }
        }

        private void btnInfoContactStudent_Click(object sender, EventArgs e)
        {
            using (var form = new frmInfoContactStudent())
            {
                form.ShowDialog();
            }
        }

        private void btnThongTinSinhVien_Click(object sender, EventArgs e)
        {
            using (var form = new frmHoSoSinhVien(currentAccount.Username))
            {
                form.ShowDialog();
            }
        }

        private void btnDiemSinhVien_Click(object sender, EventArgs e)
        {
            using (var form = new frmDiemSinhVien(currentAccount.Username))
            {
                form.ShowDialog();
            }
        }
    }
}
