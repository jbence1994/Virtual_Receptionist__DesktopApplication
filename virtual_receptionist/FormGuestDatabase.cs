using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Vendégadatbázis-kezelő ablak
    /// </summary>
    public partial class FormGuestDatabase : Form
    {
        #region Adattagok

        /// <summary>
        /// Főmenü ablak egy példánya
        /// </summary>
        private FormMainMenu formMainMenu;
        /// <summary>
        /// Vendégadatbázis-kezelő ablak új vendég felvételéhez vagy meglévő módosításához szükséges modális ablak egy példánya
        /// </summary>
        private FormModalGuestDatabase formModalGuestDatabase;
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
        public FormGuestDatabase(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            this.formMainMenu = formMainMenu;
        }

        #endregion

        #region UI események

        private void listViewGuests_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = 110;
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            formMainMenu.Show();
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            formModalGuestDatabase = new FormModalGuestDatabase();
            formModalGuestDatabase.ShowDialog();
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            formModalGuestDatabase = new FormModalGuestDatabase();
            formModalGuestDatabase.ShowDialog();
        }

        private void buttonDeleteGuest_Click(object sender, EventArgs e)
        {

        }

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            Model.DataRepository dataRepository = new Model.DataRepository();

            DataTable dt = dataRepository.GetGuests();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem guests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    guests.SubItems.Add(row[i].ToString());
                }

                listViewGuests.Items.Add(guests);
            }
        }

        #endregion
    }
}
