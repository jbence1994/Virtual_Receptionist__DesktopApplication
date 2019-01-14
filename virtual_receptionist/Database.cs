using System.Xml;
using System.Collections.Generic;
using System.Data;
using System;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Adatbázis műveleteket és interakciókat végző ORM osztály
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Adatbázis kapcsolatot létrehozó mező
        /// </summary>
        private static MySqlConnection mySqlConnection;
        /// <summary>
        /// SQL utasítást vágrehajtó mező
        /// </summary>
        private static MySqlCommand mySqlCommand;
        /// <summary>
        /// Adatbázis adatot olvasó mező
        /// </summary>
        private static MySqlDataReader mySqlDataReader;
        /// <summary>
        /// Adatszerkezeteket adattal feltöltő osztály egy példánya
        /// </summary>
        private static MySqlDataAdapter mySqlDataAdapter;
        /// <summary>
        /// SQL DML és DDL parancsokat egyszerűen végrehajtó osztály egy példánya
        /// </summary>
        private static MySqlCommandBuilder mySqlCommandBuilder;

        /// <summary>
        /// Adatbázis műveleteket és interakciókat végző ORM osztály statikus konstruktora
        /// </summary>
        public Database()
        {
            if (true)
            {
                mySqlConnection = new MySqlConnection()
                {
                    ConnectionString = ""
                };
            }
            else
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        private static void SetConnectionString()
        {

        }



    }

    static class MySQLDatabaseInterface
    {
        private static MySqlConnection connection;
        private static MySqlDataAdapter dataAdapter;
        private static MySqlCommandBuilder commandBuilder;

        private static string server;
        private static string database;
        private static string username;
        private static string password;
        private static string port;
        private static string sslMode;

        static MySQLDatabaseInterface()
        {
            server = string.Empty;
            database = string.Empty;
            username = string.Empty;
            password = string.Empty;
            port = string.Empty;
            sslMode = "None";
        }

        private static void SetConnectionServerData(string _server, string _database, string _port, string _sslMode = "None")
        {
            server = _server;
            database = _database;
            port = _port;
            sslMode = _sslMode;
        }

        private static void ConnectToDatabase()
        {
            SetConnectionServerData("192.168.0.100", "szoftverf", "3306");
            SetConnectionUserData("szoftverf", "szoftverf");
        }

        private static void SetConnectionUserData(string _username, string _password)
        {
            username = _username;
            password = _password;
        }

        public static bool MakeConnectionToDatabase()
        {
            string connectionString = "SERVER=" + server + ";"
                                    + "DATABASE=" + database + ";"
                                    + "UID=" + username + ";"
                                    + "PASSWORD=" + password + ";"
                                    + "PORT=" + port + ";"
                                    + "SSLMode  =" + sslMode + ";";
            try
            {
                connection = new MySqlConnection(connectionString);
                return true;
            }
            catch (MySqlException)
            { }

            return true;

        }

        public static bool Open()
        {
            if ((connection != null) && (connection.State == ConnectionState.Open))
            {
                return true;
            }
            else
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException)
                { }

                connection = null;
                return false;
            }
        }

        public static bool Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public static bool IsExecutableQuery(string query)
        {
            if (query == string.Empty)
            {
                return false;
            }

            return true;
        }

        public static DataTable GetToDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            if (connection.State != ConnectionState.Open)
            {
                return dataTable;
            }

            if (!IsExecutableQuery(query))
            {
                return dataTable;
            }

            MySqlCommand cmd;

            try
            {
                cmd = new MySqlCommand(query, connection);
                if (cmd == null)
                {
                    return dataTable;
                }

                dataAdapter = new MySqlDataAdapter(cmd);
                commandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataTable);

            }
            catch (MySqlException)
            { }
            finally
            { }

            return dataTable;
        }

        public static void ExecuteDMQuery(string query)
        {
            if (connection.State != ConnectionState.Open)
            {
                return;
            }

            if (!IsExecutableQuery(query))
            {
                return;
            }

            MySqlCommand cmd;

            try
            {
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            { }
            finally
            { }
        }

        public static void UpdateDataTable(DataTable dataTable)
        {
            try
            {
                dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
                dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                dataAdapter.Update(dataTable);
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
        }
    }
}
