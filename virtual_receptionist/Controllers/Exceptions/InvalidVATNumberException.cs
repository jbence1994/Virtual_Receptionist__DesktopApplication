using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// Adószám kivétel
    /// </summary>
    public sealed class InvalidVATNumberException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Adószám kivétel konstruktora
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidVATNumberException(string message) : base(message)
        {
        }

        #endregion
    }
}
