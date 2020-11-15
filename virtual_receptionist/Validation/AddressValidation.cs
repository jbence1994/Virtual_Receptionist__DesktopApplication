using System;
using static virtual_receptionist.Validation.InputValidation;

namespace virtual_receptionist.Validation
{
    public static class AddressValidation
    {
        public static void ValidateAddress(string address)
        {
            if (IsEmpty(address))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(address))
                throw new Exception("Lakcím nem tartalmazhat vezérlőbillentyű karaktert!");

            if (FirstLetterIsLowercaseCharacter(address))
                throw new Exception("Lakcím nem kezdődhet kisbetűvel!");
        }
    }
}
