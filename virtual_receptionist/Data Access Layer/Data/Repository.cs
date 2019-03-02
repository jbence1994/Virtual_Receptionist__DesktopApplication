using System.Data;
using System.Collections.Generic;
using virtual_receptionist.DataAccessLayer.Model;
using virtual_receptionist.DataAccessLayer.DatabaseConnection;

namespace virtual_receptionist.DataAccessLayer.Data
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

        #region Getter tulajdonságok

        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        public List<Country> Countries
        {
            get
            {
                if (countries.Count == 0)
                {
                    UploadCountriesList();
                }

                return countries;
            }
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

        #endregion
    }
}
