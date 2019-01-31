using System;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.MySQL_ORM
{
    /// <summary>
    /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke ORM osztály
    /// </summary>
    public class Database
    {
        #region Adattagok

        /// <summary>
        /// Ezen osztály egyke példánya
        /// </summary>
        private static Database databaseInstance;

        /// <summary>
        /// Adatbázis kapcsolatot létrehozó mező
        /// </summary>
        private MySqlConnection mySqlConnection;

        /// <summary>
        /// SQL utasítást vágrehajtó mező
        /// </summary>
        private MySqlCommand mySqlCommand;

        /// <summary>
        /// Adatszerkezeteket adattal feltöltő osztály egy példánya
        /// </summary>
        private MySqlDataAdapter mySqlDataAdapter;

        /// <summary>
        /// SQL DML parancsokat végrehajtó osztály egy példánya
        /// </summary>
        private MySqlCommandBuilder mySqlCommandBuilder;

        /// <summary>
        /// Adatbázis szerver neve
        /// </summary>
        private string server;

        /// <summary>
        /// Adatbázis neve
        /// </summary>
        private string database;

        /// <summary>
        /// Adatbázis szerver felhasználóneve
        /// </summary>
        private string username;

        /// <summary>
        /// Adatbázis szerver jelszava
        /// </summary>
        private string password;

        /// <summary>
        /// Adatbázis szerver elérésére szolgáló hálózati port
        /// </summary>
        private string port;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Privát konstruktor
        /// </summary>
        private Database()
        {
            server = string.Empty;
            database = string.Empty;
            username = string.Empty;
            password = string.Empty;
            port = string.Empty;

            mySqlConnection = new MySqlConnection()
            {
                ConnectionString =
                    "SERVER=127.0.0.1; DATABASE=virtual_receptionist; UID=root; PASSWORD=\"\"; PORT=3306; SslMode=None;"
            };
        }

        #endregion

        /// <summary>
        /// Ezen osztály egyke példánya
        /// </summary>
        public static Database DatabaseInstance
        {
            get
            {
                if (databaseInstance == null)
                {
                    return databaseInstance = new Database();
                }

                return databaseInstance;
            }
        }

        #region Metódusok

        /// <summary>
        /// Adatbázis kapcsolatot megnyitó metódus
        /// </summary>
        public bool OpenConnection()
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Closed)
                {
                    mySqlConnection.Open();
                    Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                    return true;
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return false;
        }

        /// <summary>
        /// Adatbázis kapcsolatot lezáró metódus
        /// </summary>
        private void CloseConnection()
        {
            if (mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
                Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            }
        }

        /// <summary>
        /// SELECT utasítást végrehajtó metódus
        /// </summary>
        /// <param name="sql">SQL utasítás</param>
        /// <returns>Adatokkal feltöltött DataTable adatszerkezettel tér vissza a metódus</returns>
        public DataTable DQL(string sql)
        {
            OpenConnection();

            DataTable dataTable = new DataTable();

            try
            {
                mySqlCommand = new MySqlCommand()
                {
                    CommandText = sql,
                    Connection = mySqlConnection
                };

                mySqlDataAdapter = new MySqlDataAdapter()
                {
                    SelectCommand = mySqlCommand
                };

                mySqlCommandBuilder = new MySqlCommandBuilder()
                {
                    DataAdapter = mySqlDataAdapter
                };

                mySqlDataAdapter.Fill(dataTable);
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            CloseConnection();

            return dataTable;
        }

        /// <summary>
        /// INSERT, UPDATE, DELETE utasítást végrehajtó metódus
        /// </summary>
        /// <param name="sql">SQL utasítás</param>
        public void DML(string sql)
        {
            OpenConnection();

            try
            {
                mySqlCommand = new MySqlCommand()
                {
                    CommandText = sql,
                    Connection = mySqlConnection
                };

                mySqlCommand.Prepare();
                mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            CloseConnection();
        }

        /// <summary>
        /// SCALAR SELECT utasítást végrehajtó metódus
        /// </summary>
        /// <param name="sql">SQL utasítás</param>
        /// <returns>SQL utasítás eredményét adja vissza</returns>
        public string DQLScalar(string sql)
        {
            string scalarQuery = string.Empty;

            OpenConnection();

            try
            {
                mySqlCommand = new MySqlCommand()
                {

                    CommandText = sql,
                    Connection = mySqlConnection
                };

                mySqlCommand.Prepare();
                scalarQuery = mySqlCommand.ExecuteScalar().ToString();
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            CloseConnection();

            return scalarQuery;
        }

        #endregion
    }
}
