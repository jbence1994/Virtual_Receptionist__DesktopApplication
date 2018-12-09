using System.Text.RegularExpressions;

namespace virtual_receptionist
{
    /// <summary>
    /// Felhasználó által bevitt adatok ellenőrzésére szolgáló osztály
    /// </summary>
    public class Input
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

        #region Metódusok

        /// <summary>
        /// 
        /// </summary>
        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input) && input == string.Empty ? true : false;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool ContainsControlCharacters()
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsControl(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ContainsDigitCharacters()
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsDigit(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ContainsLetterCharacters()
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsLetter(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ContainsUppercaseCharacters()
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsUpper(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool ContainsLowercaseCharacter()
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsLower(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool FirstLetterIsUppercaseCharacter()
        {
            if (char.IsUpper(input[0]))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Metódus, amely ellenőrzi helyes formátumú minta-e a felhasználó által bevitt email cím
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény; ellenkező esetben logikai false-szal tér vissza</returns>
        public bool IsValidEmailAddress()
        {
            bool valid = false;

            Regex validEmail = new Regex("^[0-9a-z\\.-]+@([0-9a-z-]+\\.)+[a-z]{2,4}$");

            if (validEmail.IsMatch(input))
            {
                valid = true;
            }

            return valid;
        }

        #endregion
    }
}
