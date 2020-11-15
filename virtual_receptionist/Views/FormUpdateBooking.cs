using System;
using System.Windows.Forms;
using virtual_receptionist.Controllers;
using virtual_receptionist.Validation;

namespace virtual_receptionist.Views
{
    public partial class FormUpdateBooking : Form
    {
        private readonly BookingController bookingController = new BookingController();
        private readonly GuestDatabaseController guestController = new GuestDatabaseController();

        public object[] Booking { get; }

        public FormUpdateBooking(params object[] booking)
        {
            InitializeComponent();

            Booking = booking;
            textBoxBookingID.Text = booking[0].ToString();
            comboBoxGuest.DataSource = guestController.GetGuestNames();
            comboBoxGuest.SelectedItem = booking[1].ToString();
            dateTimePickerArrivalDate.Value = Convert.ToDateTime(booking[4]);
            dateTimePickerDepartureDate.Value = Convert.ToDateTime(booking[5]);
            comboBoxRoom.DataSource = bookingController.GetRooms();
            comboBoxRoom.SelectedItem = Convert.ToInt32(booking[2]);
            numericUpDownNumberOfGuests.Value = Convert.ToDecimal(booking[3]);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var validData = true;

            string id = textBoxBookingID.Text;
            string name = comboBoxGuest.SelectedItem.ToString();
            int roomNumber = Convert.ToInt32(comboBoxRoom.SelectedItem);
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            DateTime departureDate = dateTimePickerDepartureDate.Value;
            decimal numberOfGuests = numericUpDownNumberOfGuests.Value;

            try
            {
                errorProviderName.Clear();
                NameValidation.ValidateName(name);
            }
            catch (Exception exception)
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
            catch (Exception exception)
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
            catch (Exception exception)
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
            catch (Exception exception)
            {
                errorProviderNumberOfGuests.SetError(numericUpDownNumberOfGuests, exception.Message);
                DialogResult = DialogResult.None;
                validData = false;
            }

            if (!validData)
                return;

            Booking[0] = Convert.ToInt32(id);
            Booking[1] = comboBoxGuest.SelectedItem.ToString();
            Booking[2] = comboBoxRoom.SelectedItem;
            Booking[3] = numericUpDownNumberOfGuests.Value;
            Booking[4] = arrivalDate.ToString("yyyy-MM-dd");
            Booking[5] = departureDate.ToString("yyyy-MM-dd");

            bookingController.UpdateBooking(Booking);
        }

        private void numericUpDownNumberOfGuests_ValueChanged(object sender, EventArgs e)
        {
            errorProviderNumberOfGuests.Clear();
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            errorProviderDepartureDate.Clear();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderFreeCapacity.Clear();
        }
    }
}
