using virtual_receptionist.PresentationLayer;
using virtual_receptionist.DataAccessLayer.Connection;

namespace virtual_receptionist.ApplicationLayer
{
    /// <summary>
    /// Bejelentkező ablak vezérlője
    /// </summary>
    public class LoginController : DefaultController
    {
        #region Adattagok

        /// <summary>
        /// Bejelentkező ablak egy példánya
        /// </summary>
        private FormLogin formLogin;

        #endregion

        #region Konstruktor

        /// <summary>Bejelentkező ablak vezérlő konstruktora
        /// </summary>
        /// <param name="formLogin">Bejelentkező ablak</param>
        public LoginController(FormLogin formLogin)
        {
            this.formLogin = formLogin;
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
        public void EnterApplication(string accomodationID, string password, string connectionType)
        {
            try
            {
                if (repository.Authentication(accomodationID, password, connectionType))
                {
                    formLogin.Hide();
                    FormMainMenu formMainMenu = new FormMainMenu(formLogin);
                    formMainMenu.Show();
                    repository.Login();
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
