using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
{
    /// <summary>
    /// Országok adattár
    /// </summary>
    public class CountryRepository : Repository
    {
        #region Adattagok

        /// <summary>
        /// Országokat tartalmazó lista
        /// </summary>
        private List<Country> countries;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Országok adattár konstruktora
        /// </summary>
        public CountryRepository()
        {
            countries = new List<Country>();
        }

        #endregion

        #region Adatfeltöltő metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti az országok adatait tartalmazó listát
        /// </summary>
        private List<Country> UploadCountriesList()
        {
            string sql = "SELECT * FROM country";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["CountryName"].ToString();

                Country countryInstance = new Country(name);
                countries.Add(countryInstance);
            }

            return countries;
        }

        #endregion

        #region Adatelérési metódusok

        /// <summary>
        /// Metódus, amely feltölti az országokat tartalmazó listát adatbázisból
        /// </summary>
        /// <returns>Az adatokkal feltöltött listával tér vissza a metódus</returns>
        public List<Country> GetCountries()
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
