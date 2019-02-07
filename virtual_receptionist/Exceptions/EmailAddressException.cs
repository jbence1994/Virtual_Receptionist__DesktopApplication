using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// E-mail cím kivétel
    /// </summary>
    public class EmailAddressException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// E-mail cím kivétel
        /// </summary>
        public EmailAddressException(string message) : base(message)
        {
        }

        #endregion
    }
}
