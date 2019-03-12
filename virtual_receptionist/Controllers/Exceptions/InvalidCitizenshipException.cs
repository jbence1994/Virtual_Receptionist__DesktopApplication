using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Állampolgárság kivétel
    /// </summary>
    public sealed class InvalidCitizenshipException : Exception
    {
        #region Konsturktor

        /// <summary>
        /// Állampolgárság kivétel konstruktor
        /// </summary>
        /// <param name="message">Kivétel szövege</param>
        public InvalidCitizenshipException(string message) : base(message)
        {
        }

        #endregion
    }
}
