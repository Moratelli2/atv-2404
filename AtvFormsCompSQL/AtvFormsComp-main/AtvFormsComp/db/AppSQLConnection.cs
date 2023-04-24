using System.Data.SqlClient;

namespace AtvFormsComp.db
{
    class AppSQLConnection
    {
        private static string connectionString = @"Server=localhost;Database=dbAulaAtv7;Trusted_Connection=True;AttachDbFileName=D:\bancoAula\dbAulaAtv7.mdf;";

        private static SqlConnection conn = null;

        public static SqlConnection GetConnection()
        {
            if (conn == null)
                conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }


    }
}
