using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Telefonszám kivétel
    /// </summary>
    public sealed class InvalidPhoneNumberException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Telefonszám kivétel konstruktora
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidPhoneNumberException(string message) : base(message)
        {
        }

        #endregion
    }
}
