using System;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Foglalási napló foglalásmódosítás modális ablak
    /// </summary>
    public partial class FormUpdateBooking : Form
    {
        #region Adattagok

        /// <summary>
        /// Foglalási napló vezérlő egy példánya
        /// </summary>
        private BookingController bookingController;

        /// <summary>
        /// Vendégadatbázis-kezelő vezérlő egy példánya
        /// </summary>
        private GuestDatabaseController guestController;

        /// <summary>
        /// Foglalás adatai
        /// </summary>
        private object[] booking;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló foglalásmódosítás modális ablak konstruktora
        /// </summary>
        /// <param name="booking">Foglalás adatai</param>
        public FormUpdateBooking(params object[] booking)
        {
            InitializeComponent();

            bookingController = new BookingController();
            guestController = new GuestDatabaseController();

            this.booking = booking;
            textBoxBookingID.Text = booking[0].ToString();
            textBoxGuestName.Text = booking[1].ToString();
            dateTimePickerArrivalDate.Value = Convert.ToDateTime(booking[4]);
            dateTimePickerDepartureDate.Value = Convert.ToDateTime(booking[5]);
            comboBoxRoom.DataSource = bookingController.GetRooms();
            comboBoxRoom.SelectedItem = Convert.ToInt32(booking[2]);
            numericUpDownNumberOfGuests.Value = Convert.ToDecimal(booking[3]);
        }

        #endregion

        #region UI események

        private void FormUpdateBooking_Load(object sender, EventArgs e)
        {
            textBoxGuestName.Select();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            booking[0] = Convert.ToInt32(textBoxBookingID.Text);
            booking[1] = textBoxGuestName.Text;
            booking[2] = comboBoxRoom.SelectedItem;
            booking[3] = numericUpDownNumberOfGuests.Value;
            booking[4] = dateTimePickerArrivalDate.Value.ToString("yyyy-MM-dd");
            booking[5] = dateTimePickerDepartureDate.Value.ToString("yyyy-MM-dd");

            bookingController.UpdateBooking(booking);
        }

        /// <summary>
        /// Foglalás adatai
        /// </summary>
        public object[] Booking
        {
            get { return booking; }
        }

        #endregion
    }
}
