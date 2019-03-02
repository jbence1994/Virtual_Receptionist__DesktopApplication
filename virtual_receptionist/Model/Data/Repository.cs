using System.Data;
using System.Collections.Generic;
using virtual_receptionist.Model.ORM;
using virtual_receptionist.Model.DatabaseConnection;

namespace virtual_receptionist.Model.Data
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatbázis adatokat perzisztensen tároló adattár osztály
    /// </summary>
    public class Repository
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke osztály egy példánya
        /// </summary>
        protected Database database;

        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        private List<Country> countries;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adattár konstruktora
        /// </summary>
        public Repository()
        {
            database = Database.DatabaseInstance;
            countries = new List<Country>();
        }

        #endregion

        #region Adatelérési és adatfeltöltő metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti az országok adatait tartalmazó listát
        /// </summary>
        private void UploadCountriesList()
        {
            string sql = "SELECT * FROM country";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["CountryName"].ToString();

                Country countryInstance = new Country(name);
                countries.Add(countryInstance);
            }
        }

        /// <summary>
        /// Metódus, amely feltölti az országokat tartalmazó listát adatbázisból
        /// </summary>
        /// <returns>Az adatokkal feltöltött listával tér vissza a metódus</returns>
        public List<Country> Countries()
        {
            if (countries.Count == 0)
            {
                UploadCountriesList();
            }

            return countries;
        }

        #endregion
    }
}
