using System;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository
    {
        #region Getter tulajdonságok

        /// <summary>
        /// A legutóbbi bejelentkezés ideje
        /// </summary>
        public string LastTimeLoggedIn
        {
            get
            {
                string sql = "SELECT log.LogoutDate FROM log WHERE log.ID = (SELECT MAX(log.ID) FROM log)";
                return database.DQLScalar(sql);
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
            string sql =
                $"INSERT INTO log(Client, OS_Version, LoginDate, LogoutDate) VALUES (\"{Client}\", \"{Environment.OSVersion}\", \"{DateTime.Now}\", \"Logged in\")";
            database.DML(sql);
        }

        /// <summary>
        /// Metódus, amely naplózza a kijelentkezéseket az alkalmazásból
        /// </summary>
        public void Logout()
        {
            string sql =
                $"UPDATE log SET LogoutDate = \"{DateTime.Now}\" WHERE LogoutDate LIKE \"Logged in\"";
            database.DML(sql);
        }

        #endregion
    }
}
