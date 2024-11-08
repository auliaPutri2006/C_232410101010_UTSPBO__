using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C_232410101010_utspbo.app.core
{
    internal class DataWrapper
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "UTSPBO";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "12345678";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        public static void CloseConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        public static void OpenConenction()
        {
            connection = new NpgsqlConnection($"Host = {DB_HOST},Username = {DB_USERNAME},Database = {DB_DATABASE},Password = {DB_PASSWORD},Port = {DB_PORT}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }

        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                OpenConenction();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                CloseConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }
        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                OpenConenction();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.Prepare();
                command.Parameters.Clear();
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }
    }
}
