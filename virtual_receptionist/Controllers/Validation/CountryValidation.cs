using virtual_receptionist.Controllers.Exceptions;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Ország ellenőrző osztály
    /// </summary>
    public class CountryValidation
    {
        #region Adattagok

        /// <summary>
        /// Ország input
        /// </summary>
        private readonly string country;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Ország ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="country">Ország input</param>
        public CountryValidation(string country)
        {
            this.country = country;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Ország ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidCountryException"></exception>
        public void ValidateCountry()
        {
            if (IsEmpty(country))
            {
                throw new InvalidCountryException();
            }
        }

        #endregion
    }
}
