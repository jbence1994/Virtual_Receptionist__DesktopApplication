using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatokat tároló (adattár) osztály, amely az üzleti logikáért felel
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
        /// Adatszerkezeteket adattal feltöltő osztály egy példánya
        /// </summary>
        private MySqlDataAdapter mySqlDataAdapter;
        /// <summary>
        /// SQL DML és DDL parancsokat egyszerűen végrehajtó osztály egy példánya
        /// </summary>
        private MySqlCommandBuilder mySqlCommandBuilder;
        /// <summary>
        /// Számlázási tételeket tartalmazó adatszerkezet
        /// </summary>
        private List<BillingItems> billingItems;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adattár (Model) konstruktora
        /// </summary>
        public DataStore()
        {
            mySqlConnection = new MySqlConnection()
            {
                ConnectionString = $"SERVER=127.0.0.1;DATABASE=virtual_receptionist;UID=root;PASSWORD=;PORT=3306"
            };

            billingItems = new List<BillingItems>();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a világ országainak nevét és egy lista adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött listát adja vissza</returns>
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
        /// Metódus, amely adatbázisból kiolvassa a magyarországi irányítószámok és települések nevét és egy szótár adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött szótárat adja vissza</returns>
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
