using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Név kivétel
    /// </summary>
    public class NameException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Név kivétel
        /// </summary>
        /// <param name="message"></param>
        public NameException(string message) : base(message)
        {
        }

        #endregion
    }
}
