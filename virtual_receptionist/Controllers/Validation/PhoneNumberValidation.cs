using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    public static class PhoneNumberValidation
    {
        public static void ValidatePhoneNumber(string phoneNumber)
        {
            if (IsEmpty(phoneNumber))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(phoneNumber))
                throw new Exception("Telefonszám nem tartalmazhat vezérlőbillentyű karaktert!");

            if (ContainsLetterCharacters(phoneNumber))
                throw new Exception("Telefonszám nem tartalmazhat betűt!");
        }
    }
}
