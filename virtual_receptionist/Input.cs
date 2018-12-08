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
        private bool IsEmpty()
        {
            return string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input) && input == string.Empty ? true : false;
        }
        /// <summary>
        /// 
        /// </summary>
        private bool ContainsControlCharacters()
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
        private bool ContainsDigitCharacters()
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
        private bool ContainsLetterCharacters()
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
        private bool ContainsUppercaseCharacters()
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
        private bool ContainsLowercaseCharacter()
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
        private bool FirstLetterIsUppercaseCharacter()
        {
            if (char.IsUpper(input[0]))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidEmailAddress()
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
