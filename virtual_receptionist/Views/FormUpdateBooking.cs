using System;
using System.Windows.Forms;
using virtual_receptionist.Controllers;
using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Foglalási napló foglalásmódosítás modális ablak
    /// </summary>
    public partial class FormUpdateBooking : Form
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

        /// <summary>
        /// Foglalás adatai
        /// </summary>
        private object[] booking;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló foglalásmódosítás modális ablak konstruktora
        /// </summary>
        /// <param name="booking">Foglalás adatai</param>
        public FormUpdateBooking(params object[] booking)
        {
            InitializeComponent();

            bookingController = new BookingController();
            guestController = new GuestDatabaseController();

            this.booking = booking;
            textBoxBookingID.Text = booking[0].ToString();
            comboBoxGuest.DataSource = guestController.GetGuestNames();
            comboBoxGuest.SelectedItem = booking[1].ToString();
            dateTimePickerArrivalDate.Value = Convert.ToDateTime(booking[4]);
            dateTimePickerDepartureDate.Value = Convert.ToDateTime(booking[5]);
            comboBoxRoom.DataSource = bookingController.GetRooms();
            comboBoxRoom.SelectedItem = Convert.ToInt32(booking[2]);
            numericUpDownNumberOfGuests.Value = Convert.ToDecimal(booking[3]);
        }

        #endregion

        #region UI események

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool validData = true;

            /*
             * Foglalásadatok validálása
             */

            string id = textBoxBookingID.Text;
            string name = comboBoxGuest.SelectedItem.ToString();
            int roomNumber = Convert.ToInt32(comboBoxRoom.SelectedItem);
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            DateTime departureDate = dateTimePickerDepartureDate.Value;
            decimal numberOfGuests = numericUpDownNumberOfGuests.Value;

            try
            {
                errorProviderName.Clear();
                bookingController.NameValidator(name);
            }
            catch (InvalidNameException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderName.SetError(comboBoxGuest, exception.Message);
                validData = false;
            }

            try
            {
                errorProviderDepartureDate.Clear();
                bookingController.BookingDateValidator(arrivalDate, departureDate);
            }
            catch (InvalidBookingParameterException exception)
            {
                errorProviderDepartureDate.SetError(dateTimePickerDepartureDate, exception.Message);
                DialogResult = DialogResult.None;
                validData = false;
            }

            try
            {
                errorProviderFreeCapacity.Clear();
                bookingController.FreeRoomCapacityValidator(arrivalDate, roomNumber);
            }
            catch (InvalidFreeRoomCapacityException exception)
            {
                errorProviderFreeCapacity.SetError(comboBoxRoom, exception.Message);
                DialogResult = DialogResult.None;
                validData = false;
            }

            try
            {
                errorProviderNumberOfGuests.Clear();
                bookingController.BookingCapacityValidator(numberOfGuests, roomNumber);
            }
            catch (InvalidBookingParameterException exception)
            {
                errorProviderNumberOfGuests.SetError(numericUpDownNumberOfGuests, exception.Message);
                DialogResult = DialogResult.None;
                validData = false;
            }

            if (validData)
            {
                booking[0] = Convert.ToInt32(id);
                booking[1] = comboBoxGuest.SelectedItem.ToString();
                booking[2] = comboBoxRoom.SelectedItem;
                booking[3] = numericUpDownNumberOfGuests.Value;
                booking[4] = arrivalDate.ToString("yyyy-MM-dd");
                booking[5] = departureDate.ToString("yyyy-MM-dd");

                bookingController.UpdateBooking(booking);
            }
        }

        private void numericUpDownNumberOfGuests_ValueChanged(object sender, EventArgs e)
        {
            errorProviderNumberOfGuests.Clear();
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            errorProviderDepartureDate.Clear();
        }

        private void textBoxGuestName_TextChanged(object sender, EventArgs e)
        {
            errorProviderNumberOfGuests.Clear();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderFreeCapacity.Clear();
        }

        /// <summary>
        /// Foglalás adatai
        /// </summary>
        public object[] Booking
        {
            get { return booking; }
        }

        #endregion
    }
}
