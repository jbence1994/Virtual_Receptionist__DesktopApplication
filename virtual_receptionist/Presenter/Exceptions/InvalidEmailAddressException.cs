using System;

namespace virtual_receptionist.ApplicationLayer.Exceptions
{
    /// <summary>
    /// E-mail cím kivétel
    /// </summary>
    public class InvalidEmailAddressException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// E-mail cím kivétel
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidEmailAddressException(string message) : base(message)
        {
        }

        #endregion
    }
}
