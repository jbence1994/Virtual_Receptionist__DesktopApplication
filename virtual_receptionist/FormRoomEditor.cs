using System;
using System.Windows.Forms;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Szoba kezelő ablak
    /// </summary>
    public partial class FormRoomEditor : Form
    {
        #region Adattagok

        /// <summary>
        /// Főmenü ablak egy példánya
        /// </summary>
        private FormMainMenu formMainMenu;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalás-kezelő ablak konstruktora, amely összeköti a főmenü ablakot a foglalás-kezelő ablakkal
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak egy példánya</param>
        public FormRoomEditor(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            this.formMainMenu = formMainMenu;
        }

        #endregion

        #region UI események

        private void FormRoomEditor_Load(object sender, EventArgs e)
        {
            Model.DataRepository dataRepository = new Model.DataRepository();
            dataGridViewRoomRents.DataSource = dataRepository.GetReservations();
            dataGridViewRooms.DataSource = dataRepository.GetRooms();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            formMainMenu.Show();
        }

        #endregion
    }
}
