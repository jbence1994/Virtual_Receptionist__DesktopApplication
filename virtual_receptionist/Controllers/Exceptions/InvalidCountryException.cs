using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Ország kivétel
    /// </summary>
    public sealed class InvalidCountryException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Név kivétel
        /// </summary>
        public InvalidCountryException() : base("Nincs ország kiválasztva!")
        {
        }

        #endregion
    }
}
