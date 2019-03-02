using System;
using virtual_receptionist.BusinessLogicLayer;
using virtual_receptionist.PresentationLayer;
using virtual_receptionist.ApplicationLayer.Exceptions;

namespace virtual_receptionist.ApplicationLayer
{
    public partial class Controller
    {
        #region Metódusok

        /// <summary>
        /// Metódus, amely beenged a főmenübe
        /// </summary>
        /// <param name="accomodationID">Szálláshely azonosító</param>
        /// <param name="password">Regisztrációhoz tartozó jelszó</param>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <exception cref="FailedLoginException"></exception>
        /// <exception cref="Exception"></exception>
        public bool EnterApplication(string accomodationID, string password, string connectionType)
        {
            try
            {
                if (loginBLL.Authentication(accomodationID, password, connectionType))
                {
                    return true;
                }

                return false;
            }
            catch (FailedLoginException)
            {
                throw new FailedLoginException();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        #endregion
    }
}
