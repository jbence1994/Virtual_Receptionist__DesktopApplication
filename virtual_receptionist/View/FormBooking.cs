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
            dataGridViewBookings.DataSource = null;
            DateTime arrivalDate = dateTimePickerBooking.Value;
            dataGridViewBookings.DataSource = presenter.GetBookings(arrivalDate);
            dataGridViewRooms.DataSource = presenter.GetRooms();
        }

        #endregion
    }
}
