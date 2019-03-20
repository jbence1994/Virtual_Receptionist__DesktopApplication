using static virtual_receptionist.Controllers.Validation.InputValidation;
using virtual_receptionist.Controllers.Exceptions;
using System;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public class BillingItemQuantityValidation
    {
        /// <summary>
        /// 
        /// </summary>
        private string quantity;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantity"></param>
        public BillingItemQuantityValidation(string quantity)
        {
            this.quantity = quantity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="InvalidBllingItemParameterException"></exception>
        public void ValidateBillingItemQuantity()
        {
            if (IsEmpty(quantity))
            {
                throw new InvalidBllingItemParameterException("Üres mező!");
            }

            if (ContainsControlCharacters(quantity))
            {
                throw new InvalidBllingItemParameterException("Mennyiség nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters(quantity))
            {
                throw new InvalidBllingItemParameterException("Mennyiség nem tartalmazhat betűt!");
            }

            if (IsZeroOrNegative(Convert.ToInt32(quantity)))
            {
                throw new InvalidBllingItemParameterException("Mennyiség nem lehet nulla vagy negatív szám!");
            }
        }
    }
}
