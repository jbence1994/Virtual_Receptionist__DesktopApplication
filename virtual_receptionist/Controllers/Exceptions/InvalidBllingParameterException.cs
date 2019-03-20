using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Számlázás kivétel
    /// </summary>
    public sealed class InvalidBllingParameterException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Számlázás kivétel konstruktora
        /// </summary>
        public InvalidBllingParameterException(string message) : base(message)
        {
        }

        #endregion
    }
}
