using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace virtual_receptionist
{
    public partial class DataStore
    {
        #region Adatbázis konfigurációhoz szükséges metódusok

        /// <summary>
        /// Metódus, amely helyi adatbázis kiszolgáló útvonalát adja vissza XML állományból
        /// </summary>
        /// <returns>A kiszolgáló útvonalát adja vissza karakterláncként</returns>
        public string GetLocalDatabaseServerPathFromXML()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely távoli adatbázis kiszolgáló útvonalát adja vissza XML állományból
        /// </summary>
        /// <returns>A kiszolgáló útvonalát adja vissza karakterláncként</returns>
        public string GetRemoteDatabaseServerPathFromXML()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely helyi adatbázis kiszolgáló útvonalát adja vissza szöveges állományból
        /// </summary>
        /// <returns>A kiszolgáló útvonalát adja vissza karakterláncként</returns>
        public string GetLocalDatabaseServerPathFromTxt()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely távoli adatbázis kiszolgáló útvonalát adja vissza szöveges állományból
        /// </summary>
        /// <returns>A kiszolgáló útvonalát adja vissza karakterláncként</returns>
        public string GetRemoteDatabaseServerPathFromTxt()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
