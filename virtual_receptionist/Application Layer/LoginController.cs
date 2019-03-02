using System;
using virtual_receptionist.BusinessLogicLayer;
using virtual_receptionist.PresentationLayer;
using virtual_receptionist.ApplicationLayer.Exceptions;

namespace virtual_receptionist.ApplicationLayer
{
    public partial class Controller
    {
        #region Adattagok

        /// <summary>
        /// 
        /// </summary>
        private LoginBLL loginLogic;

        /// <summary>
        /// Bejelentkező ablak egy példánya
        /// </summary>
        private FormLogin formLogin;

        #endregion

        #region Konstruktor

        /// <summary>Bejelentkező ablak vezérlő konstruktora
        /// </summary>
        /// <param name="formLogin">Bejelentkező ablak</param>
        public Controller(FormLogin formLogin)
        {
            this.formLogin = formLogin;
            loginLogic = new LoginBLL();
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
        public void EnterApplication(string accomodationID, string password, string connectionType)
        {
            try
            {
                if (loginLogic.Authentication(accomodationID, password, connectionType))
                {
                    formLogin.Hide();
                    FormMainMenu formMainMenu = new FormMainMenu(formLogin);
                    formMainMenu.Show();
                }
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
