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
    public static class Database
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
        /// Adatbázis szerver neve
        /// </summary>
        private static string _server;
        /// <summary>
        /// Adatbázis neve
        /// </summary>
        private static string _database;
        /// <summary>
        /// Adatbázis szerver felhasználóneve
        /// </summary>
        private static string _username;
        /// <summary>
        /// Adatbázis szerver jelszava
        /// </summary>
        private static string _password;
        /// <summary>
        /// Adatbázis szerver elérésére szolgáló hálózati port
        /// </summary>
        private static string _port;
        /// <summary>
        /// 
        /// </summary>
        private static string _sslMode;

        static Database()
        {
            _server = string.Empty;
            _database = string.Empty;
            _username = string.Empty;
            _password = string.Empty;
            _port = string.Empty;
            _sslMode = "None";
        }

        private static void SetConnectionServerData(string server, string database, string port, string sslMode = "None")
        {
            _server = server;
            _database = database;
            _port = port;
            _sslMode = sslMode;
        }

        private static void ConnectToDatabase()
        {
            SetConnectionServerData("192.168.0.100", "szoftverf", "3306");
            SetConnectionUserData("szoftverf", "szoftverf");
        }

        private static void SetConnectionUserData(string _username, string _password)
        {
            Database._username = _username;
            Database._password = _password;
        }

        private static string SetConnectionString()
        {
            string connectionString = "SERVER=" + _server + ";"
                                    + "DATABASE=" + _database + ";"
                                    + "UID=" + _username + ";"
                                    + "PASSWORD=" + _password + ";"
                                    + "PORT=" + _port + ";"
                                    + "SSLMode  =" + _sslMode + ";";

            return connectionString;
        }

        public static bool MakeConnectionToDatabase()
        {
            string connectionString = SetConnectionString();

            try
            {
                mySqlConnection = new MySqlConnection()
                {
                    ConnectionString = connectionString
                };

                return true;
            }
            catch (MySqlException)
            { }

            return true;

        }

        public static bool Open()
        {
            if ((mySqlConnection != null) && (mySqlConnection.State == ConnectionState.Open))
            {
                return true;
            }
            else
            {
                try
                {
                    mySqlConnection.Open();
                    return true;
                }
                catch (MySqlException)
                { }

                mySqlConnection = null;
                return false;
            }
        }

        public static bool Close()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public static DataTable GetToDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            if (mySqlConnection.State != ConnectionState.Open)
            {
                return dataTable;
            }

            try
            {
                mySqlCommand = new MySqlCommand()
                {
                    CommandText = query,
                    Connection = mySqlConnection
                };

                if (mySqlCommand == null)
                {
                    return dataTable;
                }

                mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.Fill(dataTable);

            }
            catch (MySqlException)
            { }
            finally
            { }

            return dataTable;
        }

        public static void ExecuteDMQuery(string query)
        {
            if (mySqlConnection.State != ConnectionState.Open)
            {
                return;
            }

            MySqlCommand cmd;

            try
            {
                cmd = new MySqlCommand(query, mySqlConnection);
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
                mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
                mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();
                mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
                mySqlDataAdapter.Update(dataTable);
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
        }
    }
}
