using System;

namespace virtual_receptionist
{
    public partial class Input
    {
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
                throw new Exception("");
            }
        }
        /// <summary>
        /// E-mail cím ellenőrző metódus
        /// </summary>
        public void ProvideEmail()
        {
            if (IsEmpty())
            {
                throw new Exception("");
            }

            if (!IsValidEmailAddress())
            {
                throw new Exception("");
            }
        }
        /// <summary>
        /// Irányítószám ellenőrőz metódus
        /// </summary>
        public void ProvideZipCode()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet!");
            }

            if (ContainsControlCharacters())
            {
                throw new Exception("Irányítószám nem tartalmaz vezérlőbillentyű karaktert!");
            }

            if (ContainsLowercaseCharacter())
            {
                throw new Exception("Irányítószám nem tartalmazhat kisebetűs karaktert!");
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
    }
}
