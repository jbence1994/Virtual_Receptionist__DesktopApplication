using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Repositories;

namespace virtual_receptionist.Views
{
    public partial class FormBooking : Form
    {
        private readonly BookingRepository bookingRepository = new BookingRepository();

        public FormBooking()
        {
            InitializeComponent();
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            var actualDate = dateTimePickerArrivalDate.Value;
            dataGridViewBookings.DataSource = GetBookingsByArrivalDate(actualDate);
        }

        private void dateTimePickerArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            var arrivalDate = dateTimePickerArrivalDate.Value;
            dataGridViewBookings.DataSource = GetBookingsByArrivalDate(arrivalDate);
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            var departureDate = dateTimePickerDepartureDate.Value;
            var bookingsByDeparture =
                bookingRepository.GetGuestBookingsByDepartureDate(departureDate.ToString("yyyy-MM-dd"));

            var bookingsDataTableByDeparture = new DataTable();
            bookingsDataTableByDeparture.Columns.Add("ID", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("GuestName", typeof(string));
            bookingsDataTableByDeparture.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("ArrivalDate", typeof(string));
            bookingsDataTableByDeparture.Columns.Add("DepartureDate", typeof(string));
            bookingsDataTableByDeparture.Columns.Add("Paid", typeof(bool));

            foreach (var booking in bookingsByDeparture)
            {
                bookingsDataTableByDeparture.Rows.Add(booking.Id, booking.Guest.Name, booking.Room.Number,
                    booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate, booking.IsPaid);
            }

            dataGridViewBookings.DataSource = bookingsDataTableByDeparture;
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            var formAddBooking = new FormAddBooking();

            if (formAddBooking.ShowDialog() == DialogResult.OK)
                MessageBox.Show
                (
                    "Foglalás sikeresen rögzítésre került!",
                    string.Empty,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                var id = dataGridViewBookings.SelectedRows[0].Cells[0].Value;
                var guest = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
                var room = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                var numberOfGuests = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                var arrivalDate = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
                var departureDate = dataGridViewBookings.SelectedRows[0].Cells[5].Value;

                var formUpdateBooking =
                    new FormUpdateBooking(id, guest, room, numberOfGuests, arrivalDate, departureDate);

                if (formUpdateBooking.ShowDialog() != DialogResult.OK)
                    return;

                var booking = formUpdateBooking.Booking;

                dataGridViewBookings.SelectedRows[0].Cells[0].Value = booking[0];
                dataGridViewBookings.SelectedRows[0].Cells[1].Value = booking[1];
                dataGridViewBookings.SelectedRows[0].Cells[2].Value = booking[2];
                dataGridViewBookings.SelectedRows[0].Cells[3].Value = booking[3];
                dataGridViewBookings.SelectedRows[0].Cells[4].Value = booking[4];
                dataGridViewBookings.SelectedRows[0].Cells[5].Value = booking[5];

                MessageBox.Show
                (
                    "A foglalás sikeresen módosult!",
                    string.Empty,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
                MessageBox.Show
                (
                    "Nincs kijelölt foglalás!",
                    string.Empty,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                var delete = MessageBox.Show("Biztosan törli a kijelölt foglalást?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete != DialogResult.Yes)
                    return;

                var id = dataGridViewBookings.SelectedRows[0].Cells[0].Value;

                var row = dataGridViewBookings.SelectedRows[0].Index;
                dataGridViewBookings.Rows.RemoveAt(row);

                bookingRepository.DeleteBooking(Convert.ToInt32(id));

                MessageBox.Show("A foglalás sikeresen törlésre került!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt foglalás!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetBookingsByArrivalDate(DateTime arrivalDate)
        {
            var arrival = arrivalDate.ToString("yyyy-MM-dd");
            var bookingsByArrival = bookingRepository.GetBookingsByArrivalDate(arrival);

            var bookingsDataTableByArrival = new DataTable();
            bookingsDataTableByArrival.Columns.Add("ID", typeof(int));
            bookingsDataTableByArrival.Columns.Add("GuestName", typeof(string));
            bookingsDataTableByArrival.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTableByArrival.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTableByArrival.Columns.Add("ArrivalDate", typeof(string));
            bookingsDataTableByArrival.Columns.Add("DepartureDate", typeof(string));
            bookingsDataTableByArrival.Columns.Add("Paid", typeof(bool));

            foreach (var booking in bookingsByArrival)
            {
                bookingsDataTableByArrival.Rows.Add(booking.Id, booking.Guest.Name, booking.Room.Number,
                    booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate, booking.IsPaid);
            }

            return bookingsDataTableByArrival;
        }
    }
}
