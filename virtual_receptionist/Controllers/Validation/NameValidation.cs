﻿using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Név ellenőrző osztály
    /// </summary>
    public class NameValidation
    {
        #region Adattagok

        /// <summary>
        /// Név input
        /// </summary>
        private readonly string name;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Név ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="name">Név input</param>
        public NameValidation(string name)
        {
            this.name = name;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Név ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidNameException"></exception>
        public void ValidateName()
        {
            if (IsEmpty(name))
            {
                throw new Exception("Üres mező!");
            }

            if (FirstLetterIsLowercaseCharacter(name))
            {
                throw new Exception("Név nem kezdődhet kisbetűvel!");
            }

            if (ContainsControlCharacters(name))
            {
                throw new Exception("Név nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsDigitCharacters(name))
            {
                throw new Exception("Név nem tartalmazhat számot!");
            }
        }

        #endregion
    }
}
