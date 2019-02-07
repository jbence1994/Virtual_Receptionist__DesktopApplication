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
        /// <exception cref="NameException"></exception>
        public void ProvideName()
        {
            if (IsEmpty())
            {
                throw new NameException("Üres bemenet");
            }

            if (FirstLetterIsLowercaseCharacter())
            {
                throw new NameException("Név nem kezdődhet kisbetűvel!");
            }

            if (ContainsControlCharacters())
            {
                throw new NameException("Név nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsDigitCharacters())
            {
                throw new NameException("Név nem tartalmazhat számot!");
            }
        }

        /// <summary>
        /// Szálláshely azonosító ellenőrző metódus
        /// </summary>
        /// <exception cref="AccomodationIDException"></exception>
        public void ProvideAccomodationID()
        {
            if (IsEmpty())
            {
                throw new AccomodationIDException("Üres bemenet!");
            }

            if (ContainsDigitCharacters())
            {
                throw new AccomodationIDException("Szállásazonosító nem tartalmazhat számot!");
            }
        }

        /// <summary>
        /// Jelszó ellenőrző metódus
        /// </summary>
        /// <exception cref="PasswordException"></exception>
        public void ProvidePassword()
        {
            if (IsEmpty())
            {
                throw new PasswordException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new PasswordException("Jelszó nem tartalmazhat vezérlőbillentyű karaktert!");
            }
        }

        /// <summary>
        /// E-mail cím ellenőrző metódus
        /// </summary>
        /// <exception cref="EmailAddressException"></exception>
        public void ProvideEmail()
        {
            if (IsEmpty())
            {
                throw new EmailAddressException("Üres bemenet!");
            }

            if (!IsValidEmailAddress())
            {
                throw new EmailAddressException("Nem érvényes e-mail cím formátum!");
            }
        }

        /// <summary>
        /// Irányítószám ellenőrző metódus
        /// </summary>
        /// <exception cref="ZipCodeException"></exception>
        public void ProvideZipCode()
        {
            if (IsEmpty())
            {
                throw new ZipCodeException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new ZipCodeException("Irányítószám nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLowercaseCharacter())
            {
                throw new ZipCodeException("Irányítószám nem tartalmazhat kisebetűs karaktert!");
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
        /// <exception cref="VATNumberException"></exception>
        public void ProvideVATNumber()
        {
            if (IsEmpty())
            {
                throw new VATNumberException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new VATNumberException("Adószám nem tartalmaz vezérlőbillentyű karaktert!");
            }
        }

        /// <summary>
        /// Születési idő ellenőrző metódus
        /// </summary>
        /// <exception cref="BirthDateException"></exception>
        public void ProvideBirthDate()
        {
            if (IsEmpty())
            {
                throw new BirthDateException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new BirthDateException("Születési dátum nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLetterCharacters())
            {
                throw new BirthDateException("Születési dátum nem tartalmazhat betűt!");
            }

            if (!IsValidBirthDate())
            {
                throw new BirthDateException(
                    "Nem megfelelő a születési dátum formátuma!\nHelyes formátum: \"YYYY-MM-DD\"");
            }
        }

        #endregion
    }
}
