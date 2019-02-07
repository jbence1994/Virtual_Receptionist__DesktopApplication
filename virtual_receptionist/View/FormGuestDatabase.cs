using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Vendégadatbázis-kezelő ablak
    /// </summary>
    public partial class FormGuestDatabase : Form
    {
        #region Adattagok

        /// <summary>
        /// Vendégadatbázis-kezelő prezenter egy példánya
        /// </summary>
        private GuestDatabasePresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő ablak konstruktora
        /// </summary>
        public FormGuestDatabase()
        {
            InitializeComponent();
            presenter = new GuestDatabasePresenter();
        }

        #endregion

        #region UI események

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            DataTable privateGuestDataTable = presenter.InitializePrivateGuests();
            DataTable corporateGuestDataTable = presenter.InitializeCorporateGuests();

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

            textBoxID.Text = presenter.GetNextID().ToString();
            textBoxCompanyID.Text = presenter.GetNextID().ToString();

            comboBoxCountry.DataSource = presenter.GetCountries();
            comboBoxHeadquarterCountry.DataSource = presenter.GetCountries();
        }

        private void buttonAddPrivateGuest_Click(object sender, EventArgs e)
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

            // Adatbázis rekord hozzáadása
            presenter.AddNewRecordToPrivateGuestTable(id, name, documentNumber, citizenship, birthDate, country,
                zipCode, city, address, phoneNumber, email);
        }

        private void buttonAddCorporateGuest_Click(object sender, EventArgs e)
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

            //Adatbázis rekord hozzáadása
            presenter.AddNewRecordToCorporateGuestTable(id, name, vatNumber, country, zipCode, city, address,
                phoneNumber, email);
        }

        private void buttonUpdatePrivateGuest_Click(object sender, EventArgs e)
        {
            if (listViewPrivateGuests.SelectedItems.Count > 0)
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

                // ListView rekord módosítása (GUI)
                textBoxID.Text = id.ToString();
                ListViewItem updatedRecord = new ListViewItem();
                updatedRecord.Text = id.ToString();
                updatedRecord.SubItems.Add(name);
                updatedRecord.SubItems.Add(documentNumber);
                updatedRecord.SubItems.Add(citizenship);
                updatedRecord.SubItems.Add(birthDate);
                updatedRecord.SubItems.Add(country);
                updatedRecord.SubItems.Add(zipCode);
                updatedRecord.SubItems.Add(city);
                updatedRecord.SubItems.Add(address);
                updatedRecord.SubItems.Add(phoneNumber);
                updatedRecord.SubItems.Add(email);

                int index = listViewPrivateGuests.FocusedItem.Index;
                listViewPrivateGuests.Items.RemoveAt(index);
                listViewPrivateGuests.Items.Insert(index, updatedRecord);

                // Adatbázis rekord módosítása
                presenter.UpdateRecordInPrivateGuestTable(id, name, documentNumber, citizenship, birthDate, country,
                    zipCode,
                    city, address, phoneNumber, email);
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateCorporateGuest_Click(object sender, EventArgs e)
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
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

                // ListView rekord módosítása (GUI)
                textBoxCompanyID.Text = id.ToString();
                ListViewItem updatedRecord = new ListViewItem();
                updatedRecord.Text = id.ToString();
                updatedRecord.SubItems.Add(name);
                updatedRecord.SubItems.Add(vatNumber);
                updatedRecord.SubItems.Add(country);
                updatedRecord.SubItems.Add(zipCode);
                updatedRecord.SubItems.Add(city);
                updatedRecord.SubItems.Add(address);
                updatedRecord.SubItems.Add(phoneNumber);
                updatedRecord.SubItems.Add(email);

                int index = listViewCorporateGuests.FocusedItem.Index;
                listViewCorporateGuests.Items.RemoveAt(index);
                listViewCorporateGuests.Items.Insert(index, updatedRecord);

                // Adatbázis rekord módosítása
                presenter.UpdateRecordInCorporateGuestTable(id, name, vatNumber, country, zipCode, city, address,
                    phoneNumber, email);
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeletePrivateGuest_Click(object sender, EventArgs e)
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
                    comboBoxCountry.DataSource = presenter.GetCountries();
                    comboBoxCountry.SelectedItem = presenter.GetCountries()[0];
                    textBoxZipCode.Clear();
                    textBoxCity.Clear();
                    textBoxAddress.Clear();
                    textBoxPhoneNumber.Clear();
                    textBoxEmailAddress.Clear();

                    //Adatbázis rekord törlése
                    presenter.DeleteRecordFromPrivateGuestTable(id, name, documentNumber, citizenship, birthDate,
                        country, zipCode, city, address, phoneNumber, email);
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteCorporateGuest_Click(object sender, EventArgs e)
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
                    comboBoxHeadquarterCountry.DataSource = presenter.GetCountries();
                    comboBoxHeadquarterCountry.SelectedItem = presenter.GetCountries()[0];

                    // Adatbázis rekord törlése
                    presenter.DeleteRecordFromCorporateGuestTable(id, name, vatNumber, country, zipCode, city, address,
                        phoneNumber, email);
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPrivateGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPrivateGuests.SelectedItems.Count > 0)
            {
                buttonAddPrivateGuest.Enabled = false;

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
                buttonAddPrivateGuest.Enabled = true;

                textBoxID.Clear();
                textBoxID.Text = presenter.GetNextID().ToString();
                textBoxName.Clear();
                textBoxDocumentID.Clear();
                textBoxCitizenship.Clear();
                textBoxBirthDate.Clear();
                comboBoxCountry.DataSource = null;
                comboBoxCountry.DataSource = presenter.GetCountries();
                comboBoxCountry.SelectedItem = presenter.GetCountries()[0];
                textBoxZipCode.Clear();
                textBoxCity.Clear();
                textBoxAddress.Clear();
                textBoxPhoneNumber.Clear();
                textBoxEmailAddress.Clear();
            }
        }

        private void listViewCorporateGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCorporateGuests.SelectedItems.Count > 0)
            {
                buttonAddCorporateGuest.Enabled = false;

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
                buttonAddCorporateGuest.Enabled = true;

                textBoxCompanyID.Clear();
                textBoxCompanyID.Text = presenter.GetNextID().ToString();
                textBoxCompanyName.Clear();
                textBoxVATNumber.Clear();
                comboBoxCountry.DataSource = null;
                comboBoxCountry.DataSource = presenter.GetCountries();
                comboBoxCountry.SelectedItem = presenter.GetCountries()[0];
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
