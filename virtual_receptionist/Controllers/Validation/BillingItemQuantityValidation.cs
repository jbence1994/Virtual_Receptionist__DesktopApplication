using static virtual_receptionist.Controllers.Validation.InputValidation;
using System;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Mennyiség ellenőrző osztály
    /// </summary>
    public class BillingItemQuantityValidation
    {
        #region Adattagok

        /// <summary>
        /// Mennyiség input
        /// </summary>
        private string quantity;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Mennyiség ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="quantity">Mennyiség input</param>
        public BillingItemQuantityValidation(string quantity)
        {
            this.quantity = quantity;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Mennyiség ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidBllingItemParameterException"></exception>
        public void ValidateBillingItemQuantity()
        {
            if (IsEmpty(quantity))
            {
                throw new Exception("Üres mező!");
            }

            if (ContainsControlCharacters(quantity))
            {
                throw new Exception("Mennyiség nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters(quantity))
            {
                throw new Exception("Mennyiség nem tartalmazhat betűt!");
            }

            if (IsZeroOrNegative(Convert.ToInt32(quantity)))
            {
                throw new Exception("Mennyiség nem lehet nulla vagy negatív szám!");
            }
        }

        #endregion
    }
}
