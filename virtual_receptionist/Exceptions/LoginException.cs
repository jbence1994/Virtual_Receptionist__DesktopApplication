using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Bejelentkezés kivétel
    /// </summary>
    public class LoginException : Exception
    {
        #region Konstruktor

        public LoginException(string message) : base(message)
        {
        }

        #endregion
    }
}
