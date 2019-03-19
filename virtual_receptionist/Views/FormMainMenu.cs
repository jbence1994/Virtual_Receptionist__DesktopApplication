using System;
using System.IO;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Főmenü ablak
    /// </summary>
    public partial class FormMainMenu : Form
    {
        #region Adattagok

        /// <summary>
        /// Főmenü vezérlő egy példánya
        /// </summary>
        private MainMenuController controller;

        /// <summary>
        /// Bejelentkező ablak egy példánya
        /// </summary>
        private FormLogin formLogin;

        /// <summary>
        /// Alkalmazás futási mappája
        /// </summary>
        private static string debugFolder;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak konstruktora
        /// </summary>
        public FormMainMenu(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            controller = new MainMenuController();
            debugFolder = Directory.GetCurrentDirectory();
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
            Logout();
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
            if (debugFolder == Directory.GetCurrentDirectory())
            {
                Directory.SetCurrentDirectory(@"..\..\Help\");
                Help.ShowHelp(this, "virtual_receptionist_help.chm");
            }
            else
            {
                Help.ShowHelp(this, "virtual_receptionist_help.chm");
            }
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            controller.OpenAboutBox();
        }

        private void toolStripMenuItemAccomodationInfo_Click(object sender, EventArgs e)
        {
            string name = controller.GetAccomodationInfo()[0];
            string company = controller.GetAccomodationInfo()[1];
            string contact = controller.GetAccomodationInfo()[2];
            string vat = controller.GetAccomodationInfo()[3];
            string headquarters = controller.GetAccomodationInfo()[4];
            string site = controller.GetAccomodationInfo()[5];
            string phone = controller.GetAccomodationInfo()[6];
            string email = controller.GetAccomodationInfo()[7];

            MessageBox.Show(
                $"Szálláshelyneve: {name}\n\nCég neve: {company}\n\nKontakt: {contact}\n\nAdószám:{vat}\n\nSzékhely: {headquarters}\n\nTelephely: {site}\n\nTelefonszám: {phone}\n\nE-mail cím: {email}",
                "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void buttonLogout_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Kijelentkezés";
        }

        private void buttonLogout_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "";
        }

        private void Logout()
        {
            DialogResult logout = MessageBox.Show("Kijelentkezik az alkalmazásból?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logout == DialogResult.Yes)
            {
                Close();
                formLogin.Show();
            }
        }

        #endregion
    }
}
