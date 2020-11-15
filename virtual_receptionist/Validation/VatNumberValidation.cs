using System;
using static virtual_receptionist.Validation.InputValidation;

namespace virtual_receptionist.Validation
{
    public static class VatNumberValidation
    {
        public static void ValidateVatNumber(string vatNumber)
        {
            if (IsEmpty(vatNumber))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(vatNumber))
                throw new Exception("Adószám nem tartalmaz vezérlőbillentyű karaktert!");
        }
    }
}
