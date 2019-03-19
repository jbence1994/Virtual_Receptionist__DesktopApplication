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
        /// 
        /// </summary>
        private string id;

        /// <summary>
        /// 
        /// </summary>
        private string guest;

        /// <summary>
        /// 
        /// </summary>
        private string room;

        /// <summary>
        /// 
        /// </summary>
        private decimal numberOfGuests;

        /// <summary>
        /// 
        /// </summary>
        private DateTime arrivalDate;

        /// <summary>
        /// 
        /// </summary>
        private DateTime departureDate;

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

            id = booking[0].ToString();
            guest = booking[1].ToString();
            room = booking[2].ToString();
            numberOfGuests = Convert.ToDecimal(booking[3]);
            arrivalDate = Convert.ToDateTime(booking[4]);
            departureDate = Convert.ToDateTime(booking[5]);

            textBoxGuestName.Text = guest;
            dateTimePickerArrivalDate.Value = arrivalDate;
            dateTimePickerDepartureDate.Value = departureDate;
            comboBoxRoom.SelectedItem = room;
            numericUpDownNumberOfGuests.Value = numberOfGuests;
        }

        #endregion

        #region UI események

        private void FormUpdateBooking_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bookingController.UpdateBooking(id, guest, room, numberOfGuests, arrivalDate, departureDate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataRow GetUpdatedRow() //Controller
        {
            return null;
        }

        #endregion
    }
}
