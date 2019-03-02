using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.Model.DatabaseConnection
{
    /// <summary>
    /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke osztály
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

        #region Getter tulajdonságok

        /// <summary>
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke osztály példánya
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
        /// Metódus, amely beállítja az adatbázis kapcsolódásának a típusát
        /// </summary>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <exception cref="InvalidConnectionTypeException"></exception>
        public void SetConnection(string connectionType)
        {
            localConnection = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
            remoteConnection = ConfigurationManager.ConnectionStrings["remote"].ConnectionString;

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
                throw new InvalidConnectionTypeException();
            }
        }

        /// <summary>
        /// Adatbázis kapcsolatot megnyitó metódus
        /// </summary>
        /// <returns>Amennyiben sikeres az adatbázis elérés logikai igazzal, ellenkező esetben logikai hamissal tér vissza a függvény</returns>
        private bool OpenConnection()
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
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
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
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
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
