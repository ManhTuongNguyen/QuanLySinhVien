using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private static readonly int MinimumTimeLoginInterval = 90; // Time in seconds

        private readonly string fileStoreTimeLogin = "LoginLog.csv";
        Dictionary<string, string> DictTimeLogin = new Dictionary<string, string>();

        #region Events
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Lấy tài khoản đã lưu trong Settings lên Textbox nếu trước đó đã lưu tài khoản
            cbRemember.Checked = Properties.Settings.Default.cbRememb;
            txtUsername.Text = Properties.Settings.Default.username;
            txtPassword.Text = Properties.Settings.Default.password;


            //Lấy dữ liệu login lưu từ file
            if (File.Exists(fileStoreTimeLogin))
            {
                try
                {
                    DictTimeLogin = ApplicationHelper.ReadDictionaryFromFile(fileStoreTimeLogin);
                }
                catch
                {

                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra thông tin tài khoản
                Account account = AccountBLL.GetAccountByUsername_Password(txtUsername.Text, txtPassword.Text);

                //Tìm thấy tài khoản trong CSDl
                if (account.Username != null)
                {
                    if (!Login(account))
                        return;
                }
                else
                {
                    //Không tìm thấy tài khoản trên cơ sở dữ liệu
                    string message = "Thông tin tài khoản hoặc mật khẩu không chính xác!\n";
                    message += "Vui lòng kiểm tra lại!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("software"))
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(ApplicationHelper.MessageError(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp formSignUp = new frmSignUp(txtUsername.Text);
            this.Hide();
            formSignUp.ShowDialog();
            this.Show();
        }

        private void pbPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !(txtPassword.UseSystemPasswordChar);
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            using (frmRetrievePassword form = new frmRetrievePassword(txtUsername.Text))
            {
                form.ShowDialog();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            ApplicationHelper.WriteDictionaryToFile(DictTimeLogin, fileStoreTimeLogin);
            SaveAccountToSettings();
        }

        private void lblForgetPassword_MouseHover(object sender, EventArgs e)
        {
            lblForgetPassword.ForeColor = Color.DodgerBlue;
        }

        private void lblForgetPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgetPassword.ForeColor = Color.LightSkyBlue;
        }

        #endregion


        #region Methods

        private bool Login(Account _account)
        {

            //Kiểm tra thời gian đăng nhập với lần đăng nhập gần nhất có hợp lệ hay không
            if (!AllowLogin(MyEncryptHelper.Encrypt(txtUsername.Text)))
            {
                string message = "Hệ thống phát hiện bất thường trong quá trình đăng nhập của bạn!\n";
                message += "Vui lòng thử lại sau ít phút!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            //Thêm thông tin thời gian đăng nhập của tài khoản vào
            //Dictionary để kiểm tra đăng nhập vào những lần sau
            DictTimeLogin[$"{MyEncryptHelper.Encrypt(txtUsername.Text)}"] = DateTime.Now.ToString();

            //Bảo mật 2 lớp
            string nameRecieve = _account.Displayname;

            using (frmCheckAuthenticCode form = new frmCheckAuthenticCode(_account.Email, nameRecieve))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Mã xác nhận hợp lệ
                    this.Hide();
                    using (frmMain formMain = new frmMain(_account))
                    {
                        formMain.ShowDialog();
                    }
                    this.Show();
                }
            }
            return true;
        }
        private void SaveAccountToSettings()
        {
            Properties.Settings.Default.cbRememb = cbRemember.Checked;
            if (Properties.Settings.Default.cbRememb)
            {
                Properties.Settings.Default.username = txtUsername.Text;
                Properties.Settings.Default.password = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
            }
            Properties.Settings.Default.Save();
        }


        private bool AllowLogin(string key)
        {
            if (DictTimeLogin.ContainsKey(key))
            {
                if (Math.Abs(ApplicationHelper.CaculateTimeDifferent(DictTimeLogin[key],
                    DateTime.Now.ToString())) < MinimumTimeLoginInterval)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

    }
}
