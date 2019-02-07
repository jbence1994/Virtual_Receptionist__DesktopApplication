using System.Text.RegularExpressions;

namespace virtual_receptionist.Validation
{
    public partial class Input
    {
        #region Helper függvények

        /// <summary>
        /// Metódus, amely ellenőrzi az input üres karakterlánc-e
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        private bool IsEmpty()
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e vezérlőbillentyű karaktert
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi az input tartalmaz-e számot
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi az input tartalmaz-e betűt
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi az input tartalmaz-e nagybetűs karaktert
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi az input tartalmaz-e kisebtűs karaktert
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
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
        /// Metódus, amely ellenőrzi, hogy az input első karaktere nagybetű-e
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        private bool FirstLetterIsUppercaseCharacter()
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
        private bool FirstLetterIsLowercaseCharacter()
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

        /// <summary>
        /// Metódus, amely ellenőrzi helyes formátumú minta-e a felhasználó által bevitt születési dátum
        /// </summary>
        /// <returns>Ha megfelelő a formátum logikai igazat ad vissza a függvény, ellenkező esetben logikai hamissal tér vissza</returns>
        private bool IsValidBirthDate()
        {
            bool valid = false;

            Regex validBirthDate = new Regex("([12]\\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\\d|3[01]))");

            if (validBirthDate.IsMatch(input))
            {
                valid = true;
            }

            return valid;
        }

        #endregion
    }
}
