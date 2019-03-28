using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Szobakapacitás kivétel adott napra
    /// </summary>
    public sealed class InvalidFreeRoomCapacityException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Szobakapacitás kivétel adott napra
        /// </summary>
        public InvalidFreeRoomCapacityException() : base("A megadott napon ez a szoba nem kiadó!")
        {
        }

        #endregion
    }
}
