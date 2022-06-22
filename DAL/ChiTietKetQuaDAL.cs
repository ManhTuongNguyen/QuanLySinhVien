using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietKetQuaDAL
    {
        public static SqlDataReader GetAllKetQuaDetail()
        {
            string query = "exec USP_GetAllDiem";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
