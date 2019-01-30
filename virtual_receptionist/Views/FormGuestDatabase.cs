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
            presenter = new GuestDatabasePresenter(listViewPrivateGuests, listViewCorporateGuests);
        }

        #endregion

        #region UI események

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            presenter.InitalizeGuestTable();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            presenter.BackToMainMenu(this);
        }

        #endregion
    }
}
