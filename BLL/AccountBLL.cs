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
    public class AccountBLL
    {
        
        public static bool InsertAccount(Account account)
        {
            if(!IsValidAccount(account))
            {
                return false;
            }
            string username = CeasarHelper.Encrypt(account.Username, 2);
            string password = CeasarHelper.Encrypt(account.Password, 9);
            string displayName = MD5Helper.Encrypt(account.Displayname, 3);
            string email = MD5Helper.Encrypt(account.Email, 8);
            string type = DonBangHelper.Encrypt(account.Type, 5);
            return AccountDAL.InsertAccount(username, password, displayName, email, type) > 0;
        }

        private static bool IsValidAccount(Account account)
        {
            if (!IsValidUsername(account.Username))
            {
                throw new Exception("Tên tài khoản đã được sử dụng!");
            }
            if (!IsValidEmail(account.Email))
            {
                throw new Exception("Địa chỉ email đã được sử dụng!");
            }
            return true;
        }

        private static bool IsValidEmail(string email)
        {
            var listAccount = GetAllAccount();
            foreach (Account account in listAccount)
            {
                if (account.Email.ToUpper().Equals(email.ToUpper()))
                    return false;
            }
            return true;
        }

        private static bool IsValidUsername(string username)
        {
            var listAccount = GetAllAccount();
            foreach (Account account in listAccount)
            {
                if (account.Username == username)
                    return false;
            }
            return true;
        }

        public static Account GetAccountByUsername_Password(string username, string password)
        {
            SqlDataReader data = AccountDAL.GetAccountByUsername_Password
                (CeasarHelper.Encrypt(username, 2), CeasarHelper.Encrypt(password, 9));
            
            Account account = new Account();
            while (data.Read())
            {
                account.Username = CeasarHelper.Decrypt(data.GetString(0), 2);
                account.Password = CeasarHelper.Decrypt(data.GetString(1), 9);
                account.Displayname = MD5Helper.Decrypt(data.GetString(2), 3);
                account.Email = MD5Helper.Decrypt(data.GetString(3), 8);
                account.Type = DonBangHelper.Decrypt(data.GetString(4), 5);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return account;
        }

        public static List<Account> GetAllAccount()
        {
            SqlDataReader data = AccountDAL.GetAllAccount();

            List<Account> listAccount = new List<Account>();
            while (data.Read())
            {
                Account account = new Account();
                account.Username = CeasarHelper.Decrypt(data.GetString(0), 2);
                account.Password = "Password Covered!";
                account.Displayname = MD5Helper.Decrypt(data.GetString(2), 3);
                account.Email = MD5Helper.Decrypt(data.GetString(3), 8);
                account.Type = DonBangHelper.Decrypt(data.GetString(4), 5);
                listAccount.Add(account);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return listAccount;
        }

        public static Account GetAccountByUsername(string username)
        {
            SqlDataReader data = AccountDAL.GetAccountByUsername(CeasarHelper.Encrypt(username, 2));

            Account account = new Account();
            while (data.Read())
            {
                account.Username = CeasarHelper.Decrypt(data.GetString(0), 2);
                account.Password = CeasarHelper.Decrypt(data.GetString(1), 9);
                account.Displayname = MD5Helper.Decrypt(data.GetString(2), 3);
                account.Email = MD5Helper.Decrypt(data.GetString(3), 8);
                account.Type = DonBangHelper.Decrypt(data.GetString(4), 5);
            }
            DataProvider.Instance.DisposeSqlDataReader();
            DataProvider.Instance.Disconnect();
            data.Close();
            data = null;
            return account;
        }

        public static bool ChangeDisplayNameAccount(string _username, string _displayName)
        {
            string username = CeasarHelper.Encrypt(_username, 2);
            string displayName = MD5Helper.Encrypt(_displayName, 3);
            return AccountDAL.ChangeDisplayNameAccount(username, displayName) > 0;
        }

        public static bool ChangePassordAccount(string _username, string _password, string _displayName)
        {
            string username = CeasarHelper.Encrypt(_username, 2);
            string password = CeasarHelper.Encrypt(_password, 9);
            string displayName = MD5Helper.Encrypt(_displayName, 3);
            return AccountDAL.ChangePassWordAccount(username, password, displayName) > 0;
        }

        public static bool DeleteAccount(string userName)
        {
            string UserName = CeasarHelper.Encrypt(userName, 2);
            return AccountDAL.DeleteAccount(UserName) > 0;
        }

        public static bool ModifyAccount(Account account)
        {
            string username = CeasarHelper.Encrypt(account.Username, 2);
            string password = CeasarHelper.Encrypt(account.Password, 9);
            string displayName = MD5Helper.Encrypt(account.Displayname, 3);
            string email = MD5Helper.Encrypt(account.Email, 8);
            string type = DonBangHelper.Encrypt(account.Type, 5);
            return AccountDAL.ModifyAccount(username, password, displayName, email, type) > 0;
        }
    }
}
