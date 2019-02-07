using System;
using virtual_receptionist.Exceptions;

namespace virtual_receptionist.Validation
{
    /// <summary>
    /// Felhasználó által bevitt adatokat ellenőrző osztály
    /// </summary>
    public partial class Input
    {
        #region Adattagok

        /// <summary>
        /// Felhasználó által bevitt adat
        /// </summary>
        private readonly string input;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor, amely megkapja osztályszinten a felhasználó által bevitt adatot
        /// </summary>
        /// <param name="input">Felhasználó által bevitt adat</param>
        public Input(string input)
        {
            this.input = input;
        }

        #endregion

        #region Automatizált ellenőrző metódusok

        /// <summary>
        /// Név ellenőrző függvény
        /// </summary>
        /// <exception cref="InvalidNameException"></exception>
        public void ProvideName()
        {
            if (IsEmpty())
            {
                throw new InvalidNameException("Üres bemenet");
            }

            if (FirstLetterIsLowercaseCharacter())
            {
                throw new InvalidNameException("Név nem kezdődhet kisbetűvel!");
            }

            if (ContainsControlCharacters())
            {
                throw new InvalidNameException("Név nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsDigitCharacters())
            {
                throw new InvalidNameException("Név nem tartalmazhat számot!");
            }
        }

        /// <summary>
        /// Szálláshely azonosító ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidAccomodationIDException"></exception>
        public void ProvideAccomodationID()
        {
            if (IsEmpty())
            {
                throw new InvalidAccomodationIDException("Üres bemenet!");
            }

            if (ContainsDigitCharacters())
            {
                throw new InvalidAccomodationIDException("Szállásazonosító nem tartalmazhat számot!");
            }
        }

        /// <summary>
        /// Jelszó ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidPasswordException"></exception>
        public void ProvidePassword()
        {
            if (IsEmpty())
            {
                throw new InvalidPasswordException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new InvalidPasswordException("Jelszó nem tartalmazhat vezérlőbillentyű karaktert!");
            }
        }

        /// <summary>
        /// E-mail cím ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidEmailAddressException"></exception>
        public void ProvideEmail()
        {
            if (IsEmpty())
            {
                throw new InvalidEmailAddressException("Üres bemenet!");
            }

            if (!IsValidEmailAddress())
            {
                throw new InvalidEmailAddressException("Nem érvényes e-mail cím formátum!");
            }
        }

        /// <summary>
        /// Irányítószám ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidZipCodeException"></exception>
        public void ProvideZipCode()
        {
            if (IsEmpty())
            {
                throw new InvalidZipCodeException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new InvalidZipCodeException("Irányítószám nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLowercaseCharacter())
            {
                throw new InvalidZipCodeException("Irányítószám nem tartalmazhat kisebetűs karaktert!");
            }
        }

        /// <summary>
        /// Település nevét és címet ellenőrző metódus
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void ProvideCityAndAddress()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new Exception("Település vagy cím nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (FirstLetterIsLowercaseCharacter())
            {
                throw new Exception("Település vagy cím nem kezdődhet kisbetűvel!");
            }
        }

        /// <summary>
        /// Adószám ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidVATNumberException"></exception>
        public void ProvideVATNumber()
        {
            if (IsEmpty())
            {
                throw new InvalidVATNumberException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new InvalidVATNumberException("Adószám nem tartalmaz vezérlőbillentyű karaktert!");
            }
        }

        /// <summary>
        /// Születési idő ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidBirthDateException"></exception>
        public void ProvideBirthDate()
        {
            if (IsEmpty())
            {
                throw new InvalidBirthDateException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new InvalidBirthDateException("Születési dátum nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters())
            {
                throw new InvalidBirthDateException("Születési dátum nem tartalmazhat betűt!");
            }

            if (!IsValidBirthDate())
            {
                throw new InvalidBirthDateException(
                    "Nem megfelelő a születési dátum formátuma!\nHelyes formátum: \"YYYY-MM-DD\"");
            }
        }

        #endregion
    }
}
