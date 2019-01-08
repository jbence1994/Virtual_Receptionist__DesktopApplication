using System.Text.RegularExpressions;

namespace virtual_receptionist.Controller
{
    /// <summary>
    /// Felhasználó által bevitt adatokat ellenőrző osztály
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
        /// Metódus, amely ellenőrzi az input üres karakterlánc-e
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        public bool IsEmpty()
        {
            return string.IsNullOrWhiteSpace(input) ? true : false;
        }
        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e vezérlőbillentyű karaktert
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi az input tartalmaz-e számot
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi az input tartalmaz-e betűt
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi az input tartalmaz-e nagybetűs karaktert
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi az input tartalmaz-e kisebtűs karaktert
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi, hogy az input első karaktere nagybetű-e
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
