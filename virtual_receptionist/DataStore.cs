using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace virtual_receptionist
{
    /// <summary>
    /// Adattár osztály, amely az adatbázis adatait tárolja egyes adatszerkezetekben
    /// </summary>
    public class DataStore
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolatot létrehozó mező
        /// </summary>
        private readonly MySqlConnection mySqlConnection;

        /// <summary>
        /// SQL utasítást vágrehajtó mező
        /// </summary>
        private MySqlCommand mySqlCommand;

        /// <summary>
        /// Adatbázis adatot olvasó mező
        /// </summary>
        private MySqlDataReader mySqlDataReader;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="server">Adatbázist tároló szerver neve</param>
        /// <param name="database">Adatbázis neve</param>
        /// <param name="username">Adatbázis felhasználónév</param>
        /// <param name="password">Adatbázis jelszó</param>
        /// <param name="port">Adatbázis szerver elérésére szolgáló hálózati port</param>
        public DataStore(string server, string database, string username, string password, string port)
        {
            mySqlConnection = new MySqlConnection
            {
                ConnectionString = "SERVER =" + server + "; DATABASE=" + database + "; UID=" + username + "; PASSWORD=" + password + "; PORT=" + port + "; SslMode=None;"
            };
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa az országok kódját és nevét és egy lista adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött listát adja vissza</returns>
        public List<string> GetCountries() // <= UNIT TEST !!!
        {
            List<string> countries = new List<string>();

            string countryName = string.Empty;

            mySqlConnection.Open();
            Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

            mySqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM country",
                Connection = mySqlConnection
            };

            mySqlDataReader = mySqlCommand.ExecuteReader();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen elindult...");

            while (mySqlDataReader.Read())
            {
                countryName = mySqlDataReader["Name"].ToString();
                countries.Add(countryName);
            }

            mySqlDataReader.Close();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");

            return countries;
        }
        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a számlázási tételeket és egy lista adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött listát adja vissza</returns>
        public List<string> GetBillingItems() //<= UNIT TEST !!!
        {
            List<string> billingItems = new List<string>();

            return billingItems;
        }

        #endregion
    }
}
