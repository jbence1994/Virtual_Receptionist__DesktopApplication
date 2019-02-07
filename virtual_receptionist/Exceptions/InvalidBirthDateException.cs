using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Születési dátum kivétel
    /// </summary>
    public class InvalidBirthDateException : Exception
    {
        #region Konstuktor

        /// <summary>
        /// Születési dátum kivétel
        /// </summary>
        public InvalidBirthDateException(string message) : base(message)
        {
        }

        #endregion
    }
}
