using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CourierDatabaseConnection.ConnectionUtil
{
    internal class DBConnection
    {
        static readonly string connectionString = @"Server =BOOMIKA\SQLEXPRESS ; Database =Courier  ; Integrated Security =True ; MultipleActiveResultSets=true;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void CloseConnection(SqlConnection conn)
        {
            if (conn != null)
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                        Console.WriteLine("Connection Closed");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Connection is already null");
                }
            }


        }
    }
}
