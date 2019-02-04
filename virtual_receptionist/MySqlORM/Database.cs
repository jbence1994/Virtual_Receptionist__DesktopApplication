using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace MySQL_ORM
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
        /// Helyi szerver elérési útja
        /// </summary>
        private string localConnection;

        /// <summary>
        /// Távoli szerver elérési útja
        /// </summary>
        private string remoteConnection;

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
        /// Privát konstruktor
        /// </summary>
        private Database()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok

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

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely beállítja az adatbázis kapcsolódásának a típusát (otthoni, iskolai)
        /// </summary>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <exception cref="Exception"></exception>
        public void SetConnection(string connectionType)
        {
            localConnection = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
            remoteConnection = ConfigurationManager.ConnectionStrings["remote"].ConnectionString;

            Debug.WriteLine(localConnection);
            Debug.WriteLine(remoteConnection);

            if (connectionType == "otthoni")
            {
                mySqlConnection = new MySqlConnection()
                {
                    ConnectionString = localConnection
                };
            }
            else if (connectionType == "iskolai")
            {
                mySqlConnection = new MySqlConnection()
                {
                    ConnectionString = remoteConnection
                };
            }
            else
            {
                throw new Exception("Adatbázis kapcsolat típusa érvénytelen!");
            }
        }

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
        /// <returns>SQL utasítás eredményét adja vissza karakterláncban</returns>
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
