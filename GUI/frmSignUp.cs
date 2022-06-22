using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSignUp : Form
    {
        public frmSignUp(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtRepassword.UseSystemPasswordChar = true;
        }

        private void pbPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void pbRePass_Click(object sender, EventArgs e)
        {
            txtRepassword.UseSystemPasswordChar = !txtRepassword.UseSystemPasswordChar;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Account account;
            //Kiểm tra thông tin tài khoản có phù hợp hay không
            try
            {
                if (!txtPassword.Text.Equals(txtRepassword.Text))
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp!\nKiểm tra lại!");
                    return;
                }
                //Tài khoản đăng ký mặc định là của sinh viên
                string accountType = "Sinh viên";
                if (txtUsername.Text == "admin")
                    accountType = "Administrator";
                account = new Account(txtUsername.Text, txtPassword.Text, txtDisplayName.Text, txtEmail.Text, accountType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //Thêm tài khoản vào database
            try
            {
                var result = MessageBox.Show("Điền không đúng địa chỉ email sẽ không" +
                    " thể đăng nhập được ứng dụng!\nKhi đăng ký đồng nghĩa với chấp nhận" +
                    " điều khoản của ứng dụng!\nBạn có đồng ý đăng ký tài" +
                    " khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                AccountBLL.InsertAccount(account);
                MessageBox.Show("Bạn đã đăng ký thành công!", "Thông báo", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Tên tài khoản đã được sử dụng!")
                {
                    MessageBox.Show(ex.Message + "\nVui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show(ex.Message + "\nVui lòng thay đổi địa chỉ email!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void llbAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "https://github.com/ManhTuongNguyen/");
        }
    }
}
