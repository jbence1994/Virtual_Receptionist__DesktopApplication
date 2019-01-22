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
        /// <summary>
        /// Főmenü ablak
        /// </summary>
        private FormMainMenu formMainMenu;
        /// <summary>
        /// 
        /// </summary>
        private ToolStripLabel toolStripStatusLabelMenuName;
        /// <summary>
        /// 
        /// </summary>
        private ToolStripLabel toolStripStatusLabelClient;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak prezenter konstruktora
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak</param>
        /// <param name="formLogin">Bejelnetkező ablak</param>
        /// <param name="toolStripStatusLabelMenuName"></param>
        /// <param name="toolStripStatusLabelClient"></param>
        public MainMenuPresenter(FormMainMenu formMainMenu, FormLogin formLogin, ToolStripLabel toolStripStatusLabelMenuName, ToolStripLabel toolStripStatusLabelClient)
        {
            this.formMainMenu = formMainMenu;
            this.formLogin = formLogin;
            this.toolStripStatusLabelMenuName = toolStripStatusLabelMenuName;
            this.toolStripStatusLabelClient = toolStripStatusLabelClient;
        }

        #endregion

        #region Főmenü nézetfrissítései

        /// <summary>
        /// Metódus, amely kijelentkezik az alkalmazásból
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak</param>
        public void Logout()
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
        /// Metódus, amely beállítja az ablakot betöltődéskor
        /// </summary>
        public void SetMainMenu()
        {
            Accomodation accomodation = dataRepository.SetAccomodation();
            toolStripStatusLabelClient.Text += $"{DataRepository.Client} |";
            formMainMenu.Text += $"{accomodation.Name} ({accomodation.VatNumber})";
        }
        /// <summary>
        /// Metódus, amely megnyitja a Névjegy ablakot
        /// </summary>
        public void OpenAboutBox()
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        public void SetStatusStripLabelMenuNameInCaseMouseLeave()
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }
        /// <summary>
        /// Metódus, amely megnyitja a súgót
        /// </summary>
        public void OpenCHM()
        {
            Help.ShowHelp(new Control(), "");
        }
        /// <summary>
        /// 
        /// </summary>
        public void SetAccomodationData()
        {
            Accomodation accomodation = dataRepository.SetAccomodation();

            MessageBox.Show(
                $"Szálláshely neve: {accomodation.Name}\n\nCég neve: {accomodation.Company}\n\nKépviselő: {accomodation.Contact}\n\nAdószám: {accomodation.VatNumber}\n\nSzékhely: {accomodation.Headquarters}\n\nTelephely: {accomodation.Site}\n\nTelefonszám: {accomodation.PhoneNumber}\n\nE-mail cím: {accomodation.EmailAddress}",
                "Szálláshely információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuName"></param>
        public void SetStatusStripLabelMenuNameInCaseMouseHover(string menuName)
        {
            toolStripStatusLabelMenuName.Text = menuName;
        }
        /// <summary>
        /// Metódus, amely megnyitja a szobakezelő modult
        /// </summary>
        public void OpenRoomEditor()
        {
            FormRoomEditor formRoomEditor = new FormRoomEditor();
            formRoomEditor.ShowDialog();
        }
        /// <summary>
        /// Metódus, amely megnyitja a számlázó modult
        /// </summary>
        public void OpenBilling()
        {
            FormBilling formBilling = new FormBilling();
            formBilling.ShowDialog();
        }
        /// <summary>
        /// Metódus, amely megnyitja a vendégadatbázis-kezelő modult
        /// </summary>
        public void OpenGuestDatabase()
        {
            FormGuestDatabase formGuestDatabase = new FormGuestDatabase();
            formGuestDatabase.ShowDialog();
        }
        /// <summary>
        /// Metódus, amely megnyitja az alkalmazáss weboldalát internetböngészőben
        /// </summary>
        public void OpenVirtualReceptionistWebsite()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
