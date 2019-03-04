using System.Collections.Generic;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.ORM;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Az alkalmazás vezárlője, amely a bemenetek validálásért és megfelelő nézet megjelenítéséért felel
    /// </summary>
    public class Controller
    {
        #region Adattagok

        /// <summary>
        /// Ország adattár egy példánya
        /// </summary>
        private CountryRepository repository;

        /// <summary>
        /// Országokat tartalmazó lista
        /// </summary>
        private List<Country> countries;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vezárlő konstruktora
        /// </summary>
        public Controller()
        {
            repository = new CountryRepository();
            countries = repository.GetCountries();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely visszaadja az országok neveit adattárból
        /// </summary>
        /// <returns>Az országnevekkel feltöltött listával tér vissza a metódus</returns>
        public List<string> GetCountries()
        {
            List<string> countryNames = new List<string>();

            foreach (Country country in countries)
            {
                countryNames.Add(country.Name);
            }

            return countryNames;
        }

        #endregion
    }
}
