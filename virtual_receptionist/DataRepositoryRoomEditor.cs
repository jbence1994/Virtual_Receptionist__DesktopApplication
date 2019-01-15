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
            string sql = "SELECT guest.Name, room.Number, reservation.NumberOfGuests, reservation.ArrivalDate, reservation.DepartureDate FROM reservation, guest, room WHERE reservation.GuestID = guest.ID AND reservation.RoomID = room.ID";
            DataTable dt = database.Query(sql);

            foreach (DataRow row in dt.Rows)
            {
                Guest guest = (Guest)row["Name"];
                Room room = (Room)row["Number"];
                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                DateTime arrival = (DateTime)row["ArrivalDate"];
                DateTime departure = (DateTime)row["DepartureDate"];

                Reservation reservationInstance = new Reservation(guest, room, numberOfGuests, arrival, departure);
                reservations.Add(reservationInstance);
            }
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

                Room roomInstance = new Room(name, number, category, capacity);
                rooms.Add(roomInstance);
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
            UploadRoomsList();

            DataTable roomsDataTable = new DataTable();
            roomsDataTable.Columns.Add("Name", typeof(string));
            roomsDataTable.Columns.Add("Number", typeof(int));
            roomsDataTable.Columns.Add("CategoryName", typeof(string));
            roomsDataTable.Columns.Add("Capacity", typeof(int));

            foreach (Room room in rooms)
            {
                roomsDataTable.Rows.Add(room.Name, room.Number, room.Category, room.Capacity);
            }

            return roomsDataTable;
        }

        #endregion
    }
}
