﻿using System;
using static virtual_receptionist.Validation.InputValidation;

namespace virtual_receptionist.Validation
{
    public static class ZipCodeValidation
    {
        public static void ValidateZipCode(string zipCode)
        {
            if (IsEmpty(zipCode))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(zipCode))
                throw new Exception("Irányítószám nem tartalmazhat vezérlőbillentyű karaktert!");

            if (ContainsLowercaseCharacter(zipCode))
                throw new Exception("Irányítószám nem tartalmazhat kisebetűs karaktert!");
        }
    }
}