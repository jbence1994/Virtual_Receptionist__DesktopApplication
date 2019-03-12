using static virtual_receptionist.Controllers.Validation.InputValidation;
using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Cím ellenőrző osztály
    /// </summary>
    public class AddressValidation
    {
        #region Adattagok

        /// <summary>
        /// Cím input
        /// </summary>
        private readonly string address;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Cím ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="address">Cím input</param>
        public AddressValidation(string address)
        {
            this.address = address;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Cím ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidAddressException"></exception>
        public void ValidateAddress()
        {
            if (IsEmpty(address))
            {
                throw new InvalidAddressException("Üres mező!");
            }

            if (ContainsControlCharacters(address))
            {
                throw new InvalidAddressException("Lakcím nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (FirstLetterIsLowercaseCharacter(address))
            {
                throw new InvalidAddressException("Lakcím nem kezdődhet kisbetűvel!");
            }
        }

        #endregion
    }
}
