using System;
using System.Linq;
using System.Windows.Forms;
using virtual_receptionist.Models;
using virtual_receptionist.Repositories;
using virtual_receptionist.Validation;

namespace virtual_receptionist.Views
{
    public partial class FormUpdateBooking : Form
    {
        private readonly BookingRepository bookingRepository = new BookingRepository();
        private readonly RoomRepository roomRepository = new RoomRepository();
        private readonly GuestRepository guestRepository = new GuestRepository();

        public object[] Booking { get; }

        public FormUpdateBooking(params object[] booking)
        {
            InitializeComponent();

            Booking = booking;
            textBoxBookingID.Text = booking[0].ToString();

            comboBoxGuest.DataSource = guestRepository.GetGuests().Select(guest => guest.Name).ToList();

            comboBoxGuest.SelectedItem = booking[1].ToString();
            dateTimePickerArrivalDate.Value = Convert.ToDateTime(booking[4]);
            dateTimePickerDepartureDate.Value = Convert.ToDateTime(booking[5]);

            comboBoxRoom.DataSource = roomRepository.GetRooms().Select(room => room.Number).ToList();

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
                BookingDateValidator(arrivalDate, departureDate);
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
                FreeRoomCapacityValidator(arrivalDate, roomNumber);
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
                BookingCapacityValidator(numberOfGuests, roomNumber);
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

            UpdateBooking(Booking);
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

        public void UpdateBooking(params object[] bookingParameters)
        {
            var id = Convert.ToInt32(bookingParameters[0]);

            var guest = new Guest
            {
                Name = bookingParameters[1].ToString()
            };

            var room = new Room
            {
                Number = Convert.ToInt32(bookingParameters[2])
            };

            var numberOfGuests = Convert.ToInt32(bookingParameters[3]);

            var arrivalDate = Convert.ToDateTime(bookingParameters[4]).ToString("yyyy-MM-dd");

            var departureDate = Convert.ToDateTime(bookingParameters[5]).ToString("yyyy-MM-dd");

            var booking = new Booking
            {
                Id = id,
                Guest = guest,
                Room = room,
                NumberOfGuests = numberOfGuests,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate
            };

            bookingRepository.UpdateBooking(booking);
        }

        public void BookingDateValidator(DateTime arrivalDate, DateTime departureDate)
        {
            var booking = new Booking
            {
                ArrivalDate = arrivalDate.ToString(),
                DepartureDate = departureDate.ToString()
            };

            BookingDateValidation.ValidateBookingDate(booking);
        }

        public void BookingCapacityValidator(decimal numberOfGuests, int roomNumber)
        {
            var room = new Room
            {
                Capacity = roomRepository.GetRoomCapacity(roomNumber)
            };

            var booking = new Booking
            {
                NumberOfGuests = Convert.ToInt32(numberOfGuests),
                Room = room
            };

            BookingCapacityValidation.ValidateBookingCapacity(booking);
        }

        public void FreeRoomCapacityValidator(DateTime arrivalDate, int roomNumber)
        {
            var room = new Room
            {
                Number = roomNumber
            };

            var booking = new Booking
            {
                Room = room,
                ArrivalDate = arrivalDate.ToString("yyyy-MM-dd")
            };

            bookingRepository.ValidateFreeRoomCapacityOnSpecifiedArrivalDate(booking);
        }
    }
}
