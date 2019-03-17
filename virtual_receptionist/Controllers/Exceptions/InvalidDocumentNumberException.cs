using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Okmányazonosító kivétel
    /// </summary>
    public sealed class InvalidDocumentNumberException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Okmányazonosító kivétel konstruktora
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidDocumentNumberException(string message) : base(message)
        {
        }

        #endregion
    }
}
