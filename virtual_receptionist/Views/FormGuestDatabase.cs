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
            presenter = new GuestDatabasePresenter(listViewPrivateGuests, listViewCorporateGuests);
        }

        #endregion

        #region UI események

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            presenter.InitalizeGuestTables();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            presenter.BackToMainMenu(this);
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

        #endregion
    }
}
