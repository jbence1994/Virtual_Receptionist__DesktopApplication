using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Szobakapacitás kivétel adott napon
    /// </summary>
    public class InvalidCapacityException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Szobakapacitás kivétel adott napon
        /// </summary>
        public InvalidCapacityException() : base("A megadott napon nincs szabad kapacitás a kijelölt szobához!")
        {
        }

        #endregion
    }
}
