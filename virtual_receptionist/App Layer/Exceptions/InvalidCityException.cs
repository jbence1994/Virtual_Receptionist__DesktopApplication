using System;

namespace virtual_receptionist.ApplicationLayer.Exceptions
{
    /// <summary>
    /// Település kivétel
    /// </summary>
    public class InvalidCityException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Település kivétel
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidCityException(string message) : base(message)
        {
        }

        #endregion
    }
}
