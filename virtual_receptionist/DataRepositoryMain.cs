using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace virtual_receptionist
{
    /// <summary>
    /// Adattár osztály, amely az alkalmazás adatbázisának adatait tárolja
    /// </summary>
    public partial class DataRepository
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
        /// Adatszerkezeteket adattal feltöltő osztály egy példánya
        /// </summary>
        private MySqlDataAdapter mySqlDataAdapter;
        /// <summary>
        /// SQL DML és DDL parancsokat egyszerűen végrehajtó osztály egy példánya
        /// </summary>
        private MySqlCommandBuilder mySqlCommandBuilder;
        /// <summary>
        /// Felhasználó számítógépének a neve, amelyen az alkalmazás fut
        /// </summary>
        private static string client;
        /// <summary>
        /// Szálláshely, amely az alkalmazás felhasználója
        /// </summary>
        private static Accomodation accomodation;

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

        #region Konstruktor

        /// <summary>
        /// Adattár osztály üres konstruktora
        /// </summary>
        public DataRepository()
        {

        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a világ országainak nevét és egy List<T> adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött List<T>-t adja vissza</returns>
        public List<string> GetCountries()
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
                countryName = mySqlDataReader["CountryName"].ToString();
                countries.Add(countryName);
            }

            countries.Sort();

            mySqlDataReader.Close();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");

            return countries;
        }
        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a magyarországi irányítószámok és települések nevét és egy Dictionary<TKey, TValue> adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött Dictionary<TKey, TValue>-t adja vissza</returns>
        public Dictionary<string, string> GetHungarianZipCodesAndCities()
        {
            Dictionary<string, string> hungarianZipCodesAndCities = new Dictionary<string, string>();

            string zipCode = string.Empty;
            string city = string.Empty;

            mySqlConnection.Open();
            Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

            mySqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM hungarian_zip_code_and_city",
                Connection = mySqlConnection
            };

            mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                zipCode = mySqlDataReader["ZipCode"].ToString();
                city = mySqlDataReader["City"].ToString();
                hungarianZipCodesAndCities.Add(zipCode, city);
            }

            mySqlDataReader.Close();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");

            return hungarianZipCodesAndCities;
        }

        #endregion
    }
}
