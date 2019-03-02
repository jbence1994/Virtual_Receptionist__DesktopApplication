using System.Collections.Generic;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.ORM;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Az alkalmazás vezérlője, amely a nézetek megfelelő előállításáért és az inputok ellenőrzéséért
    /// </summary>
    public class Controller
    {
        #region Adattagok

        /// <summary>
        /// Adattár osztály egy példénya
        /// </summary>
        private Repository repository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás vezérlő konstruktora
        /// </summary>
        public Controller()
        {
            repository = new Repository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Országok neveit listában visszaadó metódus
        /// </summary>
        /// <returns>Országlistával tér vissza a függvény</returns>
        public List<string> GetCountries()
        {
            List<string> countries = new List<string>();
            countries.Add("Válasszon!");

            foreach (Country country in repository.Countries())
            {
                countries.Add(country.Name);
            }

            return countries;
        }

        #endregion
    }
}
