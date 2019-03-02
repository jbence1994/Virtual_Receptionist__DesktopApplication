using System;

namespace virtual_receptionist.Controllers.Exceptions
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
        /// <param name="message">Kivétel szövege</param>
        public InvalidZipCodeException(string message) : base(message)
        {
        }

        #endregion
    }
}
