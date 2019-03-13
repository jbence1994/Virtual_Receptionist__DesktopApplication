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
            comboBox1.DataSource = controller.GetCountries();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //object id = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
            //object guest = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
            //object company = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
            //object room = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
            //object numberOfGuests = dataGridViewBookings.SelectedRows[0].Cells[5].Value;
            //object arrivalDate = dataGridViewBookings.SelectedRows[0].Cells[6].Value;
            //object departureDate = dataGridViewBookings.SelectedRows[0].Cells[7].Value;
            ////object paid = dataGridViewBookings.SelectedRows[0].Cells[8].Value;

            //controller.AddNewRecordToBookingTable(id, guest, company, room, numberOfGuests, arrivalDate,
            //    departureDate, paid);
        }

        #endregion

        private void groupBoxBookingData_Enter(object sender, EventArgs e)
        {

        }
    }
}
