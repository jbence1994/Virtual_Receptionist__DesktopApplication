using System;
using System.Windows.Forms;
using virtual_receptionist.Model;
using virtual_receptionist.View;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Szobakezelő modul prezentere
    /// </summary>
    public class RoomEditorPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Szobakiadások táblázat
        /// </summary>
        private DataGridView dataGridViewRoomRents;
        /// <summary>
        /// Szobák táblázat
        /// </summary>
        private DataGridView dataGridViewRooms;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Szobakezelő modul prezenter konstruktora
        /// </summary>
        /// <param name="dataGridViewRoomRents">Szobakiadások táblázat</param>
        /// <param name="dataGridViewRooms">Szobák táblázat</param>
        public RoomEditorPresenter(DataGridView dataGridViewRoomRents, DataGridView dataGridViewRooms)
        {
            this.dataGridViewRoomRents = dataGridViewRoomRents;
            this.dataGridViewRooms = dataGridViewRooms;
        }

        #endregion

        #region Szobakezelő nézetfrissítései

        /// <summary>
        /// Metódus, amely beállítja az ablakot betöltődéskor
        /// </summary>
        public void SetRoomEditor()
        {
            dataGridViewRoomRents.DataSource = dataRepository.GetReservations();
            dataGridViewRooms.DataSource = dataRepository.GetRooms();
        }

        #endregion
    }
}
