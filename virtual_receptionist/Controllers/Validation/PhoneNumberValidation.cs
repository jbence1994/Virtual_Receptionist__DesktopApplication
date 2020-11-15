﻿using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Telefonszám ellenőrző osztály
    /// </summary>
    public class PhoneNumberValidation
    {
        #region Adattagok

        /// <summary>
        /// Telefonszám input
        /// </summary>
        private readonly string phoneNumber;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Telefonszám ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="phoneNumber">Telefonszám input</param>
        public PhoneNumberValidation(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Telefonszám ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidPhoneNumberException"></exception>
        public void ValidatePhoneNumber()
        {
            if (IsEmpty(phoneNumber))
            {
                throw new Exception("Üres mező!");
            }

            if (ContainsControlCharacters(phoneNumber))
            {
                throw new Exception("Telefonszám nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters(phoneNumber))
            {
                throw new Exception("Telefonszám nem tartalmazhat betűt!");
            }
        }

        #endregion
    }
}
