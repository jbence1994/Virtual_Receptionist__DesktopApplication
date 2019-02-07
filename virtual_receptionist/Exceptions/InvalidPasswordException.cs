using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Jelszó kivétel
    /// </summary>
    public class InvalidPasswordException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Jelszó kivétel
        /// </summary>
        public InvalidPasswordException(string message) : base(message)
        {
        }

        #endregion
    }
}
