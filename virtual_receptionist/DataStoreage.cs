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
    public class DataStoreage
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
        /// <param name="table">Felhasználói fiókokat tartalmazó adatbázistábla</param>
        /// <param name="username">Adatbázis felhasználónév</param>
        /// <param name="password">Adatbázis jelszó</param>
        /// <param name="port">Adatbázis szerver elérésére szolgáló hálózati port</param>
        public DataStoreage(string server, string database, string table, string username, string password, string port)
        {
            mySqlConnection = new MySqlConnection
            {
                ConnectionString = "SERVER =" + server + "; DATABASE=" + database + "; UID=" + username + "; PASSWORD=" + password + "; PORT=" + port + "; SslMode=None;"
            };
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa az országok kódját és nevét és egy Dictionary adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött Dictionary-t adja vissza</returns>
        public Dictionary<string, string> GetCountries()
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            string countryCode = string.Empty;
            string countryName = string.Empty;

            mySqlConnection.Open();
            Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

            mySqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM countries",
                Connection = mySqlConnection
            };

            mySqlDataReader = mySqlCommand.ExecuteReader();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen elindult...");

            while (mySqlDataReader.Read())
            {
                countryCode = mySqlDataReader["Code"].ToString();
                countryName = mySqlDataReader["Name"].ToString();
            }

            countries.Add(countryCode, countryName);

            mySqlDataReader.Close();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");

            return countries;
        }

        #endregion
    }
}
