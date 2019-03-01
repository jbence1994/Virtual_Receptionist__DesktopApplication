using virtual_receptionist.ApplicationLayer.Exceptions;

namespace virtual_receptionist.ApplicationLayer.Validation
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
        /// Település nevét ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidCityException"></exception>
        public void ProvideCity()
        {
            if (IsEmpty())
            {
                throw new InvalidCityException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new InvalidCityException("Település nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (FirstLetterIsLowercaseCharacter())
            {
                throw new InvalidCityException("Település nem kezdődhet kisbetűvel!");
            }
        }

        /// <summary>
        /// Címet ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidAddressException"></exception>
        public void ProvideAddress()
        {
            if (IsEmpty())
            {
                throw new InvalidAddressException("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new InvalidAddressException("Cím nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (FirstLetterIsLowercaseCharacter())
            {
                throw new InvalidAddressException("Cím nem kezdődhet kisbetűvel!");
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
                    "Nem megfelelő a születési dátum formátuma!\nHelyes formátum: YYYY-MM-DD");
            }
        }

        #endregion
    }
}
