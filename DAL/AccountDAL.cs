using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        public static int InsertAccount(string username, string password, string displayname, string email, string type)
        {
            string query = "INSERT INTO [dbo].[Account] ([Username] ,[Password] ,[DisplayName] ,[Email] ,[Type]) VALUES ";
            query += $"(N'{username}', N'{password}', N'{displayname}', N'{email}', N'{type}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetAccountByUsername_Password(string username, string password)
        {
            string query = "SELECT [Username], [Password], [DisplayName], [Email], [Type] FROM[dbo].[Account] ";
            query += $"WHERE Username = N'{username}' and Password = N'{password}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static SqlDataReader GetAccountByUsername(string username)
        {
            string query = "SELECT [Username], [Password], [DisplayName], [Email], [Type] FROM[dbo].[Account] ";
            query += $"WHERE Username = N'{username}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public static int ChangeDisplayNameAccount(string username, string displayname)
        {
            string query = $"UPDATE [dbo].[Account] SET [DisplayName] = N'{displayname}' ";
            query += $" where [Username] = N'{username}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int ChangePassWordAccount(string username, string password, string displayname)
        {
            string query = $"UPDATE [dbo].[Account] SET [DisplayName] = N'{displayname}' , [Password] = N'{password}'";
            query += $" where [Username] = N'{username}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static SqlDataReader GetAllAccount()
        {
            string query = "SELECT [Username], [Password], [DisplayName], [Email], [Type] FROM[dbo].[Account]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int DeleteAccount(string userName)
        {
            string query = "DELETE FROM[dbo].[Account] WHERE ";
            query += $"[Username] = N'{userName}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int ModifyAccount(string username, string password, string displayName, string email, string type)
        {
            string query = $"UPDATE [dbo].[Account] SET [DisplayName] = N'{displayName}' , [Password] = N'{password}' , ";
            query += $"[Email] = N'{email}' , [Type] = N'{type}' ";
            query += $" where [Username] = N'{username}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
