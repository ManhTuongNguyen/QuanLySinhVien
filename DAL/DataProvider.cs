using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataProvider
    {
        //Lấy connection string từ resource và giải mã
        private readonly string connectionString = MyEncryptHelper.Decrypt(Properties.Resources.ConnectionString);
        
        //SingleTon
        private static DataProvider instance;

        public static DataProvider Instance {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            set => instance = value;
        }

        private DataProvider()
        {

        }

        private SqlDataReader reader;

        public void DisposeSqlDataReader()
        {
            reader.Close();
            reader = null;
        }

        private SqlConnection Connection = null;

        /// <summary>
        /// Mở kết nối đến database
        /// </summary>
        public void Connect()
        {
            if (Connection == null)
            {
                Connection = new SqlConnection(connectionString);
            }
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }


        /// <summary>
        /// Ngắt kết nối đến database
        /// </summary>
        public void Disconnect()
        {
            if (Connection.State == ConnectionState.Open || Connection != null)
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Thực thi câu lệnh ExecuteQuery, kết quả trả về SqlDataReader
        /// </summary>
        /// <param name="query">query</param>
        /// <param name="para">tham số truyền vào query</param>
        /// <returns>SqlDataReader chứa thông tin trả về của câu truy vấn query</returns>
        public SqlDataReader ExecuteQuery(string query, object[] para = null)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            Connect();
            SqlCommand command = new SqlCommand(query, Connection);

            if (para != null)
            {
                //Nếu query có tham số
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, para[i]);
                        i++;
                    }
                }
            }

            reader = command.ExecuteReader();
            return reader;
            //Gọi hàm đóng kết nối sau khi gọi xong hàm này!
        }

        /// <summary>
        /// Thực thi câu lệnh ExcuteQuery
        /// </summary>
        /// <param name="query">query</param>
        /// <param name="para">tham số truyền vào query</param>
        /// <returns>Số lượng bản ghi đã thao tác thành công</returns>
        public int ExecuteNonQuery(string query, object[] para = null)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            Connect();
            SqlCommand command = new SqlCommand(query, Connection);

            if (para != null)
            {
                //Nếu query có tham số
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, para[i]);
                        i++;
                    }
                }
            }

            int ketQua = command.ExecuteNonQuery();

            Disconnect();

            return ketQua;
        }

        /// <summary>
        /// Thực thi câu lệnh ExcuteScalar
        /// </summary>
        /// <param name="query">query</param>
        /// <param name="para">tham số truyền vào query</param>
        /// <returns>Đối tượng dòng đầu tiên, cột đầu tiên </returns>
        public object ExecuteScalar(string query, object[] para = null)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            Connect();
            SqlCommand command = new SqlCommand(query, Connection);

            if (para != null)
            {
                //Nếu query có tham số
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, para[i]);
                        i++;
                    }
                }
            }

            object data = command.ExecuteScalar();

            Disconnect();

            return data;
        }
    }
}
