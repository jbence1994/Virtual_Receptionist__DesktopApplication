using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Cím kivétel
    /// </summary>
    public class InvalidAddressException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Cím kivétel
        /// </summary>
        public InvalidAddressException(string message) : base(message)
        {
        }

        #endregion
    }
}
