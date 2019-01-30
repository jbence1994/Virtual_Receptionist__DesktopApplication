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
        /// Országokat tartalmazó legördülő lista (vendég)
        /// </summary>
        private ComboBox comboBoxCountry;

        /// <summary>
        /// Országokat tartalmazó legördülő lista (cégesvendég)
        /// </summary>
        private ComboBox comboBoxHeadquarterCountry;

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
        public GuestDatabasePresenter(params Control[] controls)
        {
            listViewPrivateGuests = (ListView) controls[0];
            listViewCorporateGuests = (ListView) controls[1];
            comboBoxCountry = (ComboBox) controls[2];
            comboBoxHeadquarterCountry = (ComboBox) controls[3];
        }

        #endregion

        #region Vendégadatbázis-kezelő nézetfrissítései

        /// <summary>
        /// Vendégadatbázis ablakot előkészítő metódus
        /// </summary>
        public void InitalizeGuestDatabase()
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

            comboBoxCountry.DataSource = dataRepository.GetCountries();
            comboBoxHeadquarterCountry.DataSource = dataRepository.GetCountries();
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddNewRecordToPrivateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateRecordInPrivateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteRecordFromPrivateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToPrivateGuestTableModal()
        {
            privateGuest = new PrivateGuest();
            formModalGuestDatabase = new FormModalGuestDatabase(privateGuest);
            formModalGuestDatabase.ShowDialog();
            dataRepository.CreateGuest(privateGuest);
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInPrivateGuestTableModal()
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
        /// Vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordFromPrivateGuestTableModal()
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
        /// 
        /// </summary>
        public void AddNewRecordToCorporateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateRecordInCorporateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteRecordFromCorporateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Céges vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToCorporateGuestTableModal()
        {
            corporateGuest = new CorporateGuest();
            formModalGuestDatabase = new FormModalGuestDatabase(corporateGuest);
            formModalGuestDatabase.ShowDialog();
            dataRepository.CreateGuest(corporateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInCorporateGuestTableModal()
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

        /// <summary>
        /// Céges vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordFromCorporateGuestTableModal()
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

        #endregion
    }
}
