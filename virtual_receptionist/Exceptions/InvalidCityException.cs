using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Település kivétel
    /// </summary>
    public class InvalidCityException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Település kivétel
        /// </summary>
        public InvalidCityException(string message) : base(message)
        {
        }

        #endregion
    }
}
