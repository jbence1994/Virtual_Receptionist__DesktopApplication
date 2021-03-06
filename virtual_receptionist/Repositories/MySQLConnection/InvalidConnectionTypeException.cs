﻿using System;

namespace virtual_receptionist.Repositories.MySQLConnection
{
    /// <summary>
    /// Adatbázis kapcsolódás típus kivétel
    /// </summary>
    public sealed class InvalidConnectionTypeException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Adatbázis kapcsolódás típus kivétel
        /// </summary>
        public InvalidConnectionTypeException() : base("Érvénytelen adatbázis kapcsolódás típus!")
        {
        }

        #endregion
    }
}
