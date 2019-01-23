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
            string sql =
                "SELECT guest.Name, room.Number, reservation.NumberOfGuests, reservation.ArrivalDate, reservation.DepartureDate FROM reservation, guest, room WHERE reservation.GuestID = guest.ID AND reservation.RoomID = room.ID ORDER BY reservation.ArrivalDate ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                Guest guest = new Guest()
                {
                    Name = row["Name"].ToString()
                };

                Room room = new Room
                {
                    Number = int.Parse(row["Number"].ToString())
                };

                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                DateTime arrival = (DateTime) row["ArrivalDate"];
                DateTime departure = (DateTime) row["DepartureDate"];

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
            string sql =
                "SELECT room.Name, room.Number, room_category.CategoryName, room.Capacity FROM room, room_category WHERE room.Category = room_category.ID ORDER BY room.Number ASC";
            DataTable dt = database.DQL(sql);

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
        public DataTable GetReservations()
        {
            if (reservations.Count == 0)
            {
                UploadReservationsList();
            }

            DataTable reservationsDataTable = new DataTable();
            reservationsDataTable.Columns.Add("GuestName", typeof(Guest));
            reservationsDataTable.Columns.Add("RoomNumber", typeof(Room));
            reservationsDataTable.Columns.Add("NumberOfGuests", typeof(int));
            reservationsDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
            reservationsDataTable.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (Reservation reservation in reservations)
            {
                reservationsDataTable.Rows.Add(reservation.Guest, reservation.Room, reservation.NumberOfGuests,
                    reservation.Arrival, reservation.Departure);
            }

            return reservationsDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szoba adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetRooms()
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

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
