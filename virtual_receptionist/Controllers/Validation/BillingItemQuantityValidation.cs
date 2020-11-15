using static virtual_receptionist.Controllers.Validation.InputValidation;
using System;

namespace virtual_receptionist.Controllers.Validation
{
    public static class BillingItemQuantityValidation
    {
        public static void ValidateBillingItemQuantity(string quantity)
        {
            if (IsEmpty(quantity))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(quantity))
                throw new Exception("Mennyiség nem tartalmaz vezérlőbillentyű karaktert!");

            if (ContainsLetterCharacters(quantity))
                throw new Exception("Mennyiség nem tartalmazhat betűt!");

            if (IsZeroOrNegative(Convert.ToInt32(quantity)))
                throw new Exception("Mennyiség nem lehet nulla vagy negatív szám!");
        }
    }
}
