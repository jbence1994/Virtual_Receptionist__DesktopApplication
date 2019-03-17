using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Név kivétel
    /// </summary>
    public sealed class InvalidNameException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Név kivétel konstruktora
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidNameException(string message) : base(message)
        {
        }

        #endregion
    }
}
