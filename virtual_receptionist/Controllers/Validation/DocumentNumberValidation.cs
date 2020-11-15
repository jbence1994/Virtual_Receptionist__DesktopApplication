using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    public static class DocumentNumberValidation
    {
        public static void ValidateDocumentNumber(string documentNumber)
        {
            if (IsEmpty(documentNumber))
                throw new Exception("Üres mező!");

            if (ContainsControlCharacters(documentNumber))
                throw new Exception("Okmányazonosító nem tartalmazhat vezérlőbillentyű karaktert!");
        }
    }
}
