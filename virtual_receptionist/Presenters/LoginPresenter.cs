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

        #endregion
    }
}
