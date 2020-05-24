using System;
using System.Data;
using Npgsql;

namespace Pre_Parcial
{
    public static class ConectionBD
    {
        private static string host = "ec2-18-210-214-86.compute-1.amazonaws.com",
            database = "d2lq0tl3e2p9lr",
            userId = "butdbzgsxtaaae",
            password = "d4924be108473ad54135ed4db8537bd64c11042d8a07ae32b3bb9d20eb4a267d";

        private static string sConection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};" +
            "sslmode=Require;Trust Server Certificate=true";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection conection = new NpgsqlConnection(sConection);
            DataSet ds = new DataSet();
            conection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conection);
            da.Fill(ds);
            conection.Close();
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConection);
            connection.Open();
            NpgsqlCommand com = new NpgsqlCommand(act, connection);
            com.ExecuteNonQuery();
            connection.Close();
        }
    }
}