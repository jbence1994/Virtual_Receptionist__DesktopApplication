using System.Text.RegularExpressions;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Inputot ellenőrző függvénygyűjtemény osztálya
    /// </summary>
    public static class InputValidation
    {
        #region Metódusok

        /// <summary>
        /// Metódus, amely ellenőrzi az input üres karakterlánc-e
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        public static bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e vezérlőbillentyű karaktert
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        public static bool ContainsControlCharacters(string input)
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
        public static bool ContainsDigitCharacters(string input)
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
        public static bool ContainsLetterCharacters(string input)
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
        public static bool ContainsUppercaseCharacters(string input)
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
        public static bool ContainsLowercaseCharacter(string input)
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
        public static bool FirstLetterIsUppercaseCharacter(string input)
        {
            if (char.IsUpper(input[0]))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi, hogy az input első karaktere kisbetű-e
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        public static bool FirstLetterIsLowercaseCharacter(string input)
        {
            if (char.IsLower(input[0]))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi helyes formátumú minta-e a felhasználó által bevitt email cím
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        public static bool IsValidEmailAddress(string input)
        {
            bool valid = false;

            Regex validEmail = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$");

            if (validEmail.IsMatch(input))
            {
                valid = true;
            }

            return valid;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi helyes formátumú minta-e a felhasználó által bevitt születési dátum
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        public static bool IsValidBirthDate(string input)
        {
            bool valid = false;

            Regex validBirthDate = new Regex(@"([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))");

            if (validBirthDate.IsMatch(input))
            {
                valid = true;
            }

            return valid;
        }

        #endregion
    }
}
