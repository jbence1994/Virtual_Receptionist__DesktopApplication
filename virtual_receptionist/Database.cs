using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Xml;
using System.Diagnostics;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító osztály
    /// </summary>
    public class Database
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolatot létrehozó mező
        /// </summary>
        private MySqlConnection mySqlConnection;
        /// <summary>
        /// SQL utasítást vágrehajtó mező
        /// </summary>
        private MySqlCommand mySqlCommand;
        /// <summary>
        /// Adatbázis adatot olvasó mező
        /// </summary>
        private MySqlDataReader mySqlDataReader;
        /// <summary>
        /// Adatszerkezeteket adattal feltöltő osztály egy példánya
        /// </summary>
        private MySqlDataAdapter mySqlDataAdapter;
        /// <summary>
        /// SQL DML és DDL parancsokat végrehajtó osztály egy példánya
        /// </summary>
        private MySqlCommandBuilder mySqlCommandBuilder;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Database()
        {
            mySqlConnection = new MySqlConnection()
            {
                ConnectionString = $"SERVER=127.0.0.1;DATABASE=virtual_receptionist;UID=root;PASSWORD=;PORT=3306"
            };
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// 
        /// </summary>
        private void InitializeConnection()
        {

        }
        /// <summary>
        /// Adatbázis kapcsolatot megnyitó metódus
        /// </summary>
        public void OpenConnection()
        {
            mySqlConnection.Open();
            Debug.WriteLine("Sikeres adatbázis kapcsolódás...");
        }
        /// <summary>
        /// Adatbázis kapcsolatot lezáró metódus
        /// </summary>
        public void CloseConnection()
        {
            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
        }

        #endregion
    }
}
