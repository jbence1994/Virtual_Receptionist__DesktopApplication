using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// E-mail cím ellenőrző osztály
    /// </summary>
    public class EmailValidation
    {
        #region Adattagok

        /// <summary>
        /// E-mail cím input
        /// </summary>
        private readonly string email;

        #endregion

        #region Konsturktor

        /// <summary>
        /// E-mail cím ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="email">E-mail cím input</param>
        public EmailValidation(string email)
        {
            this.email = email;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// E-mail cím ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidEmailAddressException"></exception>
        public void ValidateEmail()
        {
            if (IsEmpty(email))
            {
                throw new Exception("Üres mező!");
            }

            if (!IsValidEmailAddress(email))
            {
                throw new Exception("Nem érvényes e-mail cím formátum!");
            }
        }

        #endregion
    }
}
