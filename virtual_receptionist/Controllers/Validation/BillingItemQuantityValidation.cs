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
        private double quantity;

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
        public void ValidateBillingItemQuantity()
        {
            if (IsEmpty(quantity.ToString()))
            {
                throw new InvalidBllingParameterException("Üres mező!");
            }

            if (ContainsControlCharacters(quantity.ToString()))
            {
                throw new InvalidBllingParameterException("Mennyiség nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters(quantity.ToString()))
            {
                throw new InvalidBllingParameterException("Mennyiség nem tartalmazhat betűt!");
            }
        }
    }
}
