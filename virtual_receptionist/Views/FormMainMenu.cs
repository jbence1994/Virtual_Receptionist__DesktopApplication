using System;
using System.Windows.Forms;
using virtual_receptionist.Repositories;

namespace virtual_receptionist.Views
{
    public partial class FormMainMenu : Form
    {
        private readonly AccommodationRepository accommodationRepository = new AccommodationRepository();
        private readonly FormLogin formLogin;

        public FormMainMenu(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            var accommodation = accommodationRepository.GetAccommodation();
            Text += $"{accommodation.Name} ({accommodation.VatNumber})";
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            var logout = MessageBox.Show("Kijelentkezik az alkalmazásból?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logout != DialogResult.Yes)
                return;

            Close();
            formLogin.Show();
        }

        private void toolStripMenuItemRoomEditor_Click(object sender, EventArgs e)
        {
            var formBooking = new FormBooking();
            formBooking.ShowDialog();
        }

        private void toolStripMenuItemGuestDatabase_Click(object sender, EventArgs e)
        {
            var formGuestDatabase = new FormGuestDatabase();
            formGuestDatabase.ShowDialog();
        }

        private void toolStripMenuItemBilling_Click(object sender, EventArgs e)
        {
            var formBilling = new FormBilling();
            formBilling.ShowDialog();
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
