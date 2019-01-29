using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Model;
using virtual_receptionist.View;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Vendégadatbázis-kezelő prezentere
    /// </summary>
    public class GuestDatabasePresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Vendég osztály egy példánya
        /// </summary>
        private Guest guest;

        /// <summary>
        /// Vendégtáblázat
        /// </summary>
        private ListView listViewGuests;

        /// <summary>
        /// Vendégadatbázis-kezelő modális ablaka
        /// </summary>
        private FormModalGuestDatabase formModalGuestDatabase;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő prezenter konstruktora
        /// </summary>
        /// <param name="listViewGuests">Vendégtáblázat</param>
        public GuestDatabasePresenter(ListView listViewGuests)
        {
            this.listViewGuests = listViewGuests;
        }

        #endregion

        #region Vendégadatbázis-kezelő nézetfrissítései

        /// <summary>
        /// Vendégtáblázatot adatbázisból adatokkal feltöltő metódus
        /// </summary>
        public void InitalizeGuestTable()
        {
            DataTable guestDataTable = dataRepository.GetGuests();

            foreach (DataRow row in guestDataTable.Rows)
            {
                ListViewItem guests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < guestDataTable.Columns.Count; i++)
                {
                    guests.SubItems.Add(row[i].ToString());
                }

                listViewGuests.Items.Add(guests);
            }
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba egyidejűleg új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordInGuestTable()
        {
            guest = new Guest();
            formModalGuestDatabase = new FormModalGuestDatabase(guest);
            formModalGuestDatabase.ShowDialog();
            dataRepository.CreateGuest(guest);
            userIntervention = true;
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba egyidejűleg meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordInGuestTable()
        {
            if (listViewGuests.SelectedItems.Count > 0)
            {
                string name = listViewGuests.SelectedItems[0].Text;

                bool nationality;

                if (listViewGuests.SelectedItems[0].SubItems[1].Text == "belföldi")
                {
                    nationality = true;
                }
                else
                {
                    nationality = false;
                }

                string country = listViewGuests.SelectedItems[0].SubItems[2].Text;
                string zipCode = listViewGuests.SelectedItems[0].SubItems[3].Text;
                string city = listViewGuests.SelectedItems[0].SubItems[4].Text;
                string address = listViewGuests.SelectedItems[0].SubItems[5].Text;
                string vatNumber = listViewGuests.SelectedItems[0].SubItems[6].Text;
                string phoneNumber = listViewGuests.SelectedItems[0].SubItems[7].Text;
                string emailAddress = listViewGuests.SelectedItems[0].SubItems[8].Text;

                guest = new Guest(name, nationality, country, zipCode, city, address, vatNumber, phoneNumber,
                    emailAddress);

                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    dataRepository.DeleteGuest(guest);
                }

                userIntervention = true;
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba egyidejűleg meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInGuestTable()
        {
            if (listViewGuests.SelectedItems.Count > 0)
            {
                string name = listViewGuests.SelectedItems[0].Text;

                bool nationality;

                if (listViewGuests.SelectedItems[0].SubItems[1].Text == "belföldi")
                {
                    nationality = true;
                }
                else
                {
                    nationality = false;
                }

                string country = listViewGuests.SelectedItems[0].SubItems[2].Text;
                string zipCode = listViewGuests.SelectedItems[0].SubItems[3].Text;
                string city = listViewGuests.SelectedItems[0].SubItems[4].Text;
                string address = listViewGuests.SelectedItems[0].SubItems[5].Text;
                string vatNumber = listViewGuests.SelectedItems[0].SubItems[6].Text;
                string phoneNumber = listViewGuests.SelectedItems[0].SubItems[7].Text;
                string emailAddress = listViewGuests.SelectedItems[0].SubItems[8].Text;

                guest = new Guest(name, nationality, country, zipCode, city, address, vatNumber, phoneNumber,
                    emailAddress);
                formModalGuestDatabase = new FormModalGuestDatabase(guest);

                if (formModalGuestDatabase.ShowDialog() == DialogResult.OK)
                {
                    //guest = formModalGuestDatabase.Guest;
                    dataRepository.UpdateGuest(guest);

                    userIntervention = true;
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
