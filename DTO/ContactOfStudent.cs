using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class ContactOfStudent
    {
        private string studentCode;
        private string studentPhoneNumber;
        private string studentEmailAddress;
        private string nameOfRelativeStudent;
        private string phoneNumberOfRelativeStudent;

        public ContactOfStudent(string studentPhoneNumber, string studentEmailAddress, string nameOfRelativeStudent, string phoneNumberOfRelativeStudent)
        {
            StudentPhoneNumber = studentPhoneNumber;
            StudentEmailAddress = studentEmailAddress;
            NameOfRelativeStudent = nameOfRelativeStudent;
            PhoneNumberOfRelativeStudent = phoneNumberOfRelativeStudent;
        }

        public ContactOfStudent()
        {

        }

        public string StudentCode
        {
            get => studentCode;
            set
            {
                if (value == "")
                    throw new Exception("Không được bỏ trống mã sinh viên!");
                studentCode = value;
            }
        }
        public string StudentPhoneNumber
        {
            get => studentPhoneNumber;
            set
            {
                if (!IsValidTelephoneNumber(value))
                    throw new Exception("Số điện thoại của sinh viên không hợp lệ!");
                studentPhoneNumber = value;
            }
        }
        public string StudentEmailAddress
        {
            get => studentEmailAddress;
            set
            {
                if (!IsValidEmail(value))
                    throw new Exception("Địa chỉ email của sinh viên không hợp lệ!");
                studentEmailAddress = value;
            }
        }
        public string NameOfRelativeStudent
        {
            get => nameOfRelativeStudent;
            set
            {
                Regex regex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]");
                if (regex.IsMatch(value))
                    throw new Exception("Tên người thân sinh viên không được chứa ký tự đặc biệt!");
                nameOfRelativeStudent = value;
            }
        }
        public string PhoneNumberOfRelativeStudent { 
            get => phoneNumberOfRelativeStudent; 
            set 
            {
                if (!IsValidTelephoneNumber(value))
                    throw new Exception("Số điện thoại người thân sinh viên không hợp lệ!");

                if (value == StudentPhoneNumber)
                    throw new Exception("Số điện thoại người thân không được trùng với số điện thoại của sinh viên");
                phoneNumberOfRelativeStudent = value; 
            }
        }


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

        private bool IsValidTelephoneNumber(string telephoneNumber)
        {
            if (telephoneNumber.Length != 10)
            {
                return false;
            }

            Regex regex = new Regex(@"^0[1-9]\d{8}");
            if (!regex.IsMatch(telephoneNumber))
            {
                return false;
            }

            return true;
        }
    }
}
