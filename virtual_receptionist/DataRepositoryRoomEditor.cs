using System;
using System.Data;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Szoba kezelő modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobakiadásokat tartalmazó listát
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void UploadReservationsList()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobákat tartalmazó listát
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void UploadRoomsList()
        {
            string sql = "SELECT room.Name, room.Number, room_category.CategoryName, room.Capacity FROM room, room_category WHERE room.Category = room_category.ID ORDER BY room.Number ASC";
            DataTable dt = database.Query(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                int number = int.Parse(row["Number"].ToString());
                string category = row["CategoryName"].ToString();
                int capacity = int.Parse(row["Capacity"].ToString());

                Room room = new Room(name, number, category, capacity);
                rooms.Add(room);
            }
        }
        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szobakiadás adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetGetReservations()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szoba adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetRooms()
        {

        }

        #endregion
    }
}
