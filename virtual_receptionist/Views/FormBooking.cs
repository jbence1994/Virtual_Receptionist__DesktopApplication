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

        private void FormBooking_Load(object sender, EventArgs e)
        {
            DateTime actualDate = dateTimePickerArrivalDate.Value;
            dataGridViewBookings.DataSource = controller.GetBookingsByArrivalDate(actualDate);
        }

        private void dateTimePickerArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            dataGridViewBookings.DataSource = controller.GetBookingsByArrivalDate(arrivalDate);
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime departureDate = dateTimePickerDepartureDate.Value;
            dataGridViewBookings.DataSource = controller.GetBookingsByDepartureDate(departureDate);
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                object id = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
                object numberOfGuests = dataGridViewBookings.SelectedRows[0].Cells[5].Value;
                object arrivalDate = dataGridViewBookings.SelectedRows[0].Cells[6].Value;
                object departureDate = dataGridViewBookings.SelectedRows[0].Cells[7].Value;
                object paid = dataGridViewBookings.SelectedRows[0].Cells[8].Value;

                controller.AddNewRecordToBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate, paid);
            }
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                object id = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
                object numberOfGuests = dataGridViewBookings.SelectedRows[0].Cells[5].Value;
                object arrivalDate = dataGridViewBookings.SelectedRows[0].Cells[6].Value;
                object departureDate = dataGridViewBookings.SelectedRows[0].Cells[7].Value;
                object paid = dataGridViewBookings.SelectedRows[0].Cells[8].Value;

                controller.UpdateRecordInBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate, paid);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt foglalás!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                object id = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
                object numberOfGuests = dataGridViewBookings.SelectedRows[0].Cells[5].Value;
                object arrivalDate = dataGridViewBookings.SelectedRows[0].Cells[6].Value;
                object departureDate = dataGridViewBookings.SelectedRows[0].Cells[7].Value;
                object paid = dataGridViewBookings.SelectedRows[0].Cells[8].Value;

                controller.DeleteRecordFromBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate, paid);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt foglalás!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
