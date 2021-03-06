﻿using System;

namespace virtual_receptionist.Controllers.Exceptions
{
    /// <summary>
    /// Bejelentkezés kivétel
    /// </summary>
    public sealed class FailedLoginException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Bejelentkezés kivétel konstruktora
        /// </summary>
        public FailedLoginException() : base("Sikertelen bejelentkezés!\nHibás szálláshely azonosító vagy jelszó!")
        {
        }

        #endregion
    }
}
