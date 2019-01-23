using System;
using System.Windows.Forms;
using virtual_receptionist.View;
using virtual_receptionist.Model;

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

        /// <summary>
        /// Szálláshely azonosító
        /// </summary>
        private string accomodationID;

        /// <summary>
        /// Regisztrációhoz tartozó jelszó
        /// </summary>
        private string password;

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
        public void EnterApplication(string accomodationID, string password)
        {
            this.accomodationID = accomodationID;
            this.password = password;

            if (dataRepository.Authentication(accomodationID, password))
            {
                formLogin.Hide();
                FormMainMenu formMainMenu = new FormMainMenu(formLogin);
                formMainMenu.Show();
            }
            else
            {
                MessageBox.Show("Sikertelen bejelentkezés!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metódus, amely 'Enter' billentyű lenyomása utána beenged a főmenübe
        /// </summary>
        /// <param name="e">Billentyű esemény</param>
        public void EnterApplication(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterApplication(accomodationID, password);
            }
        }

        /// <summary>
        /// Metódus, amely beállítja az ablakot betöltődéskor
        /// </summary>
        /// <param name="textBoxAccomodationID">TextBox vezérlő, amely bejelentkezéskor a kurzort fókuszba helyezi</param>
        public void SetLogin(TextBox textBoxAccomodationID)
        {
            textBoxAccomodationID.Select();
        }

        #endregion
    }
}
