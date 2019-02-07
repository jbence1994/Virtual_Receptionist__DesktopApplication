using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Szálláshely azonosító kivétel
    /// </summary>
    public class AccomodationIDException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Szálláshely azonosító kivétel
        /// </summary>
        public AccomodationIDException(string message) : base(message)
        {
        }

        #endregion
    }
}
