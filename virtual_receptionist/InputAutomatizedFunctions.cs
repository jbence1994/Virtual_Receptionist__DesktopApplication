using System;

namespace virtual_receptionist
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
        public void ProvideName()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet");
            }

            if (FirstLetterIsLowercaseCharacter())
            {
                throw new Exception("Név nem kezdődhet kisbetűvel!");
            }

            if (ContainsControlCharacters())
            {
                throw new Exception("Név nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsDigitCharacters())
            {
                throw new Exception("Név nem tartalmazhat számot!");
            }
        }
        /// <summary>
        /// Szálláshely azonosító ellenőrző metódus
        /// </summary>
        public void ProvideAccomodationID()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet!");
            }

            if (ContainsDigitCharacters())
            {
                throw new Exception("Szállásazonosító nem tartalmazhat számot!");
            }
        }
        /// <summary>
        /// Jelszó ellenőrző metódus
        /// </summary>
        public void ProvidePassword()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new Exception("Jelszó nem tartalmazhat vezérlőbillentyű karaktert!");
            }
        }
        /// <summary>
        /// E-mail cím ellenőrző metódus
        /// </summary>
        public void ProvideEmail()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet!");
            }

            if (!IsValidEmailAddress())
            {
                throw new Exception("Nem érvényes e-mail cím formátum!");
            }
        }
        /// <summary>
        /// Irányítószám ellenőrző metódus
        /// </summary>
        public void ProvideZipCode()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new Exception("Irányítószám nem tartalmazhat vezérlőbillentyű karaktert!");
            }

            if (ContainsLowercaseCharacter())
            {
                throw new Exception("Irányítószám nem tartalmazhat kisebetűs karaktert!");
            }
        }
        /// <summary>
        /// Település nevét és címet ellenőrző metódus
        /// </summary>
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
        /// Aszám ellenőrző metódus
        /// </summary>
        public void ProvideVATNumber()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new Exception("Adószám nem tartalmaz vezérlőbillentyű karaktert!");
            }
        }

        #endregion
    }
}
