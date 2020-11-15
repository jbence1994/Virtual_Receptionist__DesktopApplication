using System;
using static virtual_receptionist.Validation.InputValidation;

namespace virtual_receptionist.Validation
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
