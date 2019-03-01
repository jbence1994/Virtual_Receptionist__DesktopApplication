using System;

namespace virtual_receptionist.ApplicationLayer.Exceptions
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
        /// <param name="message">Kivétel szövege</param>
        public InvalidBirthDateException(string message) : base(message)
        {
        }

        #endregion
    }
}
