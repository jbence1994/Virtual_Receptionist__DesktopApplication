using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist
{
    public partial class Input
    {
        /// <summary>
        /// Név ellenőrző függvény
        /// </summary>
        /// <param name="name">Név tulajdonság</param>
        /// <returns></returns>
        public void ProvideName()
        {
            if (IsEmpty())
            {
                throw new Exception("Üres bemenet");
            }

            if (ContainsDigitCharacters())
            {
                throw new Exception("");
            }

            if (!FirstLetterIsUppercaseCharacter())
            {
                throw new Exception("");
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
        }
    }
}
