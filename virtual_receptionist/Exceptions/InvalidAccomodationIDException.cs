using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Szálláshely azonosító kivétel
    /// </summary>
    public class InvalidAccomodationIDException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Szálláshely azonosító kivétel
        /// </summary>
        public InvalidAccomodationIDException(string message) : base(message)
        {
        }

        #endregion
    }
}
