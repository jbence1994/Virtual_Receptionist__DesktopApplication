using MySQL_Interface;
using virtual_receptionist.View;
using virtual_receptionist.Exceptions;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Bejelentkező ablak prezentere
    /// </summary>
    public class LoginPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Bejelentkező ablak egy példánya
        /// </summary>
        private FormLogin formLogin;

        #endregion

        #region Konstruktor

        /// <summary>Bejelentkező ablak prezenter konstruktora
        /// </summary>
        /// <param name="formLogin">Bejelentkező ablak</param>
        public LoginPresenter(FormLogin formLogin)
        {
            this.formLogin = formLogin;
        }

        #endregion

        #region Bejelentkező ablak nézetfrissítései

        /// <summary>
        /// Metódus, amely beenged a főmenübe
        /// </summary>
        /// <param name="accomodationID">Szálláshely azonosító</param>
        /// <param name="password">Regisztrációhoz tartozó jelszó</param>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <exception cref="FailedLoginException"></exception>
        /// <exception cref="InvalidConnectionTypeException"></exception>
        public void EnterApplication(string accomodationID, string password, string connectionType)
        {
            try
            {
                if (dataRepository.Authentication(accomodationID, password, connectionType))
                {
                    formLogin.Hide();
                    FormMainMenu formMainMenu = new FormMainMenu(formLogin);
                    formMainMenu.Show();
                    dataRepository.Login();
                }
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
