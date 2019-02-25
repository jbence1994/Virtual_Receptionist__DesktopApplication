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
            DataTable guests = presenter.GetGuests();
            DataTable corporateGuestDataTable = presenter.GetCompanies();

            foreach (DataRow row in guests.Rows)
            {
                ListViewItem privateGuests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < guests.Columns.Count; i++)
                {
                    privateGuests.SubItems.Add(row[i].ToString());
                }

                listViewGuest.Items.Add(privateGuests);
            }

            foreach (DataRow row in corporateGuestDataTable.Rows)
            {
                ListViewItem corporateGuests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < corporateGuestDataTable.Columns.Count; i++)
                {
                    corporateGuests.SubItems.Add(row[i].ToString());
                }

                listViewCompany.Items.Add(corporateGuests);
            }

            textBoxGuestID.Text = presenter.GetNextGuestID().ToString();
            textBoxCompanyID.Text = presenter.GetNextCompanyID().ToString();

            comboBoxCountry.DataSource = presenter.GetCountries();
            comboBoxHeadquarterCountry.DataSource = presenter.GetCountries();
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxGuestID.Text);
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
            textBoxGuestID.Text = id.ToString();
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
            listViewGuest.Items.Add(newRecord);

            // Adatbázis rekord hozzáadása
            presenter.AddNewRecordToGuestTable(id, name, documentNumber, citizenship, birthDate, country,
                zipCode, city, address, phoneNumber, email);
        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
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
            listViewCompany.Items.Add(newRecord);

            //Adatbázis rekord hozzáadása
            presenter.AddNewRecordToCompanyTable(id, name, vatNumber, country, zipCode, city, address,
                phoneNumber, email);
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                int id = int.Parse(textBoxGuestID.Text);
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
                textBoxGuestID.Text = id.ToString();
                ListViewItem updatedRecord = new ListViewItem();
                updatedRecord.Text = id.ToString();
                updatedRecord.SubItems.Add(name);
                updatedRecord.SubItems.Add(documentNumber);
                updatedRecord.SubItems.Add(citizenship);
                updatedRecord.SubItems.Add(birthDate.Replace('-', ' ').Replace(" ", ". ") + ".");
                updatedRecord.SubItems.Add(country);
                updatedRecord.SubItems.Add(zipCode);
                updatedRecord.SubItems.Add(city);
                updatedRecord.SubItems.Add(address);
                updatedRecord.SubItems.Add(phoneNumber);
                updatedRecord.SubItems.Add(email);

                int index = listViewGuest.FocusedItem.Index;
                listViewGuest.Items.RemoveAt(index);
                listViewGuest.Items.Insert(index, updatedRecord);

                // Adatbázis rekord módosítása
                presenter.UpdateRecordInGuestTable(id, name, documentNumber, citizenship, birthDate, country,
                    zipCode,
                    city, address, phoneNumber, email);
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateCompany_Click(object sender, EventArgs e)
        {
            if (listViewCompany.SelectedItems.Count > 0)
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

                int index = listViewCompany.FocusedItem.Index;
                listViewCompany.Items.RemoveAt(index);
                listViewCompany.Items.Insert(index, updatedRecord);

                // Adatbázis rekord módosítása
                presenter.UpdateRecordInCompanyTable(id, name, vatNumber, country, zipCode, city, address,
                    phoneNumber, email);
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteGuest_Click(object sender, EventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    int id = int.Parse(listViewGuest.SelectedItems[0].Text);
                    string name = listViewGuest.SelectedItems[0].SubItems[1].Text;
                    string documentNumber = listViewGuest.SelectedItems[0].SubItems[2].Text;
                    string citizenship = listViewGuest.SelectedItems[0].SubItems[3].Text;
                    string birthDate = listViewGuest.SelectedItems[0].SubItems[4].Text;
                    string country = comboBoxCountry.SelectedItem.ToString();
                    string zipCode = listViewGuest.SelectedItems[0].SubItems[6].Text;
                    string city = listViewGuest.SelectedItems[0].SubItems[7].Text;
                    string address = listViewGuest.SelectedItems[0].SubItems[8].Text;
                    string phoneNumber = listViewGuest.SelectedItems[0].SubItems[9].Text;
                    string email = listViewGuest.SelectedItems[0].SubItems[10].Text;

                    // ListView rekord törlés (GUI)
                    int index = listViewGuest.FocusedItem.Index;
                    listViewGuest.Items.RemoveAt(index);

                    //GUI vezérlők alaphelyzetbe állítása
                    textBoxGuestID.Clear();
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
                    presenter.DeleteRecordFromGuestTable(id, name, documentNumber, citizenship, birthDate,
                        country, zipCode, city, address, phoneNumber, email);
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteCompany_Click(object sender, EventArgs e)
        {
            if (listViewCompany.SelectedItems.Count > 0)
            {
                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    int id = int.Parse(listViewCompany.SelectedItems[0].Text);
                    string name = listViewCompany.SelectedItems[0].SubItems[1].Text;
                    string country = comboBoxHeadquarterCountry.SelectedItem.ToString();
                    string vatNumber = listViewCompany.SelectedItems[0].SubItems[2].Text;
                    string zipCode = listViewCompany.SelectedItems[0].SubItems[3].Text;
                    string city = listViewCompany.SelectedItems[0].SubItems[4].Text;
                    string address = listViewCompany.SelectedItems[0].SubItems[5].Text;
                    string phoneNumber = listViewCompany.SelectedItems[0].SubItems[6].Text;
                    string email = listViewCompany.SelectedItems[0].SubItems[7].Text;

                    // ListView rekord törlése (GUI)
                    int index = listViewCompany.FocusedItem.Index;
                    listViewCompany.Items.RemoveAt(index);

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
                    presenter.DeleteRecordFromCompanyTable(id, name, vatNumber, country, zipCode, city, address,
                        phoneNumber, email);
                }
            }
            else
            {
                MessageBox.Show("Nincs vendég kijelölve!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                buttonAddGuest.Enabled = false;

                textBoxGuestID.Text = listViewGuest.SelectedItems[0].Text;
                textBoxName.Text = listViewGuest.SelectedItems[0].SubItems[1].Text;
                textBoxDocumentID.Text = listViewGuest.SelectedItems[0].SubItems[2].Text;
                textBoxCitizenship.Text = listViewGuest.SelectedItems[0].SubItems[3].Text;
                textBoxBirthDate.Text = listViewGuest.SelectedItems[0].SubItems[4].Text.Replace(". ", "-")
                    .Replace(".", "");
                string selectedCountryInTable = listViewGuest.SelectedItems[0].SubItems[5].Text;
                comboBoxCountry.SelectedItem = presenter.SetSelectedCountry(selectedCountryInTable);

                textBoxZipCode.Text = listViewGuest.SelectedItems[0].SubItems[6].Text;
                textBoxCity.Text = listViewGuest.SelectedItems[0].SubItems[7].Text;
                textBoxAddress.Text = listViewGuest.SelectedItems[0].SubItems[8].Text;
                textBoxPhoneNumber.Text = listViewGuest.SelectedItems[0].SubItems[9].Text;
                textBoxEmailAddress.Text = listViewGuest.SelectedItems[0].SubItems[10].Text;
            }
            else
            {
                buttonAddGuest.Enabled = true;

                textBoxGuestID.Clear();
                textBoxGuestID.Text = presenter.GetNextGuestID().ToString();
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

        private void listViewCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCompany.SelectedItems.Count > 0)
            {
                buttonAddCompany.Enabled = false;

                textBoxCompanyID.Text = listViewCompany.SelectedItems[0].Text;
                textBoxCompanyName.Text = listViewCompany.SelectedItems[0].SubItems[1].Text;
                textBoxVATNumber.Text = listViewCompany.SelectedItems[0].SubItems[2].Text;

                string selectedCountryInTable = listViewCompany.SelectedItems[0].SubItems[3].Text;
                comboBoxHeadquarterCountry.SelectedItem = presenter.SetSelectedCountry(selectedCountryInTable);

                textBoxHeadquarterZipCode.Text = listViewCompany.SelectedItems[0].SubItems[4].Text;
                textBoxHeadquarterCity.Text = listViewCompany.SelectedItems[0].SubItems[5].Text;
                textBoxHeadquarterAddress.Text = listViewCompany.SelectedItems[0].SubItems[6].Text;
                textBoxCompanyPhoneNumber.Text = listViewCompany.SelectedItems[0].SubItems[7].Text;
                textBoxCompanyEmailAddress.Text = listViewCompany.SelectedItems[0].SubItems[8].Text;
            }
            else
            {
                buttonAddCompany.Enabled = true;

                textBoxCompanyID.Clear();
                textBoxCompanyID.Text = presenter.GetNextCompanyID().ToString();
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
