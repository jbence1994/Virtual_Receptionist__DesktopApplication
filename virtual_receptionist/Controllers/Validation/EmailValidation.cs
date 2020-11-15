using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    public static class EmailValidation
    {
        public static void ValidateEmail(string email)
        {
            if (IsEmpty(email))
                throw new Exception("Üres mező!");

            if (!IsValidEmailAddress(email))
                throw new Exception("Nem érvényes e-mail cím formátum!");
        }
    }
}
