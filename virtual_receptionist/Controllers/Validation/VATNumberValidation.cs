using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
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
