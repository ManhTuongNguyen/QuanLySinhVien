using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRetrievePassword : Form
    {
        private int minimumTimeToSendPassword = 120;
        private static readonly string fileStoreTimeSendPass = "SendPassLog.csv";
        Dictionary<string, string> DictionaryStoreTimeSendPassword = new Dictionary<string, string>();


        public frmRetrievePassword(string username)
{
            InitializeComponent();
            ReadDictionaryData();
            txtUsername.Text = username;
        }
        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendPassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length < 4)
            {
                MessageBox.Show("Tên tài khoản không hợp lệ!\nThử lại!");
                return;
            }
            Account account = AccountBLL.GetAccountByUsername(txtUsername.Text);
            if (account.Username == null)
            {
                MessageBox.Show("Tên tài khoản không có trên hệ thống!\nVui " +
                    "lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            string email = account.Email;
            string emailWithLessInfo = SendEmailHelper.GetEmaiAddresslWithLessInfo(email);
            if (!IsValidTimeToSendPassword(account.Username))
            {
                string message1 = $"Đã gửi mật khẩu của bạn qua địa chỉ {emailWithLessInfo}\n";
                message1 += "Vui lòng kiểm tra hòm thư của bạn!\n";
                message1 += "Nếu không có hãy kiểm tra trong mục spam.\n";
                message1 += "Chức năng này sẽ khả dụng sau một thời gian ngắn!";
                MessageBox.Show(message1, "Thông báo", MessageBoxButtons.OK);
                return;
            }


            string localName = ApplicationHelper.GetLocalHostName();
            string publicIP = ApplicationHelper.GetPublicIPV4();
            string body = SendEmailHelper.GetBodyMessage_ForgetPassword(
                account.Displayname, account.Password, localName, publicIP);
            string subject = SendEmailHelper.GetSubjectEmail_ForgetPassword();

            SendPasswordAccountToEmail(account, body, subject);

            DictionaryStoreTimeSendPassword[$"{MD5Helper.Encrypt(account.Username, 3)}"] = DateTime.Now.ToString();

            string message = $"Mật khẩu đã được gửi đến email của bạn " +
                $"tại địa chỉ: {emailWithLessInfo}" + Environment.NewLine;
            message += "Hãy đổi mật khẩu ngay khi đăng nhập" +
                " để tăng cường bảo mật cho tài khoản của bạn!";
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
        }

        private void frmRetriePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ApplicationHelper.WriteDictionaryToFile(DictionaryStoreTimeSendPassword, fileStoreTimeSendPass);
            }
            catch
            {

            }
        }

        #endregion

        #region Methods
        private bool IsValidTimeToSendPassword(string _key)
        {
            string key = MD5Helper.Encrypt(_key, 3);
            if (DictionaryStoreTimeSendPassword.ContainsKey(key))
            {
                if (ApplicationHelper.CaculateTimeDifferent(DictionaryStoreTimeSendPassword[key],
                    DateTime.Now.ToString()) < minimumTimeToSendPassword)
                {
                    return false;
                }
            }
            return true;
        }

        private static void SendPasswordAccountToEmail(Account account, string body, string subject)
        {
            try
            {
                Thread thread = new Thread(
                    () => SendEmailHelper.SendEmail(subject, body, account.Email)
                )
                {
                    IsBackground = true
                };
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void ReadDictionaryData()
        {
            if (File.Exists(fileStoreTimeSendPass))
            {
                try
                {
                    DictionaryStoreTimeSendPassword = ApplicationHelper.ReadDictionaryFromFile(fileStoreTimeSendPass);
                }
                catch
                {

                }
            }
        }

        #endregion
    }
}
