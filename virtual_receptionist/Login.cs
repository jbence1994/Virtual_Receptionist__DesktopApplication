/* Legutóbbi fejlesztés: 2018-12-05 */

using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace JuhaszBence.CSharp.LoginValidator
{
    /// <summary>
    /// Felhasználói bejelentkezést (felhasználónév-jelszó) ellenőrző és vezérlő osztály
    /// </summary>
    public class Login
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
        public Login(string server, string database, string table, string username, string password, string port)
        {
            mySqlConnection = new MySqlConnection
            {
                ConnectionString = "SERVER =" + server + "; DATABASE=" + database + "; UID=" + username + "; PASSWORD=" + password + "; PORT=" + port + "; SslMode=None;"
            };

            mySqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM " + table,
                Connection = mySqlConnection
            };
        }

        #endregion

        #region Login validátor metódus

        /// <summary>
        /// Metódus, amely összehasonlítja a felhasználó által megadott felhasználónevet és jelszót, egyezik-e az érvényes, előre regisztrált felhasználói fiókkal
        /// </summary>
        /// <param name="username">Felhasználó által megadott felhasználónév</param>
        /// <param name="password">Felhasználó által megadott jelszó</param>
        /// <param name="usernameTableField">Felhasználónevet tartalmazó mező neve</param>
        /// <param name="passwordTableField">Jelszót tartalmazó mező neve</param>
        /// <returns>Egyezés esetén logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public bool Authentication(string username, string password, string usernameTableField, string passwordTableField)
        {
            bool validEntry = false;

            mySqlConnection.Open();
            Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

            mySqlDataReader = mySqlCommand.ExecuteReader();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen elindult...");

            while (mySqlDataReader.Read())
            {
                string validUsername = string.Empty;
                string validPassword = string.Empty;

                validUsername = mySqlDataReader[usernameTableField].ToString();
                validPassword = mySqlDataReader[passwordTableField].ToString();

                if (username == validUsername && password == validPassword)
                {
                    validEntry = true;
                    break;
                }
            }

            mySqlDataReader.Close();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");

            return validEntry;
        }

        #endregion
    }
}
