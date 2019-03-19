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

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló foglalásmódosítás modális ablak konstruktora
        /// </summary>
        public FormUpdateBooking()
        {
            InitializeComponent();
        }

        #endregion

        #region UI események

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
