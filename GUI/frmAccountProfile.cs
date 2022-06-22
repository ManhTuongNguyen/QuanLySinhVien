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
    public partial class frmAccountProfile : Form
    {
        Account currentAccount;
        public frmAccountProfile(Account account)
        {
            InitializeComponent();
            currentAccount = account;
            txtUsername.Text = account.Username;
            txtDisplayName.Text = account.Displayname;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text != currentAccount.Password)
            {
                MessageBox.Show("Mật khẩu của bạn không chính xác!\nHãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            if (txtNewPass.Text != txtRenewPass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!\nHãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            if (txtRenewPass.Text == "")
            {
                //Đổi tên hiển thị

                if (AccountBLL.ChangeDisplayNameAccount(txtUsername.Text, txtDisplayName.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Có lỗi đã xảy ra.\nHãy thử lại!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (AccountBLL.ChangePassordAccount(txtUsername.Text, txtNewPass.Text, txtDisplayName.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Có lỗi đã xảy ra.\nHãy thử lại!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void pbCurrentPass_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = !txtCurrentPassword.UseSystemPasswordChar;
        }

        private void pbNewPass_Click(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = !txtNewPass.UseSystemPasswordChar;
        }

        private void pbReNewPass_Click(object sender, EventArgs e)
        {
            txtRenewPass.UseSystemPasswordChar = !txtRenewPass.UseSystemPasswordChar;
        }
    }
}
