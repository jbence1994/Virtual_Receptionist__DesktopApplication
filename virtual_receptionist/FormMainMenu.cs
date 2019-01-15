using System;
using System.Windows.Forms;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Főmenü ablak
    /// </summary>
    public partial class FormMainMenu : Form
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak konstruktora
        /// </summary>
        public FormMainMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region UI események

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelClient.Text += Model.DataRepository.Client;
        }

        private void toolStripMenuItemRoomEditor_Click(object sender, EventArgs e)
        {
            FormRoomEditor formRoomEditor = new FormRoomEditor(this);
            formRoomEditor.ShowDialog();
        }

        private void toolStripMenuItemRoomEditor_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Szobakiadások és foglalások";
        }

        private void toolStripMenuItemRoomEditor_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemGuestDatabase_Click(object sender, EventArgs e)
        {
            FormGuestDatabase formGuestDatabase = new FormGuestDatabase(this);
            formGuestDatabase.ShowDialog();
        }

        private void toolStripMenuItemGuestDatabase_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendégadatbázis";
        }

        private void toolStripMenuItemGuestDatabase_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemBilling_Click(object sender, EventArgs e)
        {
            FormBilling formBilling = new FormBilling(this);
            formBilling.ShowDialog();
        }

        private void toolStripMenuItemBilling_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Számlázás";
        }

        private void toolStripMenuItemBilling_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemHelp_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Súgó";
        }

        private void toolStripMenuItemHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemAccomodationData_Click(object sender, EventArgs e)
        {
            Model.DataRepository dataRepository = new Model.DataRepository();
            Model.Accomodation accomodation = dataRepository.SetAccomodation();

            MessageBox.Show($"Szálláshely neve: {accomodation.Name}\n\nCég neve: {accomodation.Company}\n\nKépviselő: {accomodation.Contact}\n\nAdószám: {accomodation.VatNumber}\n\nSzékhely: {accomodation.Headquarters}\n\nTelephely: {accomodation.Site}\n\nTelefonszám: {accomodation.PhoneNumber}\n\nE-mail cím: {accomodation.EmailAddress}", "Szálláshely információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItemAccomodationData_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Szálláshely adatai";
        }

        private void toolStripMenuItemAccomodationData_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemHelpCHM_Click(object sender, EventArgs e)
        {
            // CHM
        }

        private void toolStripMenuItemHelpCHM_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Segítség";
        }

        private void toolStripMenuItemHelpCHM_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemAboutUs_Click(object sender, EventArgs e)
        {
            FormAboutUs formAboutUs = new FormAboutUs();
            formAboutUs.ShowDialog();
        }

        private void toolStripMenuItemAboutUs_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Névjegy";
        }

        private void toolStripMenuItemAboutUs_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Kilép az alkalmazásból?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void toolStripMenuItemQuit_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Kilépés";
        }

        private void toolStripMenuItemQuit_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        #endregion
    }
}
