using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Név kivétel
    /// </summary>
    public class InvalidNameException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Név kivétel
        /// </summary>
        /// <param name="message"></param>
        public InvalidNameException(string message) : base(message)
        {
        }

        #endregion
    }
}
