using System;
using System.Data;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository
    {
        #region Foglalási napló modul

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobakiadásokat tartalmazó listát érkezési dátum szerint
        /// </summary>
        /// <param name="arrivalDate">Érkezési dátum</param>
        private void UploadBookingsList(string arrivalDate)
        {
            string sql =
                $"SELECT guest.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate FROM booking, guest, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID AND booking.ArrivalDate LIKE \"{arrivalDate}\" ORDER BY booking.ArrivalDate ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                Guest guest = new PrivateGuest()
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

                Booking bookingInstance = new Booking(guest, room, numberOfGuests, arrival, departure);
                bookings.Add(bookingInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobákat tartalmazó listát
        /// </summary>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        private void UploadRoomsList()
        {
            string sql =
                "SELECT room.Name, room.Number, room_category.RoomCategoryName, room.Capacity FROM room, room_category WHERE room.Category = room_category.ID ORDER BY room.Number ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                int number = int.Parse(row["Number"].ToString());
                string category = row["RoomCategoryName"].ToString();
                int capacity = int.Parse(row["Capacity"].ToString());

                RoomCategory roomCategoryInstance = new RoomCategory(category);
                Room roomInstance = new Room(name, number, roomCategoryInstance, capacity);
                rooms.Add(roomInstance);
            }
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt szobakiadások adatait érkezési dátum alapján egy DataTable adatszerkezetben
        /// </summary>
        /// <param name="arrivalDate">Érkezési dátum</param>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        public DataTable GetBookings(string arrivalDate)
        {
            bookings.Clear();
            UploadBookingsList(arrivalDate);

            DataTable bookingsDataTable = new DataTable();
            bookingsDataTable.Columns.Add("GuestName", typeof(string));
            bookingsDataTable.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTable.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
            bookingsDataTable.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (Booking booking in bookings)
            {
                bookingsDataTable.Rows.Add(booking.Guest.Name, booking.Room.Number, booking.NumberOfGuests,
                    booking.Arrival, booking.Departure);
            }

            return bookingsDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szoba adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="booking"></param>
        public void CreateBooking(Booking booking)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="booking"></param>>
        public void DeleteBooking(Booking booking)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="booking"></param>
        public void UpdateBooking(Booking booking)
        {

        }

        #endregion
    }
}
