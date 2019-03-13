using System.Windows.Forms;
using System;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Foglalási napló foglalás felvitelét vagy mdosítását segítő ablak
    /// </summary>
    public partial class FormBookingManager : Form
    {
        #region Adattagok

        /// <summary>
        /// Foglalási napló vezérlő egy példánya
        /// </summary>
        private BookingController controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló foglalás felvitelét vagy mdosítását segítő ablak konstruktora
        /// </summary>
        public FormBookingManager()
        {
            InitializeComponent();
            controller = new BookingController();
        }

        #endregion

        #region UI események

        private void FormBookingManager_Load(object sender, EventArgs e)
        {
            textBoxGuestName.Select();
            comboBoxCountry.DataSource = controller.GetCountries();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string guest = textBoxGuestName.Text;
            string room = comboBoxRoom.SelectedItem.ToString();
            decimal numberOfGuests = numericUpDownNumberOfGuests.Value;
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            DateTime departureDate = dateTimePickerDepartureDate.Value;

            controller.AddNewRecordToBookingTable(guest, room, numberOfGuests, arrivalDate, departureDate);
        }

        #endregion
    }
}
