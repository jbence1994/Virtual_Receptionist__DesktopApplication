using static virtual_receptionist.Controllers.Validation.InputValidation;
using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Telefonszám ellenőrző osztály
    /// </summary>
    public class PhoneNumberValidation
    {
        #region Adattagok

        /// <summary>
        /// Telefonszám input
        /// </summary>
        private readonly string phoneNumber;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Telefonszám ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="phoneNumber">Telefonszám input</param>
        public PhoneNumberValidation(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Telefonszám ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidAddressException"></exception>
        public void ValidatePhoneNumber()
        {
            if (IsEmpty(phoneNumber))
            {
                throw new InvalidPhoneNumberException("Üres bemenet!");
            }

            if (ContainsControlCharacters(phoneNumber))
            {
                throw new InvalidAddressException("Telefonszám nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters(phoneNumber))
            {
                throw new InvalidAddressException("Cím nem kezdődhet kisbetűvel!");
            }
        }

        #endregion
    }
}
