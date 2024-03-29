using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace testLogin
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=DESKTOP-UC0QD5C\QUANGVINH;Initial Catalog=Vchat;Integrated Security=True";
        private static SqlConnection connection;

        // Phương thức để mở kết nối đến cơ sở dữ liệu
        public static SqlConnection OpenConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi mở kết nối: " + ex.Message);
            }

            return connection;
        }

        // Phương thức để đóng kết nối đến cơ sở dữ liệu
        public static void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

    }
}
