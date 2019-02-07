using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Főmenü ablak
    /// </summary>
    public partial class FormMainMenu : Form
    {
        #region Adattagok

        /// <summary>
        /// Főmenü ablak prezenter egy példánya
        /// </summary>
        private MainMenuPresenter presenter;

        /// <summary>
        /// Bejelentkező ablak egy példánya
        /// </summary>
        private FormLogin formLogin;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak konstruktora
        /// </summary>
        public FormMainMenu(FormLogin formLogin)
        {
            InitializeComponent();

            this.formLogin = formLogin;
            presenter = new MainMenuPresenter(this, formLogin);
        }

        #endregion

        #region UI események

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelClient.Text += presenter.GetClient();
            Text += presenter.SetMainMenuHeader();
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            presenter.Logout();
        }

        private void toolStripMenuItemRoomEditor_Click(object sender, EventArgs e)
        {
            presenter.OpenRoomEditor();
        }

        private void toolStripMenuItemGuestDatabase_Click(object sender, EventArgs e)
        {
            presenter.OpenGuestDatabase();
        }

        private void toolStripMenuItemBilling_Click(object sender, EventArgs e)
        {
            presenter.OpenBilling();
        }

        private void toolStripMenuItemWebsite_Click(object sender, EventArgs e)
        {
            presenter.OpenVirtualReceptionistWebsite();
        }

        private void toolStripMenuItemHelpCHM_Click(object sender, EventArgs e)
        {
            presenter.OpenCHM();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            presenter.OpenAboutBox();
        }

        private void toolStripMenuItemAccomodationInfo_Click(object sender, EventArgs e)
        {
            presenter.SetAccomodationData();
        }

        private void toolStripButtonRoomEditor_Click(object sender, EventArgs e)
        {
            presenter.OpenRoomEditor();
        }

        private void toolStripButtonGuestDatabase_Click(object sender, EventArgs e)
        {
            presenter.OpenGuestDatabase();
        }

        private void toolStripButtonBilling_Click(object sender, EventArgs e)
        {
            presenter.OpenBilling();
        }

        private void toolStripMenuItemFile_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Fájl";
        }

        private void toolStripMenuItemFile_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemLogout_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Kijelentkezés";
        }

        private void toolStripMenuItemLogout_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemTools_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Eszközök";
        }

        private void toolStripMenuItemTools_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemRoomEditor_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Szobakezelő";
        }

        private void toolStripMenuItemRoomEditor_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemGuestDatabase_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendégadatbázis";
        }

        private void toolStripMenuItemGuestDatabase_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemBilling_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Számlázás";
        }

        private void toolStripMenuItemBilling_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemHelp_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Súgó";
        }

        private void toolStripMenuItemHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemWebsite_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "A Virtual Receptionist weboldala";
        }

        private void toolStripMenuItemWebsite_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemHelpCHM_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Segítség";
        }

        private void toolStripMenuItemHelpCHM_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemAbout_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Névjegy";
        }

        private void toolStripMenuItemAbout_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemAccomodationInfo_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Szálláshely adatai";
        }

        private void toolStripMenuItemAccomodationInfo_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripButtonRoomEditor_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Szobakezelő";
        }

        private void toolStripButtonRoomEditor_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripButtonGuestDatabase_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendégadatbázis";
        }

        private void toolStripButtonGuestDatabase_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripButtonBilling_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Számlázás";
        }

        private void toolStripButtonBilling_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripButtonGuestRegistrationCard_Click(object sender, EventArgs e)
        {
            presenter.OpenGuestRegistrationCard();
        }

        private void toolStripMenuItemGuestRegistrationCard_Click(object sender, EventArgs e)
        {
            presenter.OpenGuestRegistrationCard();
        }

        private void toolStripButtonGuestRegistrationCard_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendég bejelentkező lap kitöltése";
        }

        private void toolStripButtonGuestRegistrationCard_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemGuestRegistrationCard_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendég bejelentkező lap kitöltése";
        }

        private void toolStripMenuItemGuestRegistrationCard_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = presenter.ClearStatusStripLabelMenuNameInCaseMouseLeave();
        }

        #endregion
    }
}
