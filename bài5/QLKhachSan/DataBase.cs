using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLKhachSanVui
{
    class DataBase
    {
        private const string connectionString = "Data Source=KYO;Initial Catalog=QLKhachSan;Integrated Security=True";
        private static SqlConnection conn;
        public static bool Connect()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static SqlConnection GetConnection()
        {
            if (conn == null)
                Connect();
            return conn;
        }

        public static void Disconect()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
