using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Település kivétel
    /// </summary>
    public sealed class InvalidCityException : Exception
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
