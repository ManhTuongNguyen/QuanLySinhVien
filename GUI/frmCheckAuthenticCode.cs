using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCheckAuthenticCode : Form
    {
        System.Timers.Timer timer;
        int m, s;//Phút, giây

        string authenticCode;
        string emailAddress;
        string subject;
        string body;
        string nameRecieve;

        public frmCheckAuthenticCode(string _email, string _nameRecieve)
        {
            InitializeComponent();
            authenticCode = GenerateCode.Code();
            
            /* Gửi email mã xác nhận | Không còn hoạt động. Đọc README.MD
            emailAddress = _email;
            subject = SendEmailHelper.GetSubjectEmail_AuthenticCode();
            nameRecieve = _nameRecieve;
            body = SendEmailHelper.GetBodyMessage_AuthenticCode(nameRecieve, authenticCode);
            */
        }

        private void frmCheckAuthenticCode_Load(object sender, EventArgs e)
        {
            /* 
            SendAuthenticCode(subject, body, emailAddress);
            string emailWithLessInfo = SendEmailHelper.GetEmaiAddresslWithLessInfo(emailAddress);
            string message = $"Đã gửi mã xác nhận đến tài khoản {emailWithLessInfo}\n";
            message += "Vui lòng kiểm tra hộp thư đến để lấy mã xác nhận!\n";
            message += "Nếu không thấy tin nhắn, hãy kiểm tra trong mục SPAM!";
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            */

            //Bắt đầu tính thời gian tồn tại của
            //mã xác nhận kể từ thời điểm user ấn nút OK
            StartTimeAuthenticCode();
        }



        private void StartTimeAuthenticCode()
        {
            m = 3; s = 0;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            timer.Start();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    s -= 1;
                    if (s == 0 || s < 0)
                    {
                        if (m == 0)
                        {
                            //Hết thời gian nhập mã xác nhận
                            s = 0;
                            //Đổi mã xác nhận sang mã mới, tránh người dùng
                            //nhập mã cũ vẫn có thể đăng nhập
                            authenticCode = GenerateCode.Code();
                            DisposeTimer();
                            string message = "Mã xác nhận đã hết hạn!\nVui lòng nhấn nút gửi lại mã để nhận mã xác thực mới!";
                            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                            btnResendAuthenticCode.Visible = true;
                        }
                        else
                        {
                            m -= 1;
                            s = 59;
                        }

                    }
                    txtTimer.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                }));
            }
            catch
            {

            }
        }

        private void DisposeTimer()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void btnResendAuthenticCode_Click(object sender, EventArgs e)
        {
            btnResendAuthenticCode.Visible = false;
            authenticCode = GenerateCode.Code();

            body = SendEmailHelper.GetBodyMessage_AuthenticCode(nameRecieve, authenticCode);
            SendAuthenticCode(subject, body, emailAddress);

            MessageBox.Show("Đã gửi lại mã xác nhận!", "Thông báo", MessageBoxButtons.OK);
            StartTimeAuthenticCode();
            txtAuthenticCode.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            if (true)
            // if (txtAuthenticCode.Text == authenticCode)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã xác nhận bạn vừa nhập không chính xác!\nVui lòng thử lại", "Thông báo");
                txtAuthenticCode.Focus();
            }
        }

        private void frmCheckAuthenticCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeTimer();
        }

        private void SendAuthenticCode(string subject, string body, string recieve)
        {
            //Gửi email có mã xác nhận tới email của người đăng nhập

            try
            {
                Thread thread = new Thread(() => { SendEmailHelper.SendEmail(subject, body, recieve); })
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
    }
}
