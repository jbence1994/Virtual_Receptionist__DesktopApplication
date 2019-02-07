using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Irányítószám kivétel
    /// </summary>
    public class ZipCodeException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Jelszó kivétel
        /// </summary>
        public ZipCodeException(string message) : base(message)
        {
        }

        #endregion
    }
}
