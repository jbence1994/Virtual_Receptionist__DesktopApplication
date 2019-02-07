using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Adószám kivétel
    /// </summary>
    public class VATNumberException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Adószám kivétel
        /// </summary>
        public VATNumberException(string message) : base(message)
        {
        }

        #endregion
    }
}
