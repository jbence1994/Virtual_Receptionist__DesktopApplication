using virtual_receptionist.Controllers.Exceptions;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Adószám ellenőrző osztály
    /// </summary>
    public class VATNumberValidation
    {
        #region Adattagok

        /// <summary>
        /// Adószám input
        /// </summary>
        private readonly string vatNumber;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adószám ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="vatNumber">Adószám input</param>
        public VATNumberValidation(string vatNumber)
        {
            this.vatNumber = vatNumber;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Adószám ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidVATNumberException"></exception>
        public void ValidateVATNumber()
        {
            if (IsEmpty(vatNumber))
            {
                throw new InvalidVATNumberException("Üres mező!");
            }

            if (ContainsControlCharacters(vatNumber))
            {
                throw new InvalidVATNumberException("Adószám nem tartalmaz vezérlőbillentyű karaktert!");
            }
        }

        #endregion
    }
}
