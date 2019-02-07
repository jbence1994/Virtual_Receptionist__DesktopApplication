using System.Windows.Forms;
using virtual_receptionist.View;

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
        /// <param name="controls">Paraméterül átadott GUI vezérlők</param>
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
        public void EnterApplication(string accomodationID, string password, string connectionType)
        {
            if (dataRepository.Authentication(accomodationID, password, connectionType))
            {
                formLogin.Hide();
                FormMainMenu formMainMenu = new FormMainMenu(formLogin);
                formMainMenu.Show();
                dataRepository.Login();
            }
            else
            {
                MessageBox.Show("Sikertelen bejelentkezés!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
