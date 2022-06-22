using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string displayname;
        private string email;
        private string type;

        public Account()
        {

        }

        public Account(string username, string password, string displayname, string email, string type)
        {
            Username = username;
            Password = password;
            Displayname = displayname;
            Email = email;
            Type = type;
        }

        public string Username
        {
            get => username;
            set
            {
                if (value.Length < 4)
                    throw new Exception("Tên tài khoản phải có số ký tự lớn hơn 3!");
                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]");
                if (regex.IsMatch(value))
                    throw new Exception("Tên tài khoản không được chứa ký tự đặc biệt!");
                username = value;
            }
        }
        public string Password
        {
            get => password;
            set 
            {
                if (value == String.Empty)
                    throw new Exception("Password không được bỏ trống!");
                password = value;
            }
        }
        public string Displayname
        {
            get => displayname;
            set
            {
                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]");
                if (regex.IsMatch(value))
                    throw new Exception("Tên hiển thị không được chứa ký tự đặc biệt!");
                displayname = value;
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (!IsValidEmail(value))
                    throw new Exception("Địa chỉ email không hợp lệ!");
                email = value;
            }
        }
        public string Type { get => type; set => type = value; }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return email == addr.Address;
            }
            catch
            {
                return false;
            }
        }
    }
}
