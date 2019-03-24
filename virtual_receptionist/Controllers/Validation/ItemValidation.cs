using virtual_receptionist.Controllers.Exceptions;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Számlázási tétel ellenőrző osztály
    /// </summary>
    public class BillingItemValidation
    {
        /// <summary>
        /// Tétel input
        /// </summary>
        private string billingItem;

        /// <summary>
        /// Számlázási tétel ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="billingItem">Tétel input</param>
        public BillingItemValidation(string billingItem)
        {
            this.billingItem = billingItem;
        }

        /// <summary>
        /// Számlázási tétel ellenőrző metódus
        /// </summary>
        public void ValidateBillingItem()
        {
            if (IsEmpty(billingItem))
            {
                throw new InvalidBllingItemParameterException("Nincs kijelölt tétel!");
            }
        }
    }
}
