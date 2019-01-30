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
        private PrivateGuest privateGuest;

        /// <summary>
        /// Céges vendég osztály egy példánya
        /// </summary>
        private CorporateGuest corporateGuest;

        /// <summary>
        /// Magánvendég táblázat
        /// </summary>
        private ListView listViewPrivateGuests;

        /// <summary>
        /// Céges vendég táblázat
        /// </summary>
        private ListView listViewCorporateGuests;

        /// <summary>
        /// Vendégadatbázis-kezelő modális ablaka
        /// </summary>
        private FormModalGuestDatabase formModalGuestDatabase;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő prezenter konstruktora
        /// </summary>
        /// <param name="listViews">Vendégtáblázatok</param>
        public GuestDatabasePresenter(params ListView[] listViews)
        {
            listViewPrivateGuests = listViews[0];
            listViewCorporateGuests = listViews[1];
        }

        #endregion

        #region Vendégadatbázis-kezelő nézetfrissítései

        /// <summary>
        /// Táblázatokat adatbázisból adatokkal feltöltő metódus
        /// </summary>
        public void InitalizeGuestTables()
        {
            DataTable privateGuestDataTable = dataRepository.GetPrivateGuests();
            DataTable corporateGuestDataTable = dataRepository.GetCorporateGuests();

            foreach (DataRow row in privateGuestDataTable.Rows)
            {
                ListViewItem privateGuests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < privateGuestDataTable.Columns.Count; i++)
                {
                    privateGuests.SubItems.Add(row[i].ToString());
                }

                listViewPrivateGuests.Items.Add(privateGuests);
            }

            foreach (DataRow row in corporateGuestDataTable.Rows)
            {
                ListViewItem corporateGuests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < corporateGuestDataTable.Columns.Count; i++)
                {
                    corporateGuests.SubItems.Add(row[i].ToString());
                }

                listViewCorporateGuests.Items.Add(corporateGuests);
            }
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToPrivateGuestTable()
        {
            privateGuest = new PrivateGuest();
            formModalGuestDatabase = new FormModalGuestDatabase(privateGuest);
            formModalGuestDatabase.ShowDialog();
            dataRepository.CreateGuest(privateGuest);
        }

        /// <summary>
        /// Vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordFromPrivateGuestTable()
        {
            if (listViewPrivateGuests.SelectedItems.Count > 0)
            {
                string name = listViewPrivateGuests.SelectedItems[0].Text;
                string documentNumber = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                string citizenship = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                string birthDate = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                string country = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                string zipCode = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                string city = listViewPrivateGuests.SelectedItems[0].SubItems[4].Text;
                string address = listViewPrivateGuests.SelectedItems[0].SubItems[5].Text;
                string phoneNumber = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;
                string emailAddress = listViewPrivateGuests.SelectedItems[0].SubItems[8].Text;

                privateGuest = new PrivateGuest(name, documentNumber, citizenship, birthDate, country, zipCode, city,
                    address,
                    phoneNumber, emailAddress);

                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    // ListView rekord törlés (GUI)



                    //Adatbázis rekord törlése

                    dataRepository.DeleteGuest(privateGuest);
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInPrivateGuestTable()
        {
            if (listViewPrivateGuests.SelectedItems.Count > 0)
            {
                string name = listViewPrivateGuests.SelectedItems[0].Text;
                string documentNumber = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                string citizenship = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                string birthDate = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                string country = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                string zipCode = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                string city = listViewPrivateGuests.SelectedItems[0].SubItems[4].Text;
                string address = listViewPrivateGuests.SelectedItems[0].SubItems[5].Text;
                string phoneNumber = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;
                string emailAddress = listViewPrivateGuests.SelectedItems[0].SubItems[8].Text;

                privateGuest = new PrivateGuest(name, documentNumber, citizenship, birthDate, country, zipCode, city,
                    address,
                    phoneNumber, emailAddress);
                formModalGuestDatabase = new FormModalGuestDatabase(privateGuest);

                if (formModalGuestDatabase.ShowDialog() == DialogResult.OK)
                {
                    // ListView rekord módosítás (GUI)

                    //guest = formModalGuestDatabase.Guest;

                    // Adatbázis rekord módosítása
                    dataRepository.UpdateGuest(privateGuest);
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Céges vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToCorporateGuestTable()
        {
            corporateGuest = new CorporateGuest();
            formModalGuestDatabase = new FormModalGuestDatabase(corporateGuest);
            formModalGuestDatabase.ShowDialog();
            dataRepository.CreateGuest(corporateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordFromCorporateGuestTable()
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
            {
                string name = listViewCorporateGuests.SelectedItems[0].Text;
                string vatNumber = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                string country = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                string zipCode = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                string city = listViewPrivateGuests.SelectedItems[0].SubItems[4].Text;
                string address = listViewPrivateGuests.SelectedItems[0].SubItems[5].Text;
                string phoneNumber = listViewPrivateGuests.SelectedItems[0].SubItems[6].Text;
                string emailAddress = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;

                corporateGuest = new CorporateGuest(name, vatNumber, country, zipCode, city, address, phoneNumber,
                    emailAddress);

                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    // ListView rekord törlés (GUI)



                    //Adatbázis rekord törlése

                    dataRepository.DeleteGuest(corporateGuest);
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Céges vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInCorporateGuestTable()
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
            {
                string name = listViewCorporateGuests.SelectedItems[0].Text;
                string vatNumber = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                string country = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                string zipCode = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                string city = listViewPrivateGuests.SelectedItems[0].SubItems[4].Text;
                string address = listViewPrivateGuests.SelectedItems[0].SubItems[5].Text;
                string phoneNumber = listViewPrivateGuests.SelectedItems[0].SubItems[6].Text;
                string emailAddress = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;

                corporateGuest = new CorporateGuest(name, vatNumber, country, zipCode, city, address, phoneNumber,
                    emailAddress);
                formModalGuestDatabase = new FormModalGuestDatabase(corporateGuest);

                if (formModalGuestDatabase.ShowDialog() == DialogResult.OK)
                {
                    // ListView rekord módosítás (GUI)

                    //guest = formModalGuestDatabase.Guest;

                    // Adatbázis rekord módosítása
                    dataRepository.UpdateGuest(corporateGuest);
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
