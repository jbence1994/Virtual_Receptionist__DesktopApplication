using System.Collections.Generic;
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

        /// <summary>
        /// 
        /// </summary>
        private List<string> countries;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxEmailAddress;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxPhoneNumber;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxAddress;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxCity;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxZipCode;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxBirthDate;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxCitizenship;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxDocumentID;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxName;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxCompanyEmailAddress;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxCompanyPhoneNumber;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxHeadquarterCity;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxHeadquarterAddress;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxHeadquarterZipCode;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxVATNumber;
        /// <summary>
        /// 
        /// </summary>
        private TextBox textBoxCompanyName;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő prezenter konstruktora
        /// </summary>
        /// <param name="listViews">Vendégtáblázatok</param>
        public GuestDatabasePresenter(params Control[] controls)
        {
            countries = dataRepository.GetCountries();

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

            comboBoxCountry.DataSource = countries;
            comboBoxHeadquarterCountry.DataSource = countries;
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToPrivateGuestTable()
        {
            PrivateGuest privateGuest = new PrivateGuest();

            string[] record = new string[5];


            ListViewItem newRecord = new ListViewItem(record);

            listViewPrivateGuests.Items.Add(newRecord);

            dataRepository.CreateGuest(privateGuest);
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus - modális ablak segítségével
        /// </summary>
        public void AddNewRecordToPrivateGuestTableModal()
        {
            PrivateGuest privateGuest = new PrivateGuest();
            formModalGuestDatabase = new FormModalGuestDatabase(privateGuest);
            formModalGuestDatabase.ShowDialog();
            dataRepository.CreateGuest(privateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToCorporateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Céges vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus - modális ablak segítségével
        /// </summary>
        public void AddNewRecordToCorporateGuestTableModal()
        {
            CorporateGuest corporateGuest = new CorporateGuest();
            formModalGuestDatabase = new FormModalGuestDatabase(corporateGuest);
            formModalGuestDatabase.ShowDialog();
            dataRepository.CreateGuest(corporateGuest);
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInPrivateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus - modális ablak segítségével
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

                PrivateGuest privateGuest = new PrivateGuest(name, documentNumber, citizenship, birthDate, country,
                    zipCode, city,
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
        /// Céges vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInCorporateGuestTable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Céges vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus - modális ablak segítségével
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

                CorporateGuest corporateGuest = new CorporateGuest(name, vatNumber, country, zipCode, city, address,
                    phoneNumber,
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
        /// Vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordFromPrivateGuestTable(params TextBox[] textBoxs)
        {
            if (listViewPrivateGuests.SelectedItems.Count > 0)
            {
                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    string name = listViewPrivateGuests.SelectedItems[0].Text;
                    string documentNumber = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                    string citizenship = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                    string birthDate = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                    string country = comboBoxCountry.Text;
                    string zipCode = listViewPrivateGuests.SelectedItems[0].SubItems[5].Text;
                    string city = listViewPrivateGuests.SelectedItems[0].SubItems[6].Text;
                    string address = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;
                    string phoneNumber = listViewPrivateGuests.SelectedItems[0].SubItems[8].Text;
                    string email = listViewPrivateGuests.SelectedItems[0].SubItems[9].Text;

                    PrivateGuest privateGuest = new PrivateGuest(name, documentNumber, citizenship, birthDate, country,
                        zipCode, city, address, phoneNumber, email);

                    // ListView rekord törlés (GUI)
                    int index = listViewPrivateGuests.FocusedItem.Index;
                    listViewPrivateGuests.Items.RemoveAt(index);

                    foreach (var textBox in textBoxs)
                    {
                        textBox.Clear();
                    }
                    comboBoxCountry.DataSource = null;
                    comboBoxCountry.DataSource = countries;
                    comboBoxCountry.SelectedItem = countries[0];

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
        /// Céges vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordFromCorporateGuestTable(params TextBox[] textBoxs)
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
            {
                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    string name = listViewCorporateGuests.SelectedItems[0].Text;
                    string country = comboBoxHeadquarterCountry.Text;
                    string vatNumber = listViewCorporateGuests.SelectedItems[0].SubItems[1].Text;
                    string zipCode = listViewCorporateGuests.SelectedItems[0].SubItems[2].Text;
                    string city = listViewCorporateGuests.SelectedItems[0].SubItems[4].Text;
                    string address = listViewCorporateGuests.SelectedItems[0].SubItems[5].Text;
                    string phoneNumber = listViewCorporateGuests.SelectedItems[0].SubItems[6].Text;
                    string email = listViewCorporateGuests.SelectedItems[0].SubItems[7].Text;

                    CorporateGuest corporateGuest = new CorporateGuest(name, vatNumber, country, zipCode, city, address,
                        phoneNumber, email);

                    // ListView rekord törlése (GUI)
                    int index = listViewCorporateGuests.FocusedItem.Index;
                    listViewCorporateGuests.Items.RemoveAt(index);

                    foreach(var textBox in textBoxs)
                    {
                        textBox.Clear();
                    }
                    comboBoxHeadquarterCountry.DataSource = null;
                    comboBoxHeadquarterCountry.DataSource = countries;
                    comboBoxHeadquarterCountry.SelectedItem = countries[0];

                    // Adatbázis rekord törlése
                    dataRepository.DeleteGuest(corporateGuest);
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ha megváltozik a vendégtáblázat, a megfelelő táblázat cellák adatai kerüljenek a megfelelő szövegmezőkbe
        /// </summary>
        public void ListViewPrivateGuestsSelectedIndexChanged(params TextBox[] textBoxs)
        {
            if (listViewPrivateGuests.SelectedItems.Count > 0)
            {
                textBoxs[0].Text = listViewPrivateGuests.SelectedItems[0].Text;
                textBoxs[1].Text = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                textBoxs[2].Text = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                textBoxs[3].Text = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;

                string selectedCountry = null;

                foreach (string country in countries)
                {
                    if (country.Contains(listViewPrivateGuests.SelectedItems[0].SubItems[4].Text))
                    {
                        selectedCountry = country;
                    }
                }

                comboBoxCountry.SelectedItem = selectedCountry;
                textBoxs[4].Text = listViewPrivateGuests.SelectedItems[0].SubItems[5].Text;
                textBoxs[5].Text = listViewPrivateGuests.SelectedItems[0].SubItems[6].Text;
                textBoxs[6].Text = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;
                textBoxs[7].Text = listViewPrivateGuests.SelectedItems[0].SubItems[8].Text;
                textBoxs[8].Text = listViewPrivateGuests.SelectedItems[0].SubItems[9].Text;
            }
        }

        /// <summary>
        /// Ha megváltozik a céges vendégtáblázat, a megfelelő táblázat cellák adatai kerüljenek a megfelelő szövegmezőkbe
        /// </summary>
        public void ListViewCorporateGuestsSelectedIndexChanged(params TextBox[] textBoxs)
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
            {
                textBoxs[0].Text = listViewCorporateGuests.SelectedItems[0].Text;
                textBoxs[1].Text = listViewCorporateGuests.SelectedItems[0].SubItems[1].Text;

                string selectedCountry = null;

                foreach (string country in countries)
                {
                    if (country.Contains(listViewCorporateGuests.SelectedItems[0].SubItems[2].Text))
                    {
                        selectedCountry = country;
                    }
                }

                comboBoxCountry.SelectedItem = selectedCountry;
                textBoxs[2].Text = listViewCorporateGuests.SelectedItems[0].SubItems[3].Text;
                textBoxs[3].Text = listViewCorporateGuests.SelectedItems[0].SubItems[4].Text;
                textBoxs[4].Text = listViewCorporateGuests.SelectedItems[0].SubItems[5].Text;
                textBoxs[5].Text = listViewCorporateGuests.SelectedItems[0].SubItems[6].Text;
                textBoxs[6].Text = listViewCorporateGuests.SelectedItems[0].SubItems[7].Text;
            }
        }

        #endregion
    }
}
