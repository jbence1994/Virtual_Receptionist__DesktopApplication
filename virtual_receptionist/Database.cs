using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace virtual_receptionist.Model
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
        private static Database databaseInstace;
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
            mySqlConnection = new MySqlConnection()
            {
                ConnectionString = "SERVER=127.0.0.1; DATABASE=virtual_receptionist; UID=root; PASSWORD=\"\"; PORT=3306; SslMode=None;"
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
                if (databaseInstace == null)
                {
                    return databaseInstace = new Database();
                }
                else
                {
                    return databaseInstace;
                }
            }
        }

        #region Metódusok

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
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
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
        /// Adattábla leolvasást végző metódus
        /// </summary>
        /// <param name="sql">SQL szkript</param>
        /// <returns>Adatokkal feltöltött DataTable-el tér vissza a függvény</returns>
        public DataTable SelectQuery(string sql)
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
        /// Adatbázistáblából adattörlést végző metódus
        /// </summary>
        /// <param name="sql">SQL szkript</param>
        /// <returns></returns>
        public void DeleteQuery(string sql, string paramName, object param)
        {
            OpenConnection();

            try
            {
                mySqlCommand = new MySqlCommand()
                {
                    CommandText = sql,
                    Connection = mySqlConnection
                };

                mySqlCommand.Parameters.AddWithValue(paramName, param);
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
        /// Adattáblába adatfelvitelt végző metódus
        /// </summary>
        /// <param name="sql">SQL szkript</param>
        public void InsertQuery(string sql)
        {
            OpenConnection();

            try
            {
                mySqlCommand = new MySqlCommand()
                {
                    CommandText = sql,
                    Connection = mySqlConnection
                };

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
        /// Adattáblában adatmódosítást végző metódus
        /// </summary>
        /// <param name="sql">SQL szkript</param>
        public void UpdateQuery(string sql)
        {
            OpenConnection();

            try
            {
                mySqlCommand = new MySqlCommand()
                {
                    CommandText = sql,
                    Connection = mySqlConnection
                };

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

        #endregion
    }
}
