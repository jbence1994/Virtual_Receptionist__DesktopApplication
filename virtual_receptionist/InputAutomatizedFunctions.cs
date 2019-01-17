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
                throw new Exception("");
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

        public void Provide()
        {

        }
    }
}
