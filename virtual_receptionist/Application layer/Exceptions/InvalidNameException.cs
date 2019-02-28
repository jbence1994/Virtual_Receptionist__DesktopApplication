using System;

namespace virtual_receptionist.ApplicationLayer.Exceptions
{
    /// <summary>
    /// Név kivétel
    /// </summary>
    public class InvalidNameException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Név kivétel
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidNameException(string message) : base(message)
        {
        }

        #endregion
    }
}
