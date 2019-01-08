using System;
using virtual_receptionist.Model;

namespace virtual_receptionist.Controller
{
    /// <summary>
    /// Az alkalmazás vezérlő osztálya, amely a nézet és a model közti interakcióért felel
    /// </summary>
    public class DefaultController
    {
        #region Adattagok

        /// <summary>
        /// Model osztály egy példánya
        /// </summary>
        private DataStore dataStore;
        /// <summary>
        /// Felhasználó számítógépének a neve, amelyen az alkalmazás fut
        /// </summary>
        private static string client;
        /// <summary>
        /// Szálláshely, amely az alkalmazás felhasználója
        /// </summary>
        private static Accomodation accomodation;

        #endregion

        #region Konstruktor

        public DefaultController()
        {
            dataStore = new DataStore();
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Felhasználó számítógépének a neve, amelyen fut az alkalmazás
        /// </summary>
        public static string Client
        {
            get
            {
                return client = Environment.MachineName;
            }
        }
        /// <summary>
        /// Szálláshely, amely az alkalmazás felhasználója
        /// </summary>
        public static Accomodation Accomodation
        {
            get
            {
                return accomodation = new Accomodation("Autós Panzió", "Autóscsárda-Panzió Kft.", "Szabó Norbert", "1-35-42199206", "6900 Makó, Deák Ferenc u. 28/B", "6900 Makó, Báló liget", "06 (62) 510 298", "info@autospanzio.h");
            }
        }

        #endregion

        #region Metódusok
                
        #endregion
    }
}
