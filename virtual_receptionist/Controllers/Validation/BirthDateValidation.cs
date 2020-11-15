using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    public static class BirthDateValidation
    {
        public static void ValidateBirthDate(string birthDate)
        {
            if (IsEmpty(birthDate))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(birthDate))
                throw new Exception("Születési dátum nem tartalmazhat vezérlőbillentyű karaktert!");

            if (ContainsLetterCharacters(birthDate))
                throw new Exception("Születési dátum nem tartalmazhat betűt!");

            if (!IsValidBirthDate(birthDate))
                throw new Exception(
                    "Nem megfelelő a születési dátum formátuma vagy Nem megfelelő évszám, hónap vagy nap lett megadva!\nHelyes formátum: YYYY-MM-DD");
        }
    }
}
