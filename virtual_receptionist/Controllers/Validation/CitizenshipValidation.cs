using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Állampolgárság ellenőrző osztály
    /// </summary>
    public class CitizenshipValidation
    {
        #region Adattagok

        /// <summary>
        /// Állampolgárság input
        /// </summary>
        private readonly string citizenship;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Állampolgárság ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="citizenship">Állampolgárság input</param>
        public CitizenshipValidation(string citizenship)
        {
            this.citizenship = citizenship;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Állampolgárság ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidCitizenshipException"></exception>
        public void ValidateCitizenship()
        {
            if (IsEmpty(citizenship))
            {
                throw new Exception("Üres mező!");
            }

            if (ContainsControlCharacters(citizenship))
            {
                throw new Exception("Állampolgárság nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsUppercaseCharacters(citizenship))
            {
                throw new Exception("Állampolgárság minden betűje kisbetű kell legyen!");
            }

            if (ContainsDigitCharacters(citizenship))
            {
                throw new Exception("Állampolgárság nem tartalmazhat számot!");
            }
        }

        #endregion
    }
}
