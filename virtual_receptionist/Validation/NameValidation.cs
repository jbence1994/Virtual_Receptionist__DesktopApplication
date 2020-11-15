using System;
using static virtual_receptionist.Validation.InputValidation;

namespace virtual_receptionist.Validation
{
    public static class NameValidation
    {
        public static void ValidateName(string name)
        {
            if (IsEmpty(name))
                throw new Exception("Üres mező!");

            if (FirstLetterIsLowercaseCharacter(name))
                throw new Exception("Név nem kezdődhet kisbetűvel!");

            if (ContainsControlCharacters(name))
                throw new Exception("Név nem tartalmazhat vezérlőbillentyű karaktert!");

            if (ContainsDigitCharacters(name))
                throw new Exception("Név nem tartalmazhat számot!");
        }
    }
}
