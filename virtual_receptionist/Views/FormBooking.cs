using System;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Foglalási napló ablak
    /// </summary>
    public partial class FormBooking : Form
    {
        #region Adattagok

        /// <summary>
        /// Foglalási napló vezérlő egy példánya
        /// </summary>
        private BookingController controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló ablak konstruktora
        /// </summary>
        public FormBooking()
        {
            InitializeComponent();
            controller = new BookingController();
        }

        #endregion

        #region UI események

        private void dateTimePickerArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            dataGridViewCompanyBookings.DataSource = controller.GetBookingsByArrivalDate(arrivalDate);
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime departureDate = dateTimePickerDepartureDate.Value;
            dataGridViewCompanyBookings.DataSource = controller.GetBookingsByDepartureDate(departureDate);
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanyBookings.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewCompanyBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewCompanyBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewCompanyBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewCompanyBookings.SelectedRows[0].Cells[4].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewCompanyBookings.SelectedRows[0].Cells[5].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewCompanyBookings.SelectedRows[0].Cells[6].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewCompanyBookings.SelectedRows[0].Cells[7].Value);

                controller.AddNewRecordToBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate);
            }
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanyBookings.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewCompanyBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewCompanyBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewCompanyBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewCompanyBookings.SelectedRows[0].Cells[4].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewCompanyBookings.SelectedRows[0].Cells[5].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewCompanyBookings.SelectedRows[0].Cells[6].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewCompanyBookings.SelectedRows[0].Cells[7].Value);

                controller.UpdateRecordInBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate);
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanyBookings.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewCompanyBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewCompanyBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewCompanyBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewCompanyBookings.SelectedRows[0].Cells[4].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewCompanyBookings.SelectedRows[0].Cells[5].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewCompanyBookings.SelectedRows[0].Cells[6].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewCompanyBookings.SelectedRows[0].Cells[7].Value);

                controller.DeleteRecordFromBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate);
            }
        }

        #endregion
    }
}
