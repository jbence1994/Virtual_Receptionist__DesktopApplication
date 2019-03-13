using System.Windows.Forms;
using System;
using virtual_receptionist.Controllers;
using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Foglalási napló foglalás felvitelét vagy mdosítását segítő ablak
    /// </summary>
    public partial class FormBookingManager : Form
    {
        #region Adattagok

        /// <summary>
        /// Foglalási napló vezérlő egy példánya
        /// </summary>
        private BookingController bookingController;

        /// <summary>
        /// Vendégadatbázis-kezelő vezérlő egy példánya
        /// </summary>
        private GuestDatabaseController guestController;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló foglalás felvitelét vagy mdosítását segítő ablak konstruktora
        /// </summary>
        public FormBookingManager()
        {
            InitializeComponent();
            bookingController = new BookingController();
            guestController = new GuestDatabaseController();
        }

        #endregion

        #region UI események

        private void FormBookingManager_Load(object sender, EventArgs e)
        {
            textBoxGuestName.Select();
            comboBoxCountry.DataSource = bookingController.GetCountries();
            comboBoxRoom.DataSource = bookingController.GetRooms();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            /*
             * Vendégadatok validálása
             */

            bool validData = true;

            string name = textBoxGuestName.Text;

            try
            {
                bookingController.NameValidator(name);
            }
            catch (InvalidNameException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderName.SetError(textBoxGuestName, exception.Message);
                validData = false;
            }

            string documentNumber = textBoxDocumentNumber.Text;

            try
            {
                bookingController.DocumentNumberValidator(documentNumber);
            }
            catch (InvalidDocumentNumberException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderDocumentNumber.SetError(textBoxDocumentNumber, exception.Message);
                validData = false;
            }

            string citizenship = textBoxCitizenship.Text;

            try
            {
                bookingController.CitizenshipValidator(citizenship);
            }
            catch (InvalidCitizenshipException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderCitizenship.SetError(textBoxCitizenship, exception.Message);
                validData = false;
            }

            string birthDate = textBoxBirthDate.Text;

            try
            {
                bookingController.BirthDateValidator(birthDate);
            }
            catch (InvalidBirthDateException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderBirthDate.SetError(textBoxBirthDate, exception.Message);
                validData = false;
            }

            string zipCode = textBoxZipCode.Text;

            try
            {
                bookingController.ZipCodeValidator(zipCode);
            }
            catch (InvalidZipCodeException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderZipCode.SetError(textBoxZipCode, exception.Message);
                validData = false;
            }

            string city = textBoxCity.Text;

            try
            {
                bookingController.CityValidator(city);
            }
            catch (InvalidCityException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderCity.SetError(textBoxCity, exception.Message);
                validData = false;
            }

            string address = textBoxAddress.Text;

            try
            {
                bookingController.AddressValidator(address);
            }
            catch (InvalidAddressException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderAddress.SetError(textBoxAddress, exception.Message);
                validData = false;
            }

            string phoneNumber = textBoxPhoneNumber.Text;

            try
            {
                bookingController.PhoneNumberValidator(phoneNumber);
            }
            catch (InvalidPhoneNumberException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderPhoneNumber.SetError(textBoxPhoneNumber, exception.Message);
                validData = false;
            }

            string email = textBoxEmailAddress.Text;

            try
            {
                bookingController.EmailAddressValidator(email);
            }
            catch (InvalidEmailAddressException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderEmailAddress.SetError(textBoxEmailAddress, exception.Message);
                validData = false;
            }

            /*
             * Foglalásadatok validálása
             */

            string room = comboBoxRoom.SelectedItem.ToString();
            decimal numberOfGuests = numericUpDownNumberOfGuests.Value;
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            DateTime departureDate = dateTimePickerDepartureDate.Value;

            if (validData)
            {
                guestController.AddGuest(name);
                bookingController.AddNewBooking(name, room, numberOfGuests, arrivalDate, departureDate);
            }
        }

        private void textBoxGuestName_TextChanged(object sender, EventArgs e)
        {
            errorProviderName.Clear();
        }

        private void textBoxDocumentNumber_TextChanged(object sender, EventArgs e)
        {
            errorProviderDocumentNumber.Clear();
        }

        private void textBoxEmailAddress_TextChanged(object sender, EventArgs e)
        {
            errorProviderEmailAddress.Clear();
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

        private void textBoxCitizenship_TextChanged(object sender, EventArgs e)
        {
            errorProviderCitizenship.Clear();
        }

        #endregion
    }
}
