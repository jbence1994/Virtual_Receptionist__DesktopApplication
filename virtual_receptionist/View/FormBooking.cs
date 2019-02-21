using System;
using System.Diagnostics;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Foglalási napló ablak
    /// </summary>
    public partial class FormBooking : Form
    {
        #region Adattagok

        /// <summary>
        /// Foglalási napló modul prezenter egy példánya
        /// </summary>
        private BookingPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló ablak konstruktora
        /// </summary>
        public FormBooking()
        {
            InitializeComponent();
            presenter = new BookingPresenter();
        }

        #endregion

        #region UI események

        private void FormBooking_Load(object sender, EventArgs e)
        {
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            dataGridViewBookings.DataSource = presenter.GetBookingsByArrivalDate(arrivalDate);
            dataGridViewRooms.DataSource = presenter.GetRooms();
        }

        private void dateTimePickerArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            dataGridViewBookings.DataSource = presenter.GetBookingsByArrivalDate(arrivalDate);
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime departureDate = dateTimePickerDepartureDate.Value;
            dataGridViewBookings.DataSource = presenter.GetBookingsByDepartureDate(departureDate);
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                object guest = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[3].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[3].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[3].Value);

                presenter.AddNewRecordToBookingTable(guest, room, numberOfGuests, arrivalDate, departureDate);
            }
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                object guest = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[3].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[3].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[3].Value);

                presenter.UpdateRecordInBookingTable(guest, room, numberOfGuests, arrivalDate, departureDate);
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                object guest = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[3].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[3].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[3].Value);

                presenter.DeleteRecordFromBookingTable(guest, room, numberOfGuests, arrivalDate, departureDate);
            }
        }

        #endregion
    }
}
