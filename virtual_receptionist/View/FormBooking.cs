using System;
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
            dataGridViewBookings.DataSource = presenter.GetBookings();
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
                int id = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[4].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[5].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[6].Value);

                presenter.AddNewRecordToBookingTable(id, guest, room, numberOfGuests, arrivalDate, departureDate);
            }
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[4].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[5].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[6].Value);

                presenter.UpdateRecordInBookingTable(id, guest, room, numberOfGuests, arrivalDate, departureDate);
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[4].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[5].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[6].Value);

                presenter.DeleteRecordFromBookingTable(id, guest, room, numberOfGuests, arrivalDate, departureDate);
            }
        }

        #endregion
    }
}
