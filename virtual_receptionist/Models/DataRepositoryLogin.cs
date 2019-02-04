using System;
using System.Diagnostics;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        #endregion

        #region Bejelentkezési folyamatot ellenőrző és vezérlő metódus

        /// <summary>
        /// Metódus, amely összehasonlítja a felhasználó által megadott felhasználónevet és jelszót, egyezik-e az érvényes, előre regisztrált felhasználói fiókkal
        /// </summary>
        /// <param name="accomodationID">Szálláshely azonosító</param>
        /// <param name="password">Regisztrációhoz tartozó jelszó</param>
        /// <returns>Egyezés esetén logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public bool Authentication(string accomodationID, string password, string connectionType)
        {
            string sql = "SELECT AccomodationID, Password FROM accomodation";
            database.SetConnection(connectionType);
            database.DQL(sql);

            return true;
        }

        #endregion
    }
}
