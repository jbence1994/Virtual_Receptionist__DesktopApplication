using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

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
                ListViewItem privateGuests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < guests.Columns.Count; i++)
                {
                    privateGuests.SubItems.Add(row[i].ToString());
                }

                listViewGuest.Items.Add(privateGuests);
            }

            textBoxGuestID.Text = controller.GetNextGuestID();
            comboBoxGuestCountry.DataSource = controller.GetCountries();
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxGuestID.Text);
            string name = textBoxGuestName.Text;
            string documentNumber = textBoxGuestDocumentNumber.Text;
            string citizenship = textBoxGuestCitizenship.Text;
            string birthDate = textBoxGuestBirthDate.Text;
            string country = comboBoxGuestCountry.SelectedItem.ToString();
            string zipCode = textBoxGuestZipCode.Text;
            string city = textBoxGuestCity.Text;
            string address = textBoxGuestAddress.Text;
            string phoneNumber = textBoxGuestPhoneNumber.Text;
            string email = textBoxGuestEmailAddress.Text;

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
            controller.AddNewRecordToGuestTable(id, name, documentNumber, citizenship, birthDate, country,
                zipCode, city, address, phoneNumber, email);
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                int id = int.Parse(textBoxGuestID.Text);
                string name = textBoxGuestName.Text;
                string documentNumber = textBoxGuestDocumentNumber.Text;
                string citizenship = textBoxGuestCitizenship.Text;
                string birthDate = textBoxGuestBirthDate.Text;
                string country = comboBoxGuestCountry.SelectedItem.ToString();
                string zipCode = textBoxGuestZipCode.Text;
                string city = textBoxGuestCity.Text;
                string address = textBoxGuestAddress.Text;
                string phoneNumber = textBoxGuestPhoneNumber.Text;
                string email = textBoxGuestEmailAddress.Text;

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
                controller.UpdateRecordInGuestTable(id, name, documentNumber, citizenship, birthDate, country,
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
                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt vendéget?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    int id = int.Parse(listViewGuest.SelectedItems[0].Text);
                    string name = listViewGuest.SelectedItems[0].SubItems[1].Text;
                    string documentNumber = listViewGuest.SelectedItems[0].SubItems[2].Text;
                    string citizenship = listViewGuest.SelectedItems[0].SubItems[3].Text;
                    string birthDate = listViewGuest.SelectedItems[0].SubItems[4].Text;
                    string country = comboBoxGuestCountry.SelectedItem.ToString();
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
                    textBoxGuestName.Clear();
                    textBoxGuestDocumentNumber.Clear();
                    textBoxGuestCitizenship.Clear();
                    textBoxGuestBirthDate.Clear();
                    comboBoxGuestCountry.DataSource = null;
                    comboBoxGuestCountry.DataSource = controller.GetCountries();
                    comboBoxGuestCountry.SelectedItem = controller.GetCountries()[0];
                    textBoxGuestZipCode.Clear();
                    textBoxGuestCity.Clear();
                    textBoxGuestAddress.Clear();
                    textBoxGuestPhoneNumber.Clear();
                    textBoxGuestEmailAddress.Clear();

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

                textBoxGuestID.Text = listViewGuest.SelectedItems[0].Text;
                textBoxGuestName.Text = listViewGuest.SelectedItems[0].SubItems[1].Text;
                textBoxGuestDocumentNumber.Text = listViewGuest.SelectedItems[0].SubItems[2].Text;
                textBoxGuestCitizenship.Text = listViewGuest.SelectedItems[0].SubItems[3].Text;
                textBoxGuestBirthDate.Text = listViewGuest.SelectedItems[0].SubItems[4].Text.Replace(". ", "-")
                    .Replace(".", "");
                string selectedCountryInTable = listViewGuest.SelectedItems[0].SubItems[5].Text;
                comboBoxGuestCountry.SelectedItem = controller.SetSelectedCountry(selectedCountryInTable);

                textBoxGuestZipCode.Text = listViewGuest.SelectedItems[0].SubItems[6].Text;
                textBoxGuestCity.Text = listViewGuest.SelectedItems[0].SubItems[7].Text;
                textBoxGuestAddress.Text = listViewGuest.SelectedItems[0].SubItems[8].Text;
                textBoxGuestPhoneNumber.Text = listViewGuest.SelectedItems[0].SubItems[9].Text;
                textBoxGuestEmailAddress.Text = listViewGuest.SelectedItems[0].SubItems[10].Text;
            }
            else
            {
                buttonAddGuest.Enabled = true;

                textBoxGuestID.Clear();
                textBoxGuestID.Text = controller.GetNextGuestID().ToString();
                textBoxGuestName.Clear();
                textBoxGuestDocumentNumber.Clear();
                textBoxGuestCitizenship.Clear();
                textBoxGuestBirthDate.Clear();
                comboBoxGuestCountry.DataSource = null;
                comboBoxGuestCountry.DataSource = controller.GetCountries();
                comboBoxGuestCountry.SelectedItem = controller.GetCountries()[0];
                textBoxGuestZipCode.Clear();
                textBoxGuestCity.Clear();
                textBoxGuestAddress.Clear();
                textBoxGuestPhoneNumber.Clear();
                textBoxGuestEmailAddress.Clear();
            }
        }

        #endregion
    }
}
