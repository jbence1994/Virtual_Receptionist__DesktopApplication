using System;
using System.IO;
using System.Windows.Forms;
using virtual_receptionist.Repositories;

namespace virtual_receptionist.Views
{
    public partial class FormMainMenu : Form
    {
        private readonly AccommodationRepository accommodationRepository = new AccommodationRepository();
        private readonly FormLogin formLogin;
        private static string _debugFolder;

        public FormMainMenu(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            _debugFolder = Directory.GetCurrentDirectory();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelClient.Text += Environment.MachineName;
            var accommodation = accommodationRepository.GetAccommodation();
            Text += $"{accommodation.Name} ({accommodation.VatNumber})";
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void toolStripMenuItemRoomEditor_Click(object sender, EventArgs e)
        {
            OpenBooking();
        }

        private void toolStripMenuItemGuestDatabase_Click(object sender, EventArgs e)
        {
            OpenGuestDatabase();
        }

        private void toolStripMenuItemBilling_Click(object sender, EventArgs e)
        {
            OpenBilling();
        }

        private void toolStripMenuItemHelpCHM_Click(object sender, EventArgs e)
        {
            if (_debugFolder == Directory.GetCurrentDirectory())
            {
                Directory.SetCurrentDirectory(@"..\..\Help\");
                Help.ShowHelp(this, "virtual_receptionist_help.chm");
            }
            else
            {
                Help.ShowHelp(this, "virtual_receptionist_help.chm");
            }
        }

        private void toolStripMenuItemAccomodationInfo_Click(object sender, EventArgs e)
        {
            var accommodationInfo = GetAccommodationInfo();
            string name = accommodationInfo[0];
            string company = accommodationInfo[1];
            string contact = accommodationInfo[2];
            string vat = accommodationInfo[3];
            string headquarters = accommodationInfo[4];
            string site = accommodationInfo[5];
            string phone = accommodationInfo[6];
            string email = accommodationInfo[7];

            MessageBox.Show(
                $"Szálláshelyneve: {name}\n\nCég neve: {company}\n\nKontakt: {contact}\n\nAdószám:{vat}\n\nSzékhely: {headquarters}\n\nTelephely: {site}\n\nTelefonszám: {phone}\n\nE-mail cím: {email}",
                "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonRoomEditor_Click(object sender, EventArgs e)
        {
            OpenBooking();
        }

        private void toolStripButtonGuestDatabase_Click(object sender, EventArgs e)
        {
            OpenGuestDatabase();
        }

        private void toolStripButtonBilling_Click(object sender, EventArgs e)
        {
            OpenBilling();
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
            var logout = MessageBox.Show("Kijelentkezik az alkalmazásból?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logout != DialogResult.Yes)
                return;

            Close();
            formLogin.Show();
        }

        private static void OpenGuestDatabase()
        {
            var formGuestDatabase = new FormGuestDatabase();
            formGuestDatabase.ShowDialog();
        }

        private static void OpenBilling()
        {
            var formBilling = new FormBilling();
            formBilling.ShowDialog();
        }

        private static void OpenBooking()
        {
            var formBooking = new FormBooking();
            formBooking.ShowDialog();
        }

        private string[] GetAccommodationInfo()
        {
            var accommodation = accommodationRepository.GetAccommodation();

            var accommodationInfo = new string[8];
            accommodationInfo[0] = accommodation.Name;
            accommodationInfo[1] = accommodation.Company;
            accommodationInfo[2] = accommodation.Contact;
            accommodationInfo[3] = accommodation.VatNumber;
            accommodationInfo[4] = accommodation.Headquarters;
            accommodationInfo[5] = accommodation.Site;
            accommodationInfo[6] = accommodation.PhoneNumber;
            accommodationInfo[7] = accommodation.EmailAddress;

            return accommodationInfo;
        }
    }
}
