using System;

namespace virtual_receptionist.BusinessLogicLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class UserManagementServicesBLL
    {
        #region Felhasználói üzleti logika

        /// <summary>
        /// A legutóbbi bejelentkezés ideje
        /// </summary>
        public string LastTimeLoggedIn
        {
            get
            {
                string sql = "SELECT log.LogoutDate FROM log WHERE log.ID = (SELECT MAX(log.ID) FROM log)";
                return database.ScalarDQL(sql);
            }
        }

        /// <summary>
        /// Alkalmazást futtató számítógép NetBIOS neve
        /// </summary>
        public static string Client
        {
            get { return Environment.MachineName; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely naplózza a bejelentkezéseket az alkalmazásba
        /// </summary>
        public void Login()
        {
            // FÁJLKEZELÉS
        }

        /// <summary>
        /// Metódus, amely naplózza a kijelentkezéseket az alkalmazásból
        /// </summary>
        public void Logout()
        {
            // FÁJLKEZELÉS
        }
    }
}
