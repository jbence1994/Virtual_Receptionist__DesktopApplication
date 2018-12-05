using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace virtual_receptionist
{
    /// <summary>
    /// Adattár osztály, amely az adatbázis adatait tárolja adatszerkezetekben
    /// </summary>
    public partial class DataStore
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
        /// 
        /// </summary>
        private MySqlDataAdapter mySqlDataAdapter;
        /// <summary>
        /// 
        /// </summary>
        private MySqlCommandBuilder mySqlCommandBuilder;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adattár osztály konstruktor, amelyben inicializálva van az adatbázis elérésének útvonala
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
        /// Metódus, amely adatbázisból kiolvassa az országok kódját és nevét és egy List<T> adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött List<T>-t adja vissza</returns>
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

        #endregion
    }
}
