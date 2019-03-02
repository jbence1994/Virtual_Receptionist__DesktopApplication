using System;
using System.Windows.Forms;
using virtual_receptionist.ApplicationLayer;

namespace virtual_receptionist.UILayer
{
    /// <summary>
    /// Foglalási napló ablak
    /// </summary>
    public partial class FormBooking : Form
    {
        #region Adattagok

        /// <summary>
        /// Alkalmazás vezérlő egy példánya
        /// </summary>
        private Controller controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló ablak konstruktora
        /// </summary>
        public FormBooking()
        {
            InitializeComponent();
            controller = new Controller();
        }

        #endregion

        #region UI események

        private void FormBooking_Load(object sender, EventArgs e)
        {
            dataGridViewRooms.DataSource = controller.GetRooms();
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
                int id = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[5].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[6].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[7].Value);

                controller.AddNewRecordToBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate);
            }
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[5].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[6].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[7].Value);

                controller.UpdateRecordInBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate);
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[1].Value);
                object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object company = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
                int numberOfGuests = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[5].Value);
                DateTime arrivalDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[6].Value);
                DateTime departureDate = Convert.ToDateTime(dataGridViewBookings.SelectedRows[0].Cells[7].Value);

                controller.DeleteRecordFromBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
                    departureDate);
            }
        }

        #endregion
    }
}
