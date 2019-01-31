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
        /// Országokat tartalmazó lista
        /// </summary>
        private List<string> countries;

        /// <summary>
        /// Vendég e-mail címe szövegmező
        /// </summary>
        private TextBox textBoxEmailAddress;

        /// <summary>
        /// Vendég telefonszáma szövegmező
        /// </summary>
        private TextBox textBoxPhoneNumber;

        /// <summary>
        /// Vendég lakhelyének címe (utca, házszám) szövegmező
        /// </summary>
        private TextBox textBoxAddress;

        /// <summary>
        /// Vendég lakhelyének települése szövegmező
        /// </summary>
        private TextBox textBoxCity;

        /// <summary>
        /// Vendég lakhelyének irányítószáma szövegmező
        /// </summary>
        private TextBox textBoxZipCode;

        /// <summary>
        /// Vendég születési ideje szövegmező
        /// </summary>
        private TextBox textBoxBirthDate;

        /// <summary>
        /// Vendég állampolgársága szövegmező
        /// </summary>
        private TextBox textBoxCitizenship;

        /// <summary>
        /// Vendég útlevél vagy személyi igazolvány száma szövegmező
        /// </summary>
        private TextBox textBoxDocumentID;

        /// <summary>
        /// Vendég neve szövegmező
        /// </summary>
        private TextBox textBoxName;

        /// <summary>
        /// Céges vendég e-mail címe szövegmező
        /// </summary>
        private TextBox textBoxCompanyEmailAddress;

        /// <summary>
        /// Céges vendég telefonszáma szövegmező
        /// </summary>
        private TextBox textBoxCompanyPhoneNumber;

        /// <summary>
        /// Céges vendég települése szövegmező
        /// </summary>
        private TextBox textBoxHeadquarterCity;

        /// <summary>
        /// Céges vendég címe (utca, házszám) szövegmező
        /// </summary>
        private TextBox textBoxHeadquarterAddress;

        /// <summary>
        /// Céges vendég irányítószáma szövegmező
        /// </summary>
        private TextBox textBoxHeadquarterZipCode;

        /// <summary>
        /// Céges vendég adószáma szövegmező
        /// </summary>
        private TextBox textBoxVATNumber;

        /// <summary>
        /// Céges vendég cégneve szövegmező
        /// </summary>
        private TextBox textBoxCompanyName;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő prezenter konstruktora
        /// </summary>
        /// <param name="controls">Paraméterül átadott GUI vezérlők</param>
        public GuestDatabasePresenter(params Control[] controls)
        {
            countries = dataRepository.GetCountries();

            listViewPrivateGuests = (ListView) controls[0];
            listViewCorporateGuests = (ListView) controls[1];
            comboBoxCountry = (ComboBox) controls[2];
            comboBoxHeadquarterCountry = (ComboBox) controls[3];

            textBoxName = (TextBox) controls[4];
            textBoxDocumentID = (TextBox) controls[5];
            textBoxCitizenship = (TextBox) controls[6];
            textBoxBirthDate = (TextBox) controls[7];
            textBoxZipCode = (TextBox) controls[8];
            textBoxCity = (TextBox) controls[9];
            textBoxAddress = (TextBox) controls[10];
            textBoxPhoneNumber = (TextBox) controls[11];
            textBoxEmailAddress = (TextBox) controls[12];

            textBoxCompanyName = (TextBox) controls[13];
            textBoxVATNumber = (TextBox) controls[14];
            textBoxHeadquarterZipCode = (TextBox) controls[15];
            textBoxHeadquarterCity = (TextBox) controls[16];
            textBoxHeadquarterAddress = (TextBox) controls[17];
            textBoxCompanyPhoneNumber = (TextBox) controls[18];
            textBoxCompanyEmailAddress = (TextBox) controls[19];
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
            string name = textBoxName.Text;
            string documentNumber = textBoxDocumentID.Text;
            string citizenship = textBoxCitizenship.Text;
            string birthDate = textBoxBirthDate.Text;
            string country = comboBoxCountry.SelectedItem.ToString();
            string zipCode = textBoxZipCode.Text;
            string city = textBoxCity.Text;
            string address = textBoxAddress.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string email = textBoxEmailAddress.Text;

            PrivateGuest privateGuest = new PrivateGuest(name, documentNumber, citizenship, birthDate, country, zipCode,
                city, address, phoneNumber, email);


            // ListView rekord hozzáadás (GUI)
            ListViewItem newRecord = new ListViewItem();
            newRecord.Text = name;
            newRecord.SubItems.Add(documentNumber);
            newRecord.SubItems.Add(citizenship);
            newRecord.SubItems.Add(birthDate);
            newRecord.SubItems.Add(country);
            newRecord.SubItems.Add(zipCode);
            newRecord.SubItems.Add(city);
            newRecord.SubItems.Add(address);
            newRecord.SubItems.Add(phoneNumber);
            newRecord.SubItems.Add(email);
            listViewPrivateGuests.Items.Add(newRecord);

            //Adatbázis rekord törlése
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
            string name = textBoxCompanyName.Text;
            string vatNumber = textBoxVATNumber.Text;
            string country = comboBoxCountry.SelectedItem.ToString();
            string zipCode = textBoxHeadquarterZipCode.Text;
            string city = textBoxHeadquarterCity.Text;
            string address = textBoxHeadquarterAddress.Text;
            string phoneNumber = textBoxCompanyPhoneNumber.Text;
            string email = textBoxCompanyEmailAddress.Text;

            CorporateGuest corporateGuest =
                new CorporateGuest(name, vatNumber, country, zipCode, city, address, phoneNumber, email);


            // ListView rekord hozzáadás (GUI)
            ListViewItem newRecord = new ListViewItem();
            newRecord.Text = name;
            newRecord.SubItems.Add(vatNumber);
            newRecord.SubItems.Add(country);
            newRecord.SubItems.Add(zipCode);
            newRecord.SubItems.Add(city);
            newRecord.SubItems.Add(address);
            newRecord.SubItems.Add(phoneNumber);
            newRecord.SubItems.Add(email);
            listViewCorporateGuests.Items.Add(newRecord);

            //Adatbázis rekord törlése
            dataRepository.CreateGuest(corporateGuest);
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
            PrivateGuest privateGuest = new PrivateGuest();
            dataRepository.UpdateGuest(privateGuest);
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
            CorporateGuest corporateGuest = new CorporateGuest();
            dataRepository.UpdateGuest(corporateGuest);
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
        public void DeleteRecordFromPrivateGuestTable()
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
                    string country = comboBoxCountry.SelectedItem.ToString();
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

                    //GUI vezérlők alaphelyzetbe állítása
                    textBoxName.Clear();
                    textBoxDocumentID.Clear();
                    textBoxCitizenship.Clear();
                    textBoxBirthDate.Clear();
                    comboBoxCountry.DataSource = null;
                    comboBoxCountry.DataSource = countries;
                    comboBoxCountry.SelectedItem = countries[0];
                    textBoxZipCode.Clear();
                    textBoxCity.Clear();
                    textBoxAddress.Clear();
                    textBoxPhoneNumber.Clear();
                    textBoxEmailAddress.Clear();

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
        public void DeleteRecordFromCorporateGuestTable()
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
            {
                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    string name = listViewCorporateGuests.SelectedItems[0].Text;
                    string country = comboBoxHeadquarterCountry.SelectedItem.ToString();
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

                    textBoxCompanyName.Clear();
                    textBoxVATNumber.Clear();
                    textBoxHeadquarterZipCode.Clear();
                    textBoxHeadquarterCity.Clear();
                    textBoxHeadquarterAddress.Clear();
                    textBoxCompanyPhoneNumber.Clear();
                    textBoxCompanyEmailAddress.Clear();

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
        public void ListViewPrivateGuestsSelectedIndexChanged()
        {
            if (listViewPrivateGuests.SelectedItems.Count > 0)
            {
                textBoxName.Text = listViewPrivateGuests.SelectedItems[0].Text;
                textBoxDocumentID.Text = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                textBoxCitizenship.Text = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                textBoxBirthDate.Text = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;

                string selectedCountry = null;

                foreach (string country in countries)
                {
                    if (country.Contains(listViewPrivateGuests.SelectedItems[0].SubItems[4].Text))
                    {
                        selectedCountry = country;
                    }
                }

                comboBoxCountry.SelectedItem = selectedCountry;

                textBoxZipCode.Text = listViewPrivateGuests.SelectedItems[0].SubItems[5].Text;
                textBoxCity.Text = listViewPrivateGuests.SelectedItems[0].SubItems[6].Text;
                textBoxAddress.Text = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;
                textBoxPhoneNumber.Text = listViewPrivateGuests.SelectedItems[0].SubItems[8].Text;
                textBoxEmailAddress.Text = listViewPrivateGuests.SelectedItems[0].SubItems[9].Text;
            }
        }

        /// <summary>
        /// Ha megváltozik a céges vendégtáblázat, a megfelelő táblázat cellák adatai kerüljenek a megfelelő szövegmezőkbe
        /// </summary>
        public void ListViewCorporateGuestsSelectedIndexChanged()
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
            {
                textBoxCompanyName.Text = listViewCorporateGuests.SelectedItems[0].Text;
                textBoxVATNumber.Text = listViewCorporateGuests.SelectedItems[0].SubItems[1].Text;

                string selectedCountry = null;

                foreach (string country in countries)
                {
                    if (country.Contains(listViewCorporateGuests.SelectedItems[0].SubItems[2].Text))
                    {
                        selectedCountry = country;
                    }
                }

                comboBoxCountry.SelectedItem = selectedCountry;

                textBoxHeadquarterZipCode.Text = listViewCorporateGuests.SelectedItems[0].SubItems[3].Text;
                textBoxHeadquarterCity.Text = listViewCorporateGuests.SelectedItems[0].SubItems[4].Text;
                textBoxHeadquarterAddress.Text = listViewCorporateGuests.SelectedItems[0].SubItems[5].Text;
                textBoxCompanyPhoneNumber.Text = listViewCorporateGuests.SelectedItems[0].SubItems[6].Text;
                textBoxCompanyEmailAddress.Text = listViewCorporateGuests.SelectedItems[0].SubItems[7].Text;
            }
        }

        #endregion
    }
}
