using System;
using System.IO;
using System.Xml;

namespace virtual_receptionist
{
    public partial class DataStore
    {
        #region Adattagok

        /// <summary>
        /// Fájl adatfolyam olvasó osztály egy példánya
        /// </summary>
        private StreamReader streamReader;
        /// <summary>
        /// Fájl adatfolyam író osztály egy példánya
        /// </summary>
        private StreamWriter streamWriter;
        /// <summary>
        /// XML állomány olvasó osztály egy példánya
        /// </summary>
        private XmlTextReader xmlTextReader;

        #endregion

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
