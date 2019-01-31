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
        /// Címke, amely adott menü nevét írja ki az állapotsorra
        /// </summary>
        private ToolStripStatusLabel toolStripStatusLabelMenuName;

        /// <summary>
        /// Címke, amely megjeleníti a futtató számítógép NetBIOS nevét
        /// </summary>
        private ToolStripStatusLabel toolStripStatusLabelClient;

        /// <summary>
        /// Állapotsor
        /// </summary>
        private StatusStrip statusStripMainMenu;

        /// <summary>
        /// Eszköztár
        /// </summary>
        private ToolStrip toolStripMainMenu;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak prezenter konstruktora
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak</param>
        /// <param name="formLogin">Bejelnetkező ablak</param>
        /// <param name="statusStripMainMenu">Főmenü állapotsora</param>
        /// <param name="toolStripMainMenu">Főmenü eszköztára</param>
        /// <param name="controls">Paraméterül átadott GUI vezérlők</param>
        public MainMenuPresenter(FormMainMenu formMainMenu, FormLogin formLogin, StatusStrip statusStripMainMenu,
            ToolStrip toolStripMainMenu, params ToolStripLabel[] controls)
        {
            this.formMainMenu = formMainMenu;
            this.formLogin = formLogin;
            toolStripStatusLabelMenuName = (ToolStripStatusLabel) controls[0];
            toolStripStatusLabelClient = (ToolStripStatusLabel) controls[1];
            this.statusStripMainMenu = statusStripMainMenu;
            this.toolStripMainMenu = toolStripMainMenu;
        }

        #endregion

        #region Főmenü nézetfrissítései

        /// <summary>
        /// Metódus, amely kijelentkezik az alkalmazásból
        /// </summary>
        public void Logout()
        {
            DialogResult logout = MessageBox.Show("Kijelentkezik az alkalmazásból?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logout == DialogResult.Yes)
            {
                formMainMenu.Close();
                formLogin.Show();
                dataRepository.Logout();
            }
        }

        /// <summary>
        /// Metódus, amely beállítja az ablakot betöltődéskor
        /// </summary>
        public void SetMainMenu()
        {
            Accomodation accomodation = dataRepository.SetAccomodation();
            toolStripStatusLabelClient.Text += DataRepository.Client;
            formMainMenu.Text += $"{accomodation.Name} ({accomodation.VatNumber})";
        }

        /// <summary>
        /// Metódus, amely megnyitja a névjegy ablakot
        /// </summary>
        public void OpenAboutBox()
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// Metódus, amely törli a címke tartalmát, ha nincs adott menüre az egér kurzor rátartva
        /// </summary>
        public void SetStatusStripLabelMenuNameInCaseMouseLeave()
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        /// <summary>
        /// Metódus, amely megnyitja a beépített CHM-súgót
        /// </summary>
        public void OpenCHM()
        {
            Help.ShowHelp(formMainMenu,
                "file://C:\\Users\\Bence\\Desktop\\zarodolgozat\\Virtual-Receptionist-desktop\\virtual_receptionist\\Help\\virtual_receptionist_help.chm");
        }

        /// <summary>
        /// Metódus, amely beállítja az alkalmazást használó szálláshely adatait egy MessageBoxba
        /// </summary>
        public void SetAccomodationData()
        {
            Accomodation accomodation = dataRepository.SetAccomodation();

            MessageBox.Show(
                $"Szálláshely neve: {accomodation.Name}\n\nCég neve: {accomodation.Company}\n\nKépviselő: {accomodation.Contact}\n\nAdószám: {accomodation.VatNumber}\n\nSzékhely: {accomodation.Headquarters}\n\nTelephely: {accomodation.Site}\n\nTelefonszám: {accomodation.PhoneNumber}\n\nE-mail cím: {accomodation.EmailAddress}",
                "Szálláshely információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Metódus, amely beállítja a címke tartalmát, ha egy adott menüre az egéret rátartjuk
        /// </summary>
        /// <param name="menuName">Adott menü neve</param>
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
        /// Metódus, amely megnyitja az alkalmazáss weboldalát egy internetes böngészőben
        /// </summary>
        public void OpenVirtualReceptionistWebsite()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toolStripMenuItemShowStatusStrip">Metódus, amely beállítja az állapotsor láthatóságát, attól függően, hogy be van egy kapcsolva a láthatósága, vagy nincs</param>
        public void SetStatusStripVisibility(ToolStripMenuItem toolStripMenuItemShowStatusStrip)
        {
            if (toolStripMenuItemShowStatusStrip.CheckState == CheckState.Checked)
            {
                statusStripMainMenu.Visible = true;
            }
            else
            {
                statusStripMainMenu.Visible = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toolStripMenuItemShowToolStrip">Metódus, amely beállítja az eszkötár láthatóságát, attól függően, hogy be van egy kapcsolva a láthatósága, vagy nincs</param>
        public void SetToolStripVisibility(ToolStripMenuItem toolStripMenuItemShowToolStrip)
        {
            if (toolStripMenuItemShowToolStrip.CheckState == CheckState.Checked)
            {
                toolStripMainMenu.Visible = true;
            }
            else
            {
                toolStripMainMenu.Visible = false;
            }
        }

        /// <summary>
        /// Metódus, amely megnyitja a vendég bejelentlező lap ablakot
        /// </summary>
        public void OpenGuestRegistrationCard()
        {
            FormGuestRegistrationCard formGuestRegistrationCard = new FormGuestRegistrationCard();
            formGuestRegistrationCard.ShowDialog();
        }

        #endregion
    }
}
