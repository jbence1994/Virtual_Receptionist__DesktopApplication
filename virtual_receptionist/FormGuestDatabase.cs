using System;
using System.Windows.Forms;
using virtual_receptionist.SupervisingController;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Vendégadatbázis-kezelő ablak
    /// </summary>
    public partial class FormGuestDatabase : Form
    {
        #region Adattagok

        /// <summary>
        /// Prezenter osztály egy példánya
        /// </summary>
        private Presenter presenter;
        /// <summary>
        /// Formon felhasználói módosítást tároló logikai változó 
        /// </summary>
        private bool userIntervention;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő ablak konstruktora, amely összeköti a főmenü ablakot a vendégadatbázis-kezelő ablakkal
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak egy példánya</param>
        public FormGuestDatabase()
        {
            InitializeComponent();
            presenter = new Presenter();
        }

        #endregion

        #region UI események

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            presenter.InitalizeGuestTable(listViewGuests);
        }

        private void listViewGuests_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = 110;
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            if (userIntervention)
            {
                DialogResult backToMainMenu = MessageBox.Show("Nem mentett változásai vannak! Biztosan visszalép a főmenübe?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (backToMainMenu == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordInGuestTable();
            userIntervention = true;
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInGuestTable(listViewGuests);
            userIntervention = true;
        }

        private void buttonDeleteGuest_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordInGuestTable(listViewGuests);
            userIntervention = true;
        }

        #endregion
    }
}
