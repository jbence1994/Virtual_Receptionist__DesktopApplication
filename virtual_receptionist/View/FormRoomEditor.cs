using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Szoba kezelő ablak
    /// </summary>
    public partial class FormRoomEditor : Form
    {
        #region Adattagok

        /// <summary>
        /// Szobakezelő modul prezenter egy példánya
        /// </summary>
        private RoomEditorPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalás-kezelő ablak konstruktora, amely összeköti a főmenü ablakot a foglalás-kezelő ablakkal
        /// </summary>
        public FormRoomEditor()
        {
            InitializeComponent();
            presenter = new RoomEditorPresenter(dataGridViewRoomRents, dataGridViewRooms);
        }

        #endregion

        #region UI események

        private void FormRoomEditor_Load(object sender, EventArgs e)
        {
            presenter.SetRoomEditor();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
