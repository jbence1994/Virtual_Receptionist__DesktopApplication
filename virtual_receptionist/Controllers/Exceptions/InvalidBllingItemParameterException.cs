using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Számlázás kivétel
    /// </summary>
    public sealed class InvalidBllingItemParameterException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Számlázás kivétel konstruktora
        /// </summary>
        public InvalidBllingItemParameterException(string message) : base(message)
        {
        }

        #endregion
    }
}
