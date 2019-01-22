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

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak konstruktora
        /// </summary>
        public FormMainMenu()
        {
            InitializeComponent();
            presenter = new MainMenuPresenter(this, toolStripStatusLabelMenuName, toolStripStatusLabelClient);
        }

        #endregion

        #region UI események

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            presenter.SetMainMenu();
        }

        private void toolStripMenuItemRoomEditor_Click(object sender, EventArgs e)
        {
            presenter.OpenRoomEditor();
        }

        private void toolStripMenuItemRoomEditor_MouseHover(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseHover("Szobakezelő");
        }

        private void toolStripMenuItemRoomEditor_MouseLeave(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemGuestDatabase_Click(object sender, EventArgs e)
        {
            presenter.OpenGuestDatabase();
        }

        private void toolStripMenuItemGuestDatabase_MouseHover(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseHover("Vendégadatbázis");
        }

        private void toolStripMenuItemGuestDatabase_MouseLeave(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemBilling_Click(object sender, EventArgs e)
        {
            presenter.OpenBilling();
        }

        private void toolStripMenuItemBilling_MouseHover(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseHover("Számlázás");
        }

        private void toolStripMenuItemBilling_MouseLeave(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemHelp_MouseHover(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseHover("Súgó");
        }

        private void toolStripMenuItemHelp_MouseLeave(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemAccomodationData_Click(object sender, EventArgs e)
        {
            presenter.SetAccomodationData();
        }

        private void toolStripMenuItemAccomodationData_MouseHover(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseHover("Szálláshely adatai");
        }

        private void toolStripMenuItemAccomodationData_MouseLeave(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemHelpCHM_Click(object sender, EventArgs e)
        {
            presenter.CHM();
        }

        private void toolStripMenuItemHelpCHM_MouseHover(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseHover("Segítség");
        }

        private void toolStripMenuItemHelpCHM_MouseLeave(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripMenuItemAboutUs_Click(object sender, EventArgs e)
        {
            presenter.OpenAboutBox();
        }

        private void toolStripMenuItemAboutUs_MouseHover(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseHover("Névjegy");
        }

        private void toolStripMenuItemAboutUs_MouseLeave(object sender, EventArgs e)
        {
            presenter.SetStatusStripLabelMenuNameInCaseMouseLeave();
        }

        private void toolStripButtonGuestDatabase_Click(object sender, EventArgs e)
        {
            presenter.OpenGuestDatabase();
        }

        #endregion
    }
}
