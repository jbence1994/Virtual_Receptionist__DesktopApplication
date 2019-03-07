using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Születési dátum kivétel
    /// </summary>
    public sealed class InvalidBirthDateException : Exception
    {
        #region Konstuktor

        /// <summary>
        /// Születési dátum kivétel
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidBirthDateException(string message) : base(message)
        {
        }

        #endregion
    }
}
