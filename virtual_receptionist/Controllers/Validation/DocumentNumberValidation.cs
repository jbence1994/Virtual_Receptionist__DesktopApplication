using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Okmányazonosító ellenőrző osztály
    /// </summary>
    public class DocumentNumberValidation
    {
        #region Adattagok

        /// <summary>
        /// Okmányazonosító input
        /// </summary>
        private readonly string documentNumber;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Okmányazonosító ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="documentNumber">Okmányazonosító input</param>
        public DocumentNumberValidation(string documentNumber)
        {
            this.documentNumber = documentNumber;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Okmányazonosító ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidDocumentNumberException"></exception>
        public void ValidateDocumentNumber()
        {
            if (IsEmpty(documentNumber))
            {
                throw new Exception("Üres mező!");
            }

            if (ContainsControlCharacters(documentNumber))
            {
                throw new Exception("Okmányazonosító nem tartalmazhat vezérlőbillentyű karaktert!");
            }
        }

        #endregion
    }
}
