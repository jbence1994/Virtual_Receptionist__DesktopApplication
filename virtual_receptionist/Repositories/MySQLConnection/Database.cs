using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.Repositories.MySQLConnection
{
    /// <summary>
    /// Adatbázis kapcsolódást, adatlekérdezés és adatmanipulációs műveleteket megvalósító egyke osztály
    /// </summary>
    public sealed class Database
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

        #endregion

        #region Konstruktor

        /// <summary>
        /// Database osztály konstruktora
        /// </summary>
        private Database()
        {
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Az egyke adatbázis kapcsolódásért felelős osztályt példányosító (getter) metódus
        /// </summary>
        /// <returns>Az egyke példánnyal tér vissza a metódus</returns>
        public static Database GetDatabaseInstance()
        {
            if (databaseInstance == null)
            {
                return databaseInstance = new Database();
            }

            return databaseInstance;
        }

        /// <summary>
        /// Metódus, amely beállítja az adatbázis kapcsolódásának a típusát
        /// </summary>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <exception cref="InvalidConnectionTypeException"></exception>
        public void SetConnection(string connectionType)
        {
            if (connectionType == "otthoni")
            {
                mySqlConnection = new MySqlConnection()
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString
                };
            }
            else if (connectionType == "iskolai")
            {
                mySqlConnection = new MySqlConnection()
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["remote"].ConnectionString
                };
            }
            else
            {
                throw new InvalidConnectionTypeException();
            }
        }

        /// <summary>
        /// Adatbázis kapcsolatot megnyitó metódus
        /// </summary>
        private void OpenConnection()
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Closed)
                {
                    mySqlConnection.Open();
                    Debug.WriteLine("Sikeres adatbázis kapcsolódás...");
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Adatbázis kapcsolatot lezáró metódus
        /// </summary>
        private void CloseConnection()
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                    Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// SELECT SQL utasítást végrehajtó metódus
        /// </summary>
        /// <param name="query">SQL utasítás</param>
        /// <returns>Adatokkal feltöltött DataTable adatszerkezettel tér vissza a metódus</returns>
        public DataTable DQL(string query)
        {
            OpenConnection();

            DataTable dataTable = new DataTable();

            try
            {
                mySqlCommand = new MySqlCommand()
                {
                    CommandText = query,
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
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }

            CloseConnection();

            return dataTable;
        }

        /// <summary>
        /// INSERT, UPDATE, DELETE SQL utasítást végrehajtó metódus
        /// </summary>
        /// <param name="query">SQL utasítás</param>
        public void DML(string query)
        {
            OpenConnection();

            try
            {
                mySqlCommand = new MySqlCommand()
                {
                    CommandText = query,
                    Connection = mySqlConnection
                };

                mySqlCommand.Prepare();
                mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }

            CloseConnection();
        }

        /// <summary>
        /// Aggregált SELECT SQL utasítást végrehajtó metódus
        /// </summary>
        /// <param name="query">SQL utasítás</param>
        /// <returns>SQL utasítás eredményét adja vissza karakterláncban</returns>
        public string ScalarDQL(string query)
        {
            string scalarQuery = string.Empty;

            OpenConnection();

            try
            {
                mySqlCommand = new MySqlCommand()
                {

                    CommandText = query,
                    Connection = mySqlConnection
                };

                mySqlCommand.Prepare();
                scalarQuery = mySqlCommand.ExecuteScalar().ToString();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }

            CloseConnection();

            return scalarQuery;
        }

        #endregion
    }
}
