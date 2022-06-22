using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SendEmailHelper
    {

        /// <summary>
        /// Tạo tiêu đề của email gửi đi 
        /// </summary>
        /// <returns>Tiêu đề email gửi đi</returns>
        public static string GetSubjectEmail_AuthenticCode()
        {
            return "Mã xác nhận của bạn tại chương trình Quản lý sinh viên.";
        }

        public static string GetSubjectEmail_ForgetPassword()
        {
            return "Mật khẩu của bạn tại chương trình Quản lý sinh viên.";
        }

        public static string GetEmaiAddresslWithLessInfo(string emailAddress)
        {
            int indName = emailAddress.IndexOf("@");
            if (indName == -1)
            {
                return "";
            }    
            string emailName = emailAddress.Substring(0, indName);


            int lengthDomainName = emailAddress.Length - indName - 1;
            string domainName = emailAddress.Substring(indName + 1, lengthDomainName);
            string emailWithLessInfo = "";
            for (int i = 0; i < emailName.Length; i++)
            {
                if (i == 0 || i == 1 || i == emailName.Length - 1)
                    emailWithLessInfo += emailName[i];
                else
                    emailWithLessInfo += "*";
            }
            emailWithLessInfo += "@";
            for (int i = 0; i < lengthDomainName; i++)
            {
                if (i == 0 || i == lengthDomainName - 1 || i == lengthDomainName - 2)
                    emailWithLessInfo += domainName[i];
                else
                    emailWithLessInfo += "*";
            }
            return emailWithLessInfo;
        }


        /// <summary>
        /// Tạo nội dung email để gửi đi
        /// </summary>
        /// <param name="nameRecieve">Tên người nhận email</param>
        /// <param name="authenticCode">Mã xác nhận</param>
        /// <returns>Nội dung email gửi đi</returns>
        public static string GetBodyMessage_AuthenticCode(string nameRecieve, string authenticCode)
        {
            string body = $"Xin chào {nameRecieve}!" + Environment.NewLine;
            body += "Vui lòng nhập mã xác nhận sau để đăng nhập chương trình Quản lý sinh viên:" + Environment.NewLine;
            body += $"{authenticCode}" + Environment.NewLine;
            body += "Chú ý: mã có phân biệt chữ hoa, chữ thường." + Environment.NewLine;
            body += "Copy mã rồi dán để tránh xảy ra sai xót!" + Environment.NewLine;
            body += "Trân trọng!" + Environment.NewLine;
            body += CeasarHelper.Decrypt(Properties.Resources.Author, 9) + Environment.NewLine;
            body += "Nếu có góp ý, thắc mắc hãy liên hệ với tôi qua địa chỉ: Mtuongpk@gmail.com\n";
            body += "Tôi rất mong muốn được lắng nghe những ý kiến đóng góp của Quý khách!";
            return body;
        }


        public static string GetBodyMessage_ForgetPassword(string nameRecieve, string password, string localName, string publicIPAddr)
        {
            string body = $"Xin chào {nameRecieve}!" + Environment.NewLine;
            body += $"Tôi vừa nhận được yêu cầu lấy lại mật khẩu ";
            body += $"từ thiết bị: {localName} có địa chỉ IP: {publicIPAddr}" + Environment.NewLine;
            body += "Nếu đó không phải là bạn, hãy đổi mật khẩu để" +
                " tăng cường bảo mật cho tài khoản của bạn!" + Environment.NewLine;
            body += $"Mật khẩu của bạn là: {password}" + Environment.NewLine;
            body += "Hãy bảo mật thông tin này cẩn thận!" + Environment.NewLine;
            body += "Thay đổi mật khẩu ngay khi vào chương trình Quản lý sinh viên!\n";
            body += "Trân trọng!" + Environment.NewLine;
            body += CeasarHelper.Decrypt(Properties.Resources.Author, 9) + Environment.NewLine;
            body += "Nếu có góp ý, thắc mắc hãy liên hệ với tôi qua địa chỉ: Mtuongpk@gmail.com\n";
            body += "Tôi rất mong muốn được lắng nghe những ý kiến đóng góp của Quý khách!";
            return body;
        }


        /// <summary>
        /// Hàm gửi email sử dụng Smtp Client
        /// </summary>
        /// <param name="subject">Tiêu đề email</param>
        /// <param name="body">Nội dung email</param>
        /// <param name="reciever">Địa chỉ email của người nhận</param>
        /// <returns>True: Gửi thành công || False: Gửi thất bại</returns>
        public static bool SendEmail(string subject, string body, string reciever)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                string username = DaBangHelper.Decrypt(Properties.Resources.UsernameGmail, 8);
                string password = MD5Helper.Decrypt(Properties.Resources.PasswordGmail, 2);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(username, password);
                MailMessage msgObj = new MailMessage();
                msgObj.To.Add(reciever);
                msgObj.From = new MailAddress(username);
                msgObj.Subject = subject;
                msgObj.Body = body;
                try
                {
                    client.Send(msgObj);
                    return true;
                }
                catch
                {
                    string message = "Đã có lỗi xảy ra!\n" +
                        "Không gửi được mã xác nhận!\n" +
                        "Liên hệ nhà phát triển qua địa chỉ: " +
                        "Mtuongpk@gmail.com để được cung cấp thêm thông tin!";
                    throw new Exception(message);
                }

            }
        }
    }
}
