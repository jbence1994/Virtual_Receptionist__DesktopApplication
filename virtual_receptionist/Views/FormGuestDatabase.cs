using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using virtual_receptionist.Models;
using virtual_receptionist.Repositories;
using virtual_receptionist.Validation;

namespace virtual_receptionist.Views
{
    public partial class FormGuestDatabase : Form
    {
        private readonly CountryRepository countryRepository = new CountryRepository();
        private readonly GuestRepository guestRepository = new GuestRepository();

        public FormGuestDatabase()
        {
            InitializeComponent();
        }

        public DataTable GetGuests()
        {
            var guestDataTable = new DataTable();
            guestDataTable.Columns.Add("ID", typeof(int));
            guestDataTable.Columns.Add("Name", typeof(string));
            guestDataTable.Columns.Add("DocumentNumber", typeof(string));
            guestDataTable.Columns.Add("Citizenship", typeof(string));
            guestDataTable.Columns.Add("BirthDate", typeof(string));
            guestDataTable.Columns.Add("Country", typeof(string));
            guestDataTable.Columns.Add("ZipCode", typeof(string));
            guestDataTable.Columns.Add("City", typeof(string));
            guestDataTable.Columns.Add("Address", typeof(string));
            guestDataTable.Columns.Add("PhoneNumber", typeof(string));
            guestDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (var guest in guestRepository.GetGuests())
            {
                guestDataTable.Rows.Add(guest.Id, guest.Name, guest.DocumentNumber,
                    guest.Citizenship, guest.BirthDate, guest.Country, guest.ZipCode,
                    guest.City, guest.Address, guest.PhoneNumber, guest.EmailAddress);
            }

            return guestDataTable;
        }

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            var guests = GetGuests();

            foreach (DataRow row in guests.Rows)
            {
                var listViewItemGuests = new ListViewItem(row[0].ToString());

                for (var i = 1; i < guests.Columns.Count; i++)
                    listViewItemGuests.SubItems.Add(row[i].ToString());

                listViewGuest.Items.Add(listViewItemGuests);
            }

            textBoxID.Text = guestRepository.GetNextGuestId().ToString();
            comboBoxCountry.DataSource = countryRepository.GetCountries().Select(country => country.Name).ToList();
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            bool validData = true;

            int id = int.Parse(textBoxID.Text);
            string name = textBoxName.Text;
            string documentNumber = textBoxDocumentNumber.Text;
            string birthDate = textBoxBirthDate.Text;
            string citizenship = textBoxCitizenship.Text;
            string country = comboBoxCountry.SelectedItem.ToString();
            string zipCode = textBoxZipCode.Text;
            string city = textBoxCity.Text;
            string address = textBoxAddress.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string email = textBoxEmailAddress.Text;

            try
            {
                NameValidation.ValidateName(name);
            }
            catch (Exception exception)
            {
                errorProviderName.SetError(textBoxName, exception.Message);
                validData = false;
            }

            try
            {
                DocumentNumberValidation.ValidateDocumentNumber(documentNumber);
            }
            catch (Exception exception)
            {
                errorProviderDocumentNumber.SetError(textBoxDocumentNumber, exception.Message);
                validData = false;
            }

            try
            {
                CitizenshipValidation.ValidateCitizenship(citizenship);
            }
            catch (Exception exception)
            {
                errorProviderCitizenship.SetError(textBoxCitizenship, exception.Message);
                validData = false;
            }

            try
            {
                BirthDateValidation.ValidateBirthDate(birthDate);
            }
            catch (Exception exception)
            {
                errorProviderBirthDate.SetError(textBoxBirthDate, exception.Message);
                validData = false;
            }

            try
            {
                ZipCodeValidation.ValidateZipCode(zipCode);
            }
            catch (Exception exception)
            {
                errorProviderZipCode.SetError(textBoxZipCode, exception.Message);
                validData = false;
            }

            try
            {
                CityValidation.ValidateCity(city);
            }
            catch (Exception exception)
            {
                errorProviderCity.SetError(textBoxCity, exception.Message);
                validData = false;
            }

            try
            {
                AddressValidation.ValidateAddress(address);
            }
            catch (Exception exception)
            {
                errorProviderAddress.SetError(textBoxAddress, exception.Message);
                validData = false;
            }

            try
            {
                PhoneNumberValidation.ValidatePhoneNumber(phoneNumber);
            }
            catch (Exception exception)
            {
                errorProviderPhoneNumber.SetError(textBoxPhoneNumber, exception.Message);
                validData = false;
            }

            try
            {
                EmailValidation.ValidateEmail(email);
            }
            catch (Exception exception)
            {
                errorProviderEmailAddress.SetError(textBoxEmailAddress, exception.Message);
                validData = false;
            }

            if (!validData)
                return;

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
            listViewGuest.Items.Add(newRecord);

            AddGuest(id, name, documentNumber, citizenship, birthDate, country,
                zipCode, city, address, phoneNumber, email);
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                var validData = true;

                int id = int.Parse(textBoxID.Text);
                string name = textBoxName.Text;
                string documentNumber = textBoxDocumentNumber.Text;
                string birthDate = textBoxBirthDate.Text;
                string citizenship = textBoxCitizenship.Text;
                string country = comboBoxCountry.SelectedItem.ToString();
                string zipCode = textBoxZipCode.Text;
                string city = textBoxCity.Text;
                string address = textBoxAddress.Text;
                string phoneNumber = textBoxPhoneNumber.Text;
                string email = textBoxEmailAddress.Text;

                try
                {
                    NameValidation.ValidateName(name);
                }
                catch (Exception exception)
                {
                    errorProviderName.SetError(textBoxName, exception.Message);
                    validData = false;
                }

                try
                {
                    DocumentNumberValidation.ValidateDocumentNumber(documentNumber);
                }
                catch (Exception exception)
                {
                    errorProviderDocumentNumber.SetError(textBoxDocumentNumber, exception.Message);
                    validData = false;
                }

                try
                {
                    CitizenshipValidation.ValidateCitizenship(citizenship);
                }
                catch (Exception exception)
                {
                    errorProviderCitizenship.SetError(textBoxCitizenship, exception.Message);
                    validData = false;
                }

                try
                {
                    BirthDateValidation.ValidateBirthDate(birthDate);
                }
                catch (Exception exception)
                {
                    errorProviderBirthDate.SetError(textBoxBirthDate, exception.Message);
                    validData = false;
                }

                try
                {
                    ZipCodeValidation.ValidateZipCode(zipCode);
                }
                catch (Exception exception)
                {
                    errorProviderZipCode.SetError(textBoxZipCode, exception.Message);
                    validData = false;
                }

                try
                {
                    CityValidation.ValidateCity(city);
                }
                catch (Exception exception)
                {
                    errorProviderCity.SetError(textBoxCity, exception.Message);
                    validData = false;
                }

                try
                {
                    AddressValidation.ValidateAddress(address);
                }
                catch (Exception exception)
                {
                    errorProviderAddress.SetError(textBoxAddress, exception.Message);
                    validData = false;
                }

                try
                {
                    PhoneNumberValidation.ValidatePhoneNumber(phoneNumber);
                }
                catch (Exception exception)
                {
                    errorProviderPhoneNumber.SetError(textBoxPhoneNumber, exception.Message);
                    validData = false;
                }

                try
                {
                    EmailValidation.ValidateEmail(email);
                }
                catch (Exception exception)
                {
                    errorProviderEmailAddress.SetError(textBoxEmailAddress, exception.Message);
                    validData = false;
                }

                if (!validData)
                    return;

                textBoxID.Text = id.ToString();
                var updatedRecord = new ListViewItem {Text = id.ToString()};
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

                var index = listViewGuest.FocusedItem.Index;
                listViewGuest.Items.RemoveAt(index);
                listViewGuest.Items.Insert(index, updatedRecord);

                UpdateGuest(id, name, documentNumber, citizenship, birthDate, country,
                    zipCode,
                    city, address, phoneNumber, email);
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
                var delete = MessageBox.Show(
                    "Biztosan törli a kijelölt vendéget?\nA művelettel a vendéghez tartozó foglalások adatai is törlődnek az adatbázisból és a művelet nem vonható vissza!",
                    "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete != DialogResult.Yes)
                    return;

                var id = int.Parse(listViewGuest.SelectedItems[0].Text);

                var index = listViewGuest.FocusedItem.Index;
                listViewGuest.Items.RemoveAt(index);

                textBoxID.Clear();
                textBoxName.Clear();
                textBoxDocumentNumber.Clear();
                textBoxCitizenship.Clear();
                textBoxBirthDate.Clear();
                comboBoxCountry.DataSource = null;
                comboBoxCountry.DataSource = countryRepository.GetCountries().Select(c => c.Name).ToList();
                comboBoxCountry.SelectedItem = countryRepository.GetCountries().Select(c => c.Name).ToList()[0];
                textBoxZipCode.Clear();
                textBoxCity.Clear();
                textBoxAddress.Clear();
                textBoxPhoneNumber.Clear();
                textBoxEmailAddress.Clear();

                guestRepository.DeleteGuest(id);
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

                textBoxID.Text = listViewGuest.SelectedItems[0].Text;
                textBoxName.Text = listViewGuest.SelectedItems[0].SubItems[1].Text;
                textBoxDocumentNumber.Text = listViewGuest.SelectedItems[0].SubItems[2].Text;
                textBoxCitizenship.Text = listViewGuest.SelectedItems[0].SubItems[3].Text;
                textBoxBirthDate.Text = listViewGuest.SelectedItems[0].SubItems[4].Text;
                var selectedCountryInTable = listViewGuest.SelectedItems[0].SubItems[5].Text;
                comboBoxCountry.SelectedItem = SetSelectedCountry(selectedCountryInTable);

                textBoxZipCode.Text = listViewGuest.SelectedItems[0].SubItems[6].Text;
                textBoxCity.Text = listViewGuest.SelectedItems[0].SubItems[7].Text;
                textBoxAddress.Text = listViewGuest.SelectedItems[0].SubItems[8].Text;
                textBoxPhoneNumber.Text = listViewGuest.SelectedItems[0].SubItems[9].Text;
                textBoxEmailAddress.Text = listViewGuest.SelectedItems[0].SubItems[10].Text;
            }
            else
            {
                buttonAddGuest.Enabled = true;

                textBoxID.Clear();
                textBoxID.Text = guestRepository.GetNextGuestId().ToString();
                textBoxName.Clear();
                textBoxDocumentNumber.Clear();
                textBoxCitizenship.Clear();
                textBoxBirthDate.Clear();
                comboBoxCountry.DataSource = null;
                comboBoxCountry.DataSource = countryRepository.GetCountries().Select(country => country.Name).ToList();
                comboBoxCountry.SelectedItem =
                    countryRepository.GetCountries().Select(country => country.Name).ToList()[0];
                textBoxZipCode.Clear();
                textBoxCity.Clear();
                textBoxAddress.Clear();
                textBoxPhoneNumber.Clear();
                textBoxEmailAddress.Clear();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            errorProviderName.Clear();
        }

        private void textBoxDocumentNumber_TextChanged(object sender, EventArgs e)
        {
            errorProviderDocumentNumber.Clear();
        }

        private void textBoxCitizenship_TextChanged(object sender, EventArgs e)
        {
            errorProviderCitizenship.Clear();
        }

        private void textBoxBirthDate_TextChanged(object sender, EventArgs e)
        {
            errorProviderBirthDate.Clear();
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            errorProviderZipCode.Clear();
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            errorProviderCity.Clear();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            errorProviderPhoneNumber.Clear();
        }

        private void textBoxEmailAddress_TextChanged(object sender, EventArgs e)
        {
            errorProviderEmailAddress.Clear();
        }

        public void UpdateGuest(params object[] guestParameters)
        {
            var id = int.Parse(guestParameters[0].ToString());
            var name = guestParameters[1].ToString();
            var documentNumber = guestParameters[2].ToString();
            var citizenship = guestParameters[3].ToString();
            var birthDate = guestParameters[4].ToString();
            var country = guestParameters[5].ToString();
            var zipCode = guestParameters[6].ToString();
            var city = guestParameters[7].ToString();
            var address = guestParameters[8].ToString();
            var phoneNumber = guestParameters[9].ToString();
            var email = guestParameters[10].ToString();

            var guest = new Guest
            {
                Id = id,
                Name = name,
                DocumentNumber = documentNumber,
                Citizenship = citizenship,
                BirthDate = birthDate,
                Country = country,
                ZipCode = zipCode,
                City = city,
                Address = address,
                PhoneNumber = phoneNumber,
                EmailAddress = email
            };

            guestRepository.UpdateGuest(guest);
        }

        public string SetSelectedCountry(string selectedCountryInTable)
        {
            var countryRepository = new CountryRepository();

            var countyNames = countryRepository.GetCountries().Select(country => country.Name).ToList();

            string selectedCountry = null;

            foreach (var country in countyNames.Where(selectedCountryInTable.Contains))
                selectedCountry = country;

            return selectedCountry;
        }

        public void AddGuest(params object[] guestParameters)
        {
            var name = guestParameters[0].ToString();
            var documentNumber = guestParameters[1].ToString();
            var citizenship = guestParameters[2].ToString();
            var birthDate = guestParameters[3].ToString();
            var country = guestParameters[4].ToString();
            var zipCode = guestParameters[5].ToString();
            var city = guestParameters[6].ToString();
            var address = guestParameters[7].ToString();
            var phoneNumber = guestParameters[8].ToString();
            var email = guestParameters[9].ToString();

            var guest = new Guest
            {
                Name = name,
                DocumentNumber = documentNumber,
                Citizenship = citizenship,
                BirthDate = birthDate,
                Country = country,
                ZipCode = zipCode,
                City = city,
                Address = address,
                PhoneNumber = phoneNumber,
                EmailAddress = email
            };

            guestRepository.AddGuest(guest);
        }
    }
}
