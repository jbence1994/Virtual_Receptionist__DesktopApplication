using System;
using System.Windows.Forms;
using virtual_receptionist.ApplicationLayer;

namespace virtual_receptionist.PresentationLayer
{
    /// <summary>
    /// Főmenü ablak
    /// </summary>
    public partial class FormMainMenu : Form
    {
        #region Adattagok

        /// <summary>
        /// Alkalmazás vezérlő egy példánya
        /// </summary>
        private Controller controller;

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
            controller = new Controller();
        }

        #endregion

        #region UI események

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelClient.Text += Environment.MachineName;
            Text += controller.SetMainMenuHeader();
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        private void toolStripMenuItemRoomEditor_Click(object sender, EventArgs e)
        {
            controller.OpenBooking();
        }

        private void toolStripMenuItemGuestDatabase_Click(object sender, EventArgs e)
        {
            controller.OpenGuestDatabase();
        }

        private void toolStripMenuItemBilling_Click(object sender, EventArgs e)
        {
            controller.OpenBilling();
        }

        private void toolStripMenuItemWebsite_Click(object sender, EventArgs e)
        {
            controller.OpenVirtualReceptionistWebsite();
        }

        private void toolStripMenuItemHelpCHM_Click(object sender, EventArgs e)
        {
            controller.OpenCHM();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            controller.OpenAboutBox();
        }

        private void toolStripMenuItemAccomodationInfo_Click(object sender, EventArgs e)
        {
            controller.SetAccomodationInfo();
        }

        private void toolStripButtonRoomEditor_Click(object sender, EventArgs e)
        {
            controller.OpenBooking();
        }

        private void toolStripButtonGuestDatabase_Click(object sender, EventArgs e)
        {
            controller.OpenGuestDatabase();
        }

        private void toolStripButtonBilling_Click(object sender, EventArgs e)
        {
            controller.OpenBilling();
        }

        private void toolStripMenuItemFile_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Fájl";
        }

        private void toolStripMenuItemFile_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemLogout_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Kijelentkezés";
        }

        private void toolStripMenuItemLogout_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemTools_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Eszközök";
        }

        private void toolStripMenuItemTools_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemRoomEditor_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Foglalási napló";
        }

        private void toolStripMenuItemRoomEditor_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemGuestDatabase_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendégadatbázis";
        }

        private void toolStripMenuItemGuestDatabase_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemBilling_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Számlázás";
        }

        private void toolStripMenuItemBilling_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemHelp_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Súgó";
        }

        private void toolStripMenuItemHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemWebsite_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "A Virtual Receptionist weboldala";
        }

        private void toolStripMenuItemWebsite_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemHelpCHM_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Segítség";
        }

        private void toolStripMenuItemHelpCHM_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemAbout_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Névjegy";
        }

        private void toolStripMenuItemAbout_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemAccomodationInfo_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Szálláshely adatai";
        }

        private void toolStripMenuItemAccomodationInfo_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripButtonRoomEditor_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Foglalási napló";
        }

        private void toolStripButtonRoomEditor_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripButtonGuestDatabase_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendégadatbázis";
        }

        private void toolStripButtonGuestDatabase_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripButtonBilling_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Számlázás";
        }

        private void toolStripButtonBilling_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripButtonGuestRegistrationCard_Click(object sender, EventArgs e)
        {
            controller.OpenGuestRegistrationCard();
        }

        private void toolStripMenuItemGuestRegistrationCard_Click(object sender, EventArgs e)
        {
            controller.OpenGuestRegistrationCard();
        }

        private void toolStripButtonGuestRegistrationCard_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendég bejelentkező lap kitöltése";
        }

        private void toolStripButtonGuestRegistrationCard_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void toolStripMenuItemGuestRegistrationCard_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendég bejelentkező lap kitöltése";
        }

        private void toolStripMenuItemGuestRegistrationCard_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Kijelentkezik az alkalmazásból?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logout == DialogResult.Yes)
            {
                Close();
                formLogin.Show();
            }
        }

        private void buttonLogout_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Kijelentkezés";
        }

        private void buttonLogout_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        #endregion
    }
}
