using System;
using static virtual_receptionist.Validation.InputValidation;

namespace virtual_receptionist.Validation
{
    public static class CityValidation
    {
        public static void ValidateCity(string city)
        {
            if (IsEmpty(city))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(city))
                throw new Exception("Település nem tartalmaz vezérlőbillentyű karaktert!");

            if (FirstLetterIsLowercaseCharacter(city))
                throw new Exception("Település nem kezdődhet kisbetűvel!");
        }
    }
}
