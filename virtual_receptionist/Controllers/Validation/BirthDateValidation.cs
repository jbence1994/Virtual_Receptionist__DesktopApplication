using virtual_receptionist.Controllers.Exceptions;
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
        public void ProvideBirthDate()
        {
            if (IsEmpty(birthDate))
            {
                throw new InvalidBirthDateException("Üres bemenet!");
            }

            if (ContainsControlCharacters(birthDate))
            {
                throw new InvalidBirthDateException("Születési dátum nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters(birthDate))
            {
                throw new InvalidBirthDateException("Születési dátum nem tartalmazhat betűt!");
            }

            if (!IsValidBirthDate(birthDate))
            {
                throw new InvalidBirthDateException(
                    "Nem megfelelő a születési dátum formátuma!\nHelyes formátum: YYYY-MM-DD");
            }
        }

        #endregion
    }
}
