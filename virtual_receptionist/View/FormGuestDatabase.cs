using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Vendégadatbázis-kezelő ablak
    /// </summary>
    public partial class FormGuestDatabase : Form
    {
        #region Adattagok

        /// <summary>
        /// Vendégadatbázis-kezelő prezenter egy példánya
        /// </summary>
        private GuestDatabasePresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő ablak konstruktora
        /// </summary>
        public FormGuestDatabase()
        {
            InitializeComponent();
            presenter = new GuestDatabasePresenter(listViewPrivateGuests, listViewCorporateGuests, comboBoxCountry,
                comboBoxHeadquarterCountry, textBoxID, textBoxName, textBoxDocumentID, textBoxCitizenship,
                textBoxBirthDate, textBoxZipCode, textBoxCity, textBoxAddress, textBoxPhoneNumber, textBoxEmailAddress,
                textBoxCompnayID, textBoxCompanyName, textBoxVATNumber,
                textBoxHeadquarterZipCode, textBoxHeadquarterCity, textBoxHeadquarterAddress, textBoxCompanyPhoneNumber,
                textBoxCompanyEmailAddress, buttonAddPrivateGuest, buttonAddCorporateGuest);
        }

        #endregion

        #region UI események

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            presenter.InitalizeGuestDatabase();
        }

        private void buttonAddPrivateGuest_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordToPrivateGuestTable();
        }

        private void buttonAddCorporateGuest_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordToCorporateGuestTable();
        }

        private void buttonUpdatePrivateGuest_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInPrivateGuestTable();
        }

        private void buttonUpdateCorporateGuest_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInCorporateGuestTable();
        }

        private void buttonDeletePrivateGuest_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordFromPrivateGuestTable();
        }

        private void buttonDeleteCorporateGuest_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordFromCorporateGuestTable();
        }

        private void listViewPrivateGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ListViewPrivateGuestsSelectedIndexChanged();
        }

        private void listViewCorporateGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ListViewCorporateGuestsSelectedIndexChanged();
        }

        #endregion
    }
}
