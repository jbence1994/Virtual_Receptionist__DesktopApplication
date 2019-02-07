using System;

namespace virtual_receptionist.Exceptions
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
        public InvalidEmailAddressException(string message) : base(message)
        {
        }

        #endregion
    }
}
