﻿using virtual_receptionist.Repositories;
using System;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Autentikáció vezérlője
    /// </summary>
    public class LoginController : Controller
    {
        #region Adattagok

        /// <summary>
        /// Szálláshely adattár osztály egy példánya
        /// </summary>
        private AccomodationRepository repository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Autetikáció vezérlő konstruktora
        /// </summary>
        public LoginController()
        {
            repository = new AccomodationRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely beenged a főmenübe
        /// </summary>
        /// <param name="accomodationID">Szálláshely azonosító</param>
        /// <param name="password">Regisztrációhoz tartozó jelszó</param>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <exception cref="FailedLoginException"></exception>
        /// <exception cref="Exception"></exception>
        public bool EnterApplication(string accomodationID, string password)
        {
            try
            {
                if (repository.Authentication(accomodationID, password))
                {
                    return true;
                }

                return false;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        #endregion
    }
}
