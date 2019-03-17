using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Irányítószám kivétel
    /// </summary>
    public sealed class InvalidZipCodeException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Irányítószám kivétel konstruktora
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidZipCodeException(string message) : base(message)
        {
        }

        #endregion
    }
}
