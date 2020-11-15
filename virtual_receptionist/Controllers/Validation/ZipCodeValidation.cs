using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Irányítószám ellenőrző osztály
    /// </summary>
    public class ZipCodeValidation
    {
        #region Adattagok

        /// <summary>
        /// Irányítószám input
        /// </summary>
        private readonly string zipCode;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Irányítószám ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="zipCode">Irányítószám input</param>
        public ZipCodeValidation(string zipCode)
        {
            this.zipCode = zipCode;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Irányítószám ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidZipCodeException"></exception>
        public void ValidateZipCode()
        {
            if (IsEmpty(zipCode))
            {
                throw new Exception("Üres mező!");
            }

            if (ContainsControlCharacters(zipCode))
            {
                throw new Exception("Irányítószám nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLowercaseCharacter(zipCode))
            {
                throw new Exception("Irányítószám nem tartalmazhat kisebetűs karaktert!");
            }
        }

        #endregion
    }
}
