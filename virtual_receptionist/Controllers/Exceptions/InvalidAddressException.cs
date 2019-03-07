using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Cím kivétel
    /// </summary>
    public sealed class InvalidAddressException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Cím kivétel
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidAddressException(string message) : base(message)
        {
        }

        #endregion
    }
}
