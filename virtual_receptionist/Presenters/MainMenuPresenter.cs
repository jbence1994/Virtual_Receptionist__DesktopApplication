using System.Windows.Forms;
using virtual_receptionist.Model;
using virtual_receptionist.View;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Főmenü ablak prezentere
    /// </summary>
    public class MainMenuPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Alkalmazás bejelentkező ablakának egy példánya
        /// </summary>
        private FormLogin formLogin;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak prezenter konstruktora
        /// </summary>
        public MainMenuPresenter()
        {
        }

        #endregion

        #region Főmenü nézetfrissítései

        /// <summary>
        /// 
        /// </summary>
        public void Open()
        {

        }
        /// <summary>
        /// Metódus, amely kijelentkezik az alkalmazásból
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak</param>
        public void Logout(FormMainMenu formMainMenu)
        {
            DialogResult logout = MessageBox.Show("Kijelentkezik az alkalmazásból?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logout == DialogResult.Yes)
            {
                formMainMenu.Close();
                formLogin.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="form"></param>
        public void SetMainMenu(Form form)
        {
            Accomodation accomodation = dataRepository.SetAccomodation();
            toolStripStatusLabelClient.Text += DataRepository.Client;
            form.Text += $"{accomodation.Name} ({accomodation.VatNumber})";
        }
        /// <summary>
        /// 
        /// </summary>
        public void OpenAboutBox()
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
