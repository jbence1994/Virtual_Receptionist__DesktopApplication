using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Controllers;
using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Vendégadatbázis-kezelő ablak
    /// </summary>
    public partial class FormGuestDatabase : Form
    {
        #region Adattagok

        /// <summary>
        /// Vendégadatbázis-kezelő modul vezérlő egy példánya
        /// </summary>
        private GuestDatabaseController controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő ablak konstruktora
        /// </summary>
        public FormGuestDatabase()
        {
            InitializeComponent();
            controller = new GuestDatabaseController();
        }

        #endregion

        #region UI események

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            DataTable guests = controller.GetGuests();

            foreach (DataRow row in guests.Rows)
            {
                ListViewItem listViewItemGuests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < guests.Columns.Count; i++)
                {
                    listViewItemGuests.SubItems.Add(row[i].ToString());
                }

                listViewGuest.Items.Add(listViewItemGuests);
            }

            textBoxID.Text = controller.GetNextGuestID();
            comboBoxCountry.DataSource = controller.GetCountries();
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
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
                // Adatbázis rekord hozzáadása
                controller.AddNewRecordToGuestTable(id, name, documentNumber, citizenship, birthDate, country,
                    zipCode, city, address, phoneNumber, email);

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
                listViewGuest.Items.Add(newRecord);

            }
            catch (InvalidNameException exception)
            {
                errorProviderName.SetError(textBoxName, exception.Message);
            }
            catch (InvalidDocumentNumberException exception)
            {
                errorProviderDocumentNumber.SetError(textBoxDocumentNumber, exception.Message);
            }
            catch (InvalidCitizenshipException exception)
            {
                errorProviderCitizenship.SetError(textBoxCitizenship, exception.Message);
            }
            catch (InvalidBirthDateException exception)
            {
                errorProviderBirthDate.SetError(textBoxBirthDate, exception.Message);
            }
            catch (InvalidZipCodeException exception)
            {
                errorProviderZipCode.SetError(textBoxZipCode, exception.Message);
            }
            catch (InvalidCityException exception)
            {
                errorProviderCity.SetError(textBoxCity, exception.Message);
            }
            catch (InvalidAddressException exception)
            {
                errorProviderAddress.SetError(textBoxAddress, exception.Message);
            }
            catch (InvalidPhoneNumberException exception)
            {
                errorProviderPhoneNumber.SetError(textBoxPhoneNumber, exception.Message);
            }
            catch (InvalidEmailAddressException exception)
            {
                errorProviderEmailAddress.SetError(textBoxEmailAddress, exception.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ismeretlen hiba történt!");
            }
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                int id = int.Parse(textBoxID.Text);
                string name = textBoxName.Text;
                string documentNumber = textBoxDocumentNumber.Text;
                string citizenship = textBoxCitizenship.Text;
                string birthDate = textBoxBirthDate.Text;
                string country = comboBoxCountry.SelectedItem.ToString();
                string zipCode = textBoxZipCode.Text;
                string city = textBoxCity.Text;
                string address = textBoxAddress.Text;
                string phoneNumber = textBoxPhoneNumber.Text;
                string email = textBoxEmailAddress.Text;

                try
                {
                    // Adatbázis rekord módosítása
                    controller.UpdateRecordInGuestTable(id, name, documentNumber, citizenship, birthDate, country,
                        zipCode,
                        city, address, phoneNumber, email);

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

                    int index = listViewGuest.FocusedItem.Index;
                    listViewGuest.Items.RemoveAt(index);
                    listViewGuest.Items.Insert(index, updatedRecord);
                }
                catch (InvalidNameException exception)
                {
                    errorProviderName.SetError(textBoxName, exception.Message);
                }
                catch (InvalidDocumentNumberException exception)
                {
                    errorProviderDocumentNumber.SetError(textBoxDocumentNumber, exception.Message);
                }
                catch (InvalidCitizenshipException exception)
                {
                    errorProviderCitizenship.SetError(textBoxCitizenship, exception.Message);
                }
                catch (InvalidBirthDateException exception)
                {
                    errorProviderBirthDate.SetError(textBoxBirthDate, exception.Message);
                }
                catch (InvalidZipCodeException exception)
                {
                    errorProviderZipCode.SetError(textBoxZipCode, exception.Message);
                }
                catch (InvalidCityException exception)
                {
                    errorProviderCity.SetError(textBoxCity, exception.Message);
                }
                catch (InvalidAddressException exception)
                {
                    errorProviderAddress.SetError(textBoxAddress, exception.Message);
                }
                catch (InvalidPhoneNumberException exception)
                {
                    errorProviderPhoneNumber.SetError(textBoxPhoneNumber, exception.Message);
                }
                catch (InvalidEmailAddressException exception)
                {
                    errorProviderEmailAddress.SetError(textBoxEmailAddress, exception.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ismeretlen hiba történt!");
                }
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
                    textBoxID.Clear();
                    textBoxName.Clear();
                    textBoxDocumentNumber.Clear();
                    textBoxCitizenship.Clear();
                    textBoxBirthDate.Clear();
                    comboBoxCountry.DataSource = null;
                    comboBoxCountry.DataSource = controller.GetCountries();
                    comboBoxCountry.SelectedItem = controller.GetCountries()[0];
                    textBoxZipCode.Clear();
                    textBoxCity.Clear();
                    textBoxAddress.Clear();
                    textBoxPhoneNumber.Clear();
                    textBoxEmailAddress.Clear();

                    //Adatbázis rekord törlése
                    controller.DeleteRecordFromGuestTable(id, name, documentNumber, citizenship, birthDate,
                        country, zipCode, city, address, phoneNumber, email);
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

                textBoxID.Text = listViewGuest.SelectedItems[0].Text;
                textBoxName.Text = listViewGuest.SelectedItems[0].SubItems[1].Text;
                textBoxDocumentNumber.Text = listViewGuest.SelectedItems[0].SubItems[2].Text;
                textBoxCitizenship.Text = listViewGuest.SelectedItems[0].SubItems[3].Text;
                textBoxBirthDate.Text = listViewGuest.SelectedItems[0].SubItems[4].Text;
                string selectedCountryInTable = listViewGuest.SelectedItems[0].SubItems[5].Text;
                comboBoxCountry.SelectedItem = controller.SetSelectedCountry(selectedCountryInTable);

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
                textBoxID.Text = controller.GetNextGuestID().ToString();
                textBoxName.Clear();
                textBoxDocumentNumber.Clear();
                textBoxCitizenship.Clear();
                textBoxBirthDate.Clear();
                comboBoxCountry.DataSource = null;
                comboBoxCountry.DataSource = controller.GetCountries();
                comboBoxCountry.SelectedItem = controller.GetCountries()[0];
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
            errorProviderEmailAddress.Clear();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            errorProviderPhoneNumber.Clear();
        }

        private void textBoxEmailAddress_TextChanged(object sender, EventArgs e)
        {
            errorProviderEmailAddress.Clear();
        }

        #endregion
    }
}
