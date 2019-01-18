using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Model;
using virtual_receptionist.View;

namespace virtual_receptionist.SupervisingController
{
    public partial class Presenter
    {
        #region Adattagok

        /// <summary>
        /// Vendégadatbázis-kezelő modális ablaka
        /// </summary>
        private FormModalGuestDatabase formModalGuestDatabase;
        /// <summary>
        /// 
        /// </summary>
        private FormGuestDatabase formGuestDatabase;
        /// <summary>
        /// Vendég osztály egy példánya
        /// </summary>
        private Guest guest;
        /// <summary>
        /// Formon felhasználói módosítást tároló logikai változó 
        /// </summary>
        private bool userIntervention;

        #endregion

        #region Vendégadatbázis-kezelő nézetfrissítései

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView"></param>
        public void InitalizeGuestTable(ListView listViewGuests)
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
        /// 
        /// </summary>
        public void AddNewRecordInGuestTable(ListView listViewGuest)
        {
            guest = new Guest();
            formModalGuestDatabase = new FormModalGuestDatabase(guest);
            formModalGuestDatabase.ShowDialog();
            dataRepository.CreateGuest(guest);
            userIntervention = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public void DeleteRecordInGuestTable(ListView listViewGuests)
        {
            if (listViewGuests.SelectedItems.Count > 0)
            {
                string name = listViewGuests.SelectedItems[0].Text;
                bool nationality = false;

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

                guest = new Guest(name, nationality, country, zipCode, city, address, vatNumber, phoneNumber, emailAddress);
                dataRepository.DeleteGuest(guest);

                userIntervention = true;
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void UpdateRecordInGuestTable(ListView listViewGuests)
        {
            if (listViewGuests.SelectedItems.Count > 0)
            {
                string name = listViewGuests.SelectedItems[0].Text;
                bool nationality = false;

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

                guest = new Guest(name, nationality, country, zipCode, city, address, vatNumber, phoneNumber, emailAddress);
                formModalGuestDatabase = new FormModalGuestDatabase(guest);

                if (formModalGuestDatabase.ShowDialog() == DialogResult.OK)
                {
                    guest = formModalGuestDatabase.Guest;
                    dataRepository.UpdateGuest(guest);

                    userIntervention = true;
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void BanSettingColumnWidtChanging(ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = 110;
        }
        /// <summary>
        /// 
        /// </summary>
        public void BackToMainMenu()
        {
            if (userIntervention)
            {
                DialogResult backToMainMenu = MessageBox.Show("Nem mentett változásai vannak! Biztosan visszalép a főmenübe?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (backToMainMenu == DialogResult.OK)
                {
                    formGuestDatabase.Close();
                }
            }
        }

        #endregion
    }
}
