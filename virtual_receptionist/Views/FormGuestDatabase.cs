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
        /// Vendégadatbázis-kezelő ablak konstruktora, amely összeköti a főmenü ablakot a vendégadatbázis-kezelő ablakkal
        /// </summary>
        public FormGuestDatabase()
        {
            InitializeComponent();
            presenter = new GuestDatabasePresenter(listViewGuests);
        }

        #endregion

        #region UI események

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            presenter.InitalizeGuestTable();
        }

        private void listViewGuests_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            presenter.BlockSettingColumnWidth(e);
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            presenter.BackToMainMenu(this);
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordInGuestTable();
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInGuestTable();
        }

        private void buttonDeleteGuest_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordInGuestTable();
        }

        #endregion
    }
}
