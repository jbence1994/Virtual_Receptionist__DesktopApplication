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
        /// Foglalás-kezelő ablak konstruktora, amely összeköti a főmenü ablakot a foglalás-kezelő ablakkal
        /// </summary>
        public FormBooking()
        {
            InitializeComponent();
            presenter = new BookingPresenter();
        }

        #endregion

        #region UI események

        private void dateTimePickerBooking_ValueChanged(object sender, EventArgs e)
        {
            DateTime arrivalDate = dateTimePickerBooking.Value;
            dataGridViewBookings.DataSource = presenter.GetBookings(arrivalDate);
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            dataGridViewRooms.DataSource = presenter.GetRooms();
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordToBookingTable();
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInBookingTable();
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordFromBookingTable();
        }

        #endregion
    }
}
