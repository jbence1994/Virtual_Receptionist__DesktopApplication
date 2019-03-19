using System;
using System.Windows.Forms;
using virtual_receptionist.Controllers;
using System.Data;

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
            dateTimePickerArrivalDate.Value = Convert.ToDateTime(booking[2]);
            dateTimePickerDepartureDate.Value = Convert.ToDateTime(booking[3]);
            comboBoxRoom.DataSource = bookingController.GetRooms();
            comboBoxRoom.SelectedItem = Convert.ToInt32(booking[4]);
            numericUpDownNumberOfGuests.Value = Convert.ToDecimal(booking[5]);
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
            booking[2] = dateTimePickerArrivalDate.Value;
            booking[3] = dateTimePickerDepartureDate.Value;
            booking[4] = comboBoxRoom.SelectedItem;
            booking[5] = numericUpDownNumberOfGuests.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object[] Booking //Controller
        {
            get { return booking; }
        }

        #endregion
    }
}
