using System;
using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.DatabaseConnection;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Autentikáció vezérlője
    /// </summary>
    public class LoginController
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
        /// <exception cref="InvalidConnectionTypeException"></exception>
        public bool EnterApplication(string accomodationID, string password, string connectionType)
        {
            try
            {
                if (repository.Authentication(accomodationID, password, connectionType))
                {
                    return true;
                }

                return false;
            }
            catch (FailedLoginException)
            {
                throw new FailedLoginException();
            }
            catch (InvalidConnectionTypeException)
            {
                throw new InvalidConnectionTypeException();
            }
        }

        #endregion
    }
}
