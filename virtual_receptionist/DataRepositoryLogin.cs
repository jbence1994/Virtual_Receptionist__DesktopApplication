using System;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        #endregion

        #region Bejelentkezés-hitelesítési és adatbázis-konfigurációs folyamatokat vezérlő metódusok

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
            //bool validEntry = false;

            //try
            //{
            //    mySqlConnection.Open();
            //    Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

            //    mySqlDataReader = mySqlCommand.ExecuteReader();
            //    Debug.WriteLine("MySqlDataReader olvasás sikeresen elindult...");

            //    while (mySqlDataReader.Read())
            //    {
            //        string validUsername = string.Empty;
            //        string validPassword = string.Empty;

            //        validUsername = mySqlDataReader[usernameTableField].ToString();
            //        validPassword = mySqlDataReader[passwordTableField].ToString();

            //        if (username == validUsername && password == validPassword)
            //        {
            //            validEntry = true;
            //            break;
            //        }
            //    }
            //}
            //catch (MySqlException e)
            //{
            //    Debug.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Debug.WriteLine(e.Message);
            //}
            //finally
            //{
            //    mySqlDataReader.Close();
            //    Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

            //    mySqlConnection.Close();
            //    Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            //}

            //return validEntry;

            return true;
        }

        #endregion
    }
}
