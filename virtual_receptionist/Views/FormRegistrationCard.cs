using System;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Vendég bejelentkező lap ablak
    /// </summary>
    public partial class FormGuestRegistrationCard : Form
    {
        #region Adattagok

        /// <summary>
        /// Vendég bejelentkező lap vezérlő egy példánya
        /// </summary>
        private RegistrationCardController controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég bejelentkező lap ablak konstruktora
        /// </summary>
        public FormGuestRegistrationCard()
        {
            InitializeComponent();
            controller = new RegistrationCardController();
        }

        #endregion

        #region UI események

        private void FormGuestRegistrationCard_Load(object sender, EventArgs e)
        {
            textBoxName.Select();
            comboBoxCountry.DataSource = controller.GetCountries();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string citizenship = textBoxCitizenship.Text;
            string birthDate = textBoxBirthDate.Text;
            string documentNumber = textBoxDocumentNumber.Text;
            string country = comboBoxCountry.SelectedItem.ToString();
            string zipCode = textBoxZipCode.Text;
            string city = textBoxCity.Text;
            string address = textBoxAddress.Text;

            string phone = textBoxPhoneNumber.Text;
            string email = textBoxEmailAddress.Text;

            string room = comboBoxRoom.SelectedItem.ToString();
            int numberOfGuests = Convert.ToInt32(numericUpDownNumberOfGuests.Value);
            DateTime arrival = dateTimePickerArrivalDate.Value;
            DateTime departure = dateTimePickerDepartureDate.Value;

            controller.SaveData(name, citizenship, birthDate, documentNumber, country, zipCode, city, address, phone,
                email, room, numberOfGuests, arrival, departure);
        }

        #endregion
    }
}
