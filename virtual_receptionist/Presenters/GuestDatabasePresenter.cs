using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Model;

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
        /// Országokat tartalmazó lista
        /// </summary>
        private List<Country> countries;

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

        /// <summary>
        /// Vendég azonosító szövegmező
        /// </summary>
        private TextBox textBoxID;

        /// <summary>
        /// Céges vendég azonosító szövegmező
        /// </summary>
        private TextBox textBoxCompanyID;

        /// <summary>
        /// 
        /// </summary>
        private int nextID;

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

            textBoxID = (TextBox) controls[4];
            textBoxName = (TextBox) controls[5];
            textBoxDocumentID = (TextBox) controls[6];
            textBoxCitizenship = (TextBox) controls[7];
            textBoxBirthDate = (TextBox) controls[8];
            textBoxZipCode = (TextBox) controls[9];
            textBoxCity = (TextBox) controls[10];
            textBoxAddress = (TextBox) controls[11];
            textBoxPhoneNumber = (TextBox) controls[12];
            textBoxEmailAddress = (TextBox) controls[13];

            textBoxCompanyID = (TextBox) controls[14];
            textBoxCompanyName = (TextBox) controls[15];
            textBoxVATNumber = (TextBox) controls[16];
            textBoxHeadquarterZipCode = (TextBox) controls[17];
            textBoxHeadquarterCity = (TextBox) controls[18];
            textBoxHeadquarterAddress = (TextBox) controls[19];
            textBoxCompanyPhoneNumber = (TextBox) controls[20];
            textBoxCompanyEmailAddress = (TextBox) controls[21];

            if (dataRepository.GetMaxGuestID() != "")
            {
                nextID = int.Parse(dataRepository.GetMaxGuestID()) + 1;
            }
            else
            {
                nextID = 1;
            }
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

            textBoxID.Text = nextID.ToString();
            textBoxCompanyID.Text = nextID.ToString();

            comboBoxCountry.DataSource = countries;
            comboBoxHeadquarterCountry.DataSource = countries;
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToPrivateGuestTable()
        {
            int id = int.Parse(textBoxID.Text);
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

            PrivateGuest privateGuest = new PrivateGuest(id, name, documentNumber, citizenship, birthDate, country,
                zipCode,
                city, address, phoneNumber, email);


            // ListView rekord hozzáadás (GUI)
            textBoxID.Text = id.ToString();
            ListViewItem newRecord = new ListViewItem();
            newRecord.Text = id.ToString();
            newRecord.SubItems.Add(name);
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
        /// Céges vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToCorporateGuestTable()
        {
            int id = int.Parse(textBoxCompanyID.Text);
            string name = textBoxCompanyName.Text;
            string vatNumber = textBoxVATNumber.Text;
            string country = comboBoxCountry.SelectedItem.ToString();
            string zipCode = textBoxHeadquarterZipCode.Text;
            string city = textBoxHeadquarterCity.Text;
            string address = textBoxHeadquarterAddress.Text;
            string phoneNumber = textBoxCompanyPhoneNumber.Text;
            string email = textBoxCompanyEmailAddress.Text;

            CorporateGuest corporateGuest =
                new CorporateGuest(id, name, vatNumber, country, zipCode, city, address, phoneNumber, email);


            // ListView rekord hozzáadás (GUI)
            textBoxCompanyID.Text = id.ToString();
            ListViewItem newRecord = new ListViewItem();
            newRecord.Text = id.ToString();
            newRecord.SubItems.Add(name);
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
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInPrivateGuestTable()
        {
            PrivateGuest privateGuest = new PrivateGuest();
            dataRepository.UpdateGuest(privateGuest);
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
                    int id = int.Parse(listViewPrivateGuests.SelectedItems[0].Text);
                    string name = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                    string documentNumber = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                    string citizenship = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                    string birthDate = listViewPrivateGuests.SelectedItems[0].SubItems[4].Text;
                    string country = comboBoxCountry.SelectedItem.ToString();
                    string zipCode = listViewPrivateGuests.SelectedItems[0].SubItems[6].Text;
                    string city = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;
                    string address = listViewPrivateGuests.SelectedItems[0].SubItems[8].Text;
                    string phoneNumber = listViewPrivateGuests.SelectedItems[0].SubItems[9].Text;
                    string email = listViewPrivateGuests.SelectedItems[0].SubItems[10].Text;

                    PrivateGuest privateGuest = new PrivateGuest(id, name, documentNumber, citizenship, birthDate,
                        country,
                        zipCode, city, address, phoneNumber, email);

                    // ListView rekord törlés (GUI)
                    int index = listViewPrivateGuests.FocusedItem.Index;
                    listViewPrivateGuests.Items.RemoveAt(index);

                    //GUI vezérlők alaphelyzetbe állítása
                    textBoxID.Clear();
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
                    int id = int.Parse(listViewCorporateGuests.SelectedItems[0].Text);
                    string name = listViewCorporateGuests.SelectedItems[0].SubItems[1].Text;
                    string country = comboBoxHeadquarterCountry.SelectedItem.ToString();
                    string vatNumber = listViewCorporateGuests.SelectedItems[0].SubItems[2].Text;
                    string zipCode = listViewCorporateGuests.SelectedItems[0].SubItems[3].Text;
                    string city = listViewCorporateGuests.SelectedItems[0].SubItems[4].Text;
                    string address = listViewCorporateGuests.SelectedItems[0].SubItems[5].Text;
                    string phoneNumber = listViewCorporateGuests.SelectedItems[0].SubItems[6].Text;
                    string email = listViewCorporateGuests.SelectedItems[0].SubItems[7].Text;

                    CorporateGuest corporateGuest = new CorporateGuest(id, name, vatNumber, country, zipCode, city,
                        address,
                        phoneNumber, email);

                    // ListView rekord törlése (GUI)
                    int index = listViewCorporateGuests.FocusedItem.Index;
                    listViewCorporateGuests.Items.RemoveAt(index);

                    textBoxCompanyID.Clear();
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
                textBoxID.Text = listViewPrivateGuests.SelectedItems[0].Text;
                textBoxName.Text = listViewPrivateGuests.SelectedItems[0].SubItems[1].Text;
                textBoxDocumentID.Text = listViewPrivateGuests.SelectedItems[0].SubItems[2].Text;
                textBoxCitizenship.Text = listViewPrivateGuests.SelectedItems[0].SubItems[3].Text;
                textBoxBirthDate.Text = listViewPrivateGuests.SelectedItems[0].SubItems[4].Text;

                Country selectedCountry = null;

                foreach (Country country in countries)
                {
                    if (listViewPrivateGuests.SelectedItems[0].SubItems[5].Text.Contains(country.Name))
                    {
                        selectedCountry = country;
                    }
                }

                comboBoxCountry.SelectedItem = selectedCountry;

                textBoxZipCode.Text = listViewPrivateGuests.SelectedItems[0].SubItems[6].Text;
                textBoxCity.Text = listViewPrivateGuests.SelectedItems[0].SubItems[7].Text;
                textBoxAddress.Text = listViewPrivateGuests.SelectedItems[0].SubItems[8].Text;
                textBoxPhoneNumber.Text = listViewPrivateGuests.SelectedItems[0].SubItems[9].Text;
                textBoxEmailAddress.Text = listViewPrivateGuests.SelectedItems[0].SubItems[10].Text;
            }
            else
            {
                textBoxID.Clear();
                textBoxID.Text = nextID.ToString();
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
            }
        }

        /// <summary>
        /// Ha megváltozik a céges vendégtáblázat, a megfelelő táblázat cellák adatai kerüljenek a megfelelő szövegmezőkbe
        /// </summary>
        public void ListViewCorporateGuestsSelectedIndexChanged()
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
            {
                textBoxCompanyID.Text = listViewCorporateGuests.SelectedItems[0].Text;
                textBoxCompanyName.Text = listViewCorporateGuests.SelectedItems[0].SubItems[1].Text;
                textBoxVATNumber.Text = listViewCorporateGuests.SelectedItems[0].SubItems[2].Text;

                Country selectedCountry = null;

                foreach (Country country in countries)
                {
                    if (listViewCorporateGuests.SelectedItems[0].SubItems[3].Text.Contains(country.Name))
                    {
                        selectedCountry = country;
                    }
                }

                comboBoxCountry.SelectedItem = selectedCountry;

                textBoxHeadquarterZipCode.Text = listViewCorporateGuests.SelectedItems[0].SubItems[4].Text;
                textBoxHeadquarterCity.Text = listViewCorporateGuests.SelectedItems[0].SubItems[5].Text;
                textBoxHeadquarterAddress.Text = listViewCorporateGuests.SelectedItems[0].SubItems[6].Text;
                textBoxCompanyPhoneNumber.Text = listViewCorporateGuests.SelectedItems[0].SubItems[7].Text;
                textBoxCompanyEmailAddress.Text = listViewCorporateGuests.SelectedItems[0].SubItems[8].Text;
            }
            else
            {
                textBoxCompanyID.Clear();
                textBoxCompanyID.Text = nextID.ToString();
                textBoxCompanyName.Clear();
                textBoxVATNumber.Clear();
                comboBoxCountry.DataSource = null;
                comboBoxCountry.DataSource = countries;
                comboBoxCountry.SelectedItem = countries[0];
                textBoxHeadquarterZipCode.Clear();
                textBoxHeadquarterCity.Clear();
                textBoxHeadquarterAddress.Clear();
                textBoxCompanyPhoneNumber.Clear();
                textBoxCompanyEmailAddress.Clear();
            }
        }

        #endregion
    }
}
