using System.Data;
using Npgsql;

namespace Arkanoid
{
    public static class ConnectionDB
    {
        private static string
            host = "127.0.0.1",
            database = "ProyectoFinal",
            userID = "postgres",
            password = "uca";

        private static string sConnection = $"Host={host};Port = 5432; User Id = {userID}; " +
                                            $"Password={password};Database={database};";
        
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(action, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}