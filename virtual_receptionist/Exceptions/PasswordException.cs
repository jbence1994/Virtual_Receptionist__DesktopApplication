using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Jelszó kivétel
    /// </summary>
    public class PasswordException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Jelszó kivétel
        /// </summary>
        public PasswordException(string message) : base(message)
        {
        }

        #endregion
    }
}
