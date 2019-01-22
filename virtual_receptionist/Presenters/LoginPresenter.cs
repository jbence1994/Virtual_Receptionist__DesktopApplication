using System.Windows.Forms;
using virtual_receptionist.View;
using virtual_receptionist.Model;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// 
        /// </summary>
        private FormLogin formLogin;

        #endregion

        #region Konstruktor

        /// <summary>
        /// 
        /// </summary>
        public LoginPresenter(FormLogin formLogin)
        {
            this.formLogin = formLogin;
        }

        #endregion

        #region Bejelentkező ablak nézetfrissítései

        /// <summary>
        /// Metódus, amely megnyitja az alkalmazás főmenüjét, a bejelentkezés ablakot pedig bezárja
        /// </summary>
        public void EnterApplication()
        {
            formLogin.Hide();
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e">Billentyű esemény</param>
        public void EnterApplication(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterApplication();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="textBoxAccomodationID"></param>
        public void SetLogin(TextBox textBoxAccomodationID)
        {
            textBoxAccomodationID.Select();
        }

        #endregion
    }
}
