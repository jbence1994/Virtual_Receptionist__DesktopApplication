using virtual_receptionist.Controllers.Exceptions;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Település ellenőrző osztály
    /// </summary>
    public class CityValidation
    {
        #region Adattagok

        /// <summary>
        /// Település input
        /// </summary>
        private readonly string city;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Település ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="city">Település input</param>
        public CityValidation(string city)
        {
            this.city = city;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Település ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidCityException"></exception>
        public void ValidateCity()
        {
            if (IsEmpty(city))
            {
                throw new InvalidCityException("Üres bemenet!");
            }

            if (ContainsControlCharacters(city))
            {
                throw new InvalidCityException("Település nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (FirstLetterIsLowercaseCharacter(city))
            {
                throw new InvalidCityException("Település nem kezdődhet kisbetűvel!");
            }
        }

        #endregion
    }
}
