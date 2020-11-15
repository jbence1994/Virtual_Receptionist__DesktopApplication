using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Születési idő ellenőrző osztály
    /// </summary>
    public class BirthDateValidation
    {
        #region Adattagok

        /// <summary>
        /// Születési idő input
        /// </summary>
        private readonly string birthDate;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Születési idő ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="birthDate">Születési idő input</param>
        public BirthDateValidation(string birthDate)
        {
            this.birthDate = birthDate;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Születési idő ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidBirthDateException"></exception>
        public void ValidateBirthDate()
        {
            if (IsEmpty(birthDate))
            {
                throw new Exception("Üres mező!");
            }

            if (ContainsControlCharacters(birthDate))
            {
                throw new Exception("Születési dátum nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters(birthDate))
            {
                throw new Exception("Születési dátum nem tartalmazhat betűt!");
            }

            if (!IsValidBirthDate(birthDate))
            {
                throw new Exception("Nem megfelelő a születési dátum formátuma vagy Nem megfelelő évszám, hónap vagy nap lett megadva!\nHelyes formátum: YYYY-MM-DD");
            }
        }

        #endregion
    }
}
