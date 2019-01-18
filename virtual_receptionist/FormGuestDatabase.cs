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
        public FormGuestDatabase()
        {
            InitializeComponent();
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
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            Model.Guest guest = new Model.Guest();
            formModalGuestDatabase = new FormModalGuestDatabase(guest);
            formModalGuestDatabase.ShowDialog();
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            if (listViewGuests.SelectedItems.Count > 0)
            {
                string name = listViewGuests.SelectedItems[0].Text;
                string nationality = listViewGuests.SelectedItems[0].SubItems[1].Text;
                string country = listViewGuests.SelectedItems[0].SubItems[2].Text;
                string zipCode = listViewGuests.SelectedItems[0].SubItems[3].Text;
                string city = listViewGuests.SelectedItems[0].SubItems[4].Text;
                string address = listViewGuests.SelectedItems[0].SubItems[5].Text;
                string vatNumber = listViewGuests.SelectedItems[0].SubItems[6].Text;
                string phoneNumber = listViewGuests.SelectedItems[0].SubItems[7].Text;
                string emailAddress = listViewGuests.SelectedItems[0].SubItems[8].Text;

                Model.Guest guest = new Model.Guest(name, nationality, country, zipCode, city, address, vatNumber, phoneNumber, emailAddress);
                formModalGuestDatabase = new FormModalGuestDatabase(guest);

                if (formModalGuestDatabase.ShowDialog() == DialogResult.OK)
                {
                    guest = formModalGuestDatabase.Guest;
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteGuest_Click(object sender, EventArgs e)
        {
            if (listViewGuests.SelectedItems.Count > 0)
            {
                string name = listViewGuests.SelectedItems[0].Text;
                string nationality = listViewGuests.SelectedItems[0].SubItems[1].Text;
                string country = listViewGuests.SelectedItems[0].SubItems[2].Text;
                string zipCode = listViewGuests.SelectedItems[0].SubItems[3].Text;
                string city= listViewGuests.SelectedItems[0].SubItems[4].Text;
                string address = listViewGuests.SelectedItems[0].SubItems[5].Text;
                string vatNumber = listViewGuests.SelectedItems[0].SubItems[6].Text;
                string phoneNumber= listViewGuests.SelectedItems[0].SubItems[7].Text;
                string emailAddress = listViewGuests.SelectedItems[0].SubItems[8].Text;
                
                Model.Guest guest = new Model.Guest(name, nationality, country, zipCode, city, address, vatNumber, phoneNumber, emailAddress);
                Model.DataRepository dataRepository = new Model.DataRepository();
                dataRepository.DeleteGuest(guest);
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
