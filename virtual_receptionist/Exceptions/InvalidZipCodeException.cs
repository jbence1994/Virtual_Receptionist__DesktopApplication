using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Irányítószám kivétel
    /// </summary>
    public class InvalidZipCodeException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Irányítószám kivétel
        /// </summary>
        public InvalidZipCodeException(string message) : base(message)
        {
        }

        #endregion
    }
}
