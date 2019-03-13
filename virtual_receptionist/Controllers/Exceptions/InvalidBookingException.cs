using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Foglalás kivétel
    /// </summary>
    public sealed class InvalidBookingException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Foglalás kivétel konstruktora
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidBookingException(string message) : base(message)
        {
        }

        #endregion
    }
}
