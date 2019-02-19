using System.Collections.Generic;
using virtual_receptionist.Model.Entity;
using virtual_receptionist.Model.Repository;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Az alkalmazás prezentere, amely modell kezelésért és nézet frissítésért felel
    /// </summary>
    public class DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Adattár osztály egy példánya
        /// </summary>
        protected DataRepository dataRepository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás prezenter konstruktora
        /// </summary>
        public DefaultPresenter()
        {
            dataRepository = new DataRepository();
        }

        #endregion

        #region Általános metódusok

        /// <summary>
        /// Országokat lista adatszerkezetben visszaadó metódus
        /// </summary>
        /// <returns>Országlistával tér vissza a függvény</returns>
        public List<Country> GetCountries()
        {
            List<Country> countries = dataRepository.GetCountries();
            return countries;
        }

        #endregion
    }
}
