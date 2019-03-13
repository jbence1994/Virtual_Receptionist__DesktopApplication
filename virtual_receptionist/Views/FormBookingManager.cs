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
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool validData = true;

            string name = textBoxGuestName.Text;

            try
            {
                bookingController.NameValidator(name);
            }
            catch (InvalidNameException exception)
            {
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
                errorProviderDocumentNumber.SetError(textBoxDocumentNumber, exception.Message);
                validData = false;
            }

            string citizenship = textBoxCitizenship.Text;

            try
            {
                bookingController.CitizenShipValidator(citizenship);
            }
            catch (InvalidCitizenshipException exception)
            {
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
                errorProviderZipCode.SetError(textBoxZipCode, exception.Message);
                validData = false;
            }

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

        #endregion
    }
}
