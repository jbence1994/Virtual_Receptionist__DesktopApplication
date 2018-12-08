using System.Text.RegularExpressions;

namespace JuhaszBence.CSharp.InputEllenőrző
{
    public class InputEllenőrző
    {
        private string input;
        
        public InputEllenőrző(string input)
        {
            this.input=input;
        }
        
        public bool EllenőrzésVezérlő()
        {
            bool helyesInput = true;
            
            if(IsEmpty())
            {
                throw new MyException("");
            }
            
            if(ContainsControlCharacters())
            {
                throw new MyException("");
            }
            
            if(ContainsDigitCharacters())
            {
                throw new MyException("");
            }
            
            return helyesInput;
        }
        
        /// <summary>
        /// In case a user left empty input fields
        /// </summary>
        private bool IsEmpty()
        {
            return string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input) && input == string.Empty ? true : false;
        }

        /// <summary>
        /// In case a user left control characters in an input field when it is not allowed on any string index
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
        /// In case a user left digit characters in an input field when it is not allowed on any string index
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
        /// In case a user left a letter character in an input field when it is not allowed on any string index
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
        /// In case a user uses an uppercase character when it is not allowedd on any string index
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
        /// In case a user uses a lowercase character when it is not allowed on any string index
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
        /// In case a user does not use uppercase character in the beginning of a string
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
        /// Checking input contains valid email address characters or format
        /// </summary>
        /// <returns></returns>
        private bool IsValidEmailAddress()
        {
            bool valid = false;

            Regex validEmail = new Regex("^[0-9a-z\.-]+@([0-9a-z-]+\.)+[a-z]{2,4}$");

            if (validEmail.IsMatch(emailAddress))
            {
                valid = true;
            }

            return valid;
        }
    }
}
