using static virtual_receptionist.Controllers.Validation.InputValidation;
using virtual_receptionist.Controllers.Exceptions;

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
        private int quantity;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantity"></param>
        public BillingItemQuantityValidation(int quantity)
        {
            this.quantity = quantity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="InvalidBllingItemParameterException"></exception>
        public void ValidateBillingItemQuantity()
        {
            if (IsEmpty(quantity.ToString()))
            {
                throw new InvalidBllingItemParameterException("Üres mező!");
            }

            if (ContainsControlCharacters(quantity.ToString()))
            {
                throw new InvalidBllingItemParameterException("Mennyiség nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters(quantity.ToString()))
            {
                throw new InvalidBllingItemParameterException("Mennyiség nem tartalmazhat betűt!");
            }

            if (IsZeroOrNegative(quantity))
            {
                throw new InvalidBllingItemParameterException("Mennyiség nem lehet nulla vagy negatív szám!");
            }
        }
    }
}
