using System;
using static virtual_receptionist.Validation.InputValidation;

namespace virtual_receptionist.Validation
{
    public static class CitizenshipValidation
    {
        public static void ValidateCitizenship(string citizenship)
        {
            if (IsEmpty(citizenship))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(citizenship))
                throw new Exception("Állampolgárság nem tartalmazhat vezérlőbillentyű karaktert!");

            if (ContainsUppercaseCharacters(citizenship))
                throw new Exception("Állampolgárság minden betűje kisbetű kell legyen!");

            if (ContainsDigitCharacters(citizenship))
                throw new Exception("Állampolgárság nem tartalmazhat számot!");
        }
    }
}
