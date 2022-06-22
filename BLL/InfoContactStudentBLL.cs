using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InfoContactStudentBLL
    {
        public static bool InsertContactStudent(ContactOfStudent contactOfStudent)
        {
            string maSV = CeasarHelper.Encrypt(contactOfStudent.StudentCode, 2);
            string SDTSV = DaBangHelper.Encrypt(contactOfStudent.StudentPhoneNumber, 9);
            string emailSV = MD5Helper.Encrypt(contactOfStudent.StudentEmailAddress, 2);
            string tenNguoiThan = MD5Helper.Encrypt(contactOfStudent.NameOfRelativeStudent, 5);
            string SDTNguoiThan = DonBangHelper.Encrypt(contactOfStudent.PhoneNumberOfRelativeStudent, 1);

            return InfoContactStudentDAL.InsertContactStudent(maSV, SDTSV, emailSV, tenNguoiThan, SDTNguoiThan) > 0;
        }

        public static List<ContactOfStudent> GetAllContactOfStudent()
        {
            SqlDataReader data = InfoContactStudentDAL.GetAllContactStudent();
            List<ContactOfStudent> listContactOfStudent = new List<ContactOfStudent>();
            while (data.Read())
            {
                ContactOfStudent contact = new ContactOfStudent()
                {
                    StudentCode = CeasarHelper.Decrypt(data.GetString(0), 2),
                    StudentPhoneNumber = DaBangHelper.Decrypt(data.GetString(1), 9),
                    StudentEmailAddress = MD5Helper.Decrypt(data.GetString(2), 2),
                    NameOfRelativeStudent = MD5Helper.Decrypt(data.GetString(3), 5),
                    PhoneNumberOfRelativeStudent = DonBangHelper.Decrypt(data.GetString(4), 1),
                };
                listContactOfStudent.Add(contact);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listContactOfStudent;
        }

        public static ContactOfStudent GetContactStudentByStudentCode(string _maSV)
        {
            string maSV = CeasarHelper.Encrypt(_maSV, 2);
            SqlDataReader data = InfoContactStudentDAL.GetContactStudentByStudentCode(maSV);
            ContactOfStudent contact = new ContactOfStudent();
            while (data.Read())
            {
                contact = new ContactOfStudent()
                {
                    StudentCode = CeasarHelper.Decrypt(data.GetString(0), 2),
                    StudentPhoneNumber = DaBangHelper.Decrypt(data.GetString(1), 9),
                    StudentEmailAddress = MD5Helper.Decrypt(data.GetString(2), 2),
                    NameOfRelativeStudent = MD5Helper.Decrypt(data.GetString(3), 5),
                    PhoneNumberOfRelativeStudent = DonBangHelper.Decrypt(data.GetString(4), 1),
                };
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            return contact;
        }

        public static bool DeleteContactByStudentCode(string maSinhVien)
        {
            string MSV = CeasarHelper.Encrypt(maSinhVien, 2);
            return InfoContactStudentDAL.DeleteContactByStudentCode(MSV) > 0;
        }

        public static bool ModifyInfoContactStudent(ContactOfStudent contactOfStudent)
        {
            string maSV = CeasarHelper.Encrypt(contactOfStudent.StudentCode, 2);
            string SDTSV = DaBangHelper.Encrypt(contactOfStudent.StudentPhoneNumber, 9);
            string emailSV = MD5Helper.Encrypt(contactOfStudent.StudentEmailAddress, 2);
            string tenNguoiThan = MD5Helper.Encrypt(contactOfStudent.NameOfRelativeStudent, 5);
            string SDTNguoiThan = DonBangHelper.Encrypt(contactOfStudent.PhoneNumberOfRelativeStudent, 1);

            return InfoContactStudentDAL.ModifyContactStudent(maSV, SDTSV, emailSV, tenNguoiThan, SDTNguoiThan) > 0;
        }
    }
}
