using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Vendég bejelentkező lap prezentere
    /// </summary>
    public class RegistrationCardPresenter : DefaultPresenter
    {
        #region Vendég bejelentkező lap nézetfrissítései

        /// <summary>
        /// Metódus, amely elmenti a szobakiadást adatbázisba
        /// </summary>
        public void Save()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int> GetRoomNumbers()
        {
            List<int> roomNumbers = new List<int>();

            DataTable rooms = dataRepository.GetRooms();

            foreach (Room room in rooms.Rows)
            {
                roomNumbers.Add(room.Number);
            }

            return roomNumbers;
        }

        #endregion
    }
}
