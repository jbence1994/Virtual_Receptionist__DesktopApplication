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
                comboBoxHeadquarterCountry);
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

        private void buttonUpdatePrivateGuest_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInPrivateGuestTable();
        }

        private void buttonDeletePrivateGuest_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordFromPrivateGuestTable();
        }

        private void buttonAddPrivateGuestModal_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordToPrivateGuestTableModal();
        }

        private void buttonUpdatePrivateGuestModal_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInPrivateGuestTableModal();
        }

        private void buttonDeletePrivateGuestModal_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordFromPrivateGuestTableModal();
        }

        private void buttonAddCorporateGuest_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordToCorporateGuestTable();
        }

        private void buttonUpdateCorporateGuest_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInCorporateGuestTable();
        }

        private void buttonDeleteCorporateGuest_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordFromCorporateGuestTable();
        }

        private void buttonAddCorporateGuestModal_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordToCorporateGuestTableModal();
        }

        private void buttonUpdateCorporateGuestModal_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInCorporateGuestTableModal();
        }

        private void buttonDeleteCorporateGuestModal_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordFromCorporateGuestTableModal();
        }

        #endregion
    }
}
