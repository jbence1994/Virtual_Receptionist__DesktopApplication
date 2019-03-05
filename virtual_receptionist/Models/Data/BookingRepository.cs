using virtual_receptionist.Models.ORM;
using System.Collections.Generic;
using System;
using System.Data;

namespace virtual_receptionist.Models.Data
{
    /// <summary>
    /// Foglalások adattár
    /// </summary>
    public class BookingRepository : Repository, IManipulable<Booking>
    {
        #region Adattagok

        /// <summary>
        /// Szobákat tartalmazó lista
        /// </summary>
        private List<Room> rooms;

        /// <summary>
        /// Foglalásokat tartalmazó lista
        /// </summary>
        private List<Booking> bookings;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalások adattár konstruktora
        /// </summary>
        public BookingRepository()
        {
            rooms = new List<Room>();
            bookings = new List<Booking>();
        }

        #endregion

        #region Adatfeltöltő metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobák adatait tartalmazó listát
        /// </summary>
        private void UploadRoomsList()
        {
            string sql =
                "SELECT room.ID, room.Name, room.Number, billing_item.BillingItemName, room.Capacity FROM room, billing_item WHERE room.Category = billing_item.ID ORDER BY room.Number ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string name = row["Name"].ToString();
                int number = int.Parse(row["Number"].ToString());
                string category = row["BillingItemName"].ToString();
                int capacity = int.Parse(row["Capacity"].ToString());

                Room roomInstance = new Room(id, name, number, category, capacity);
                rooms.Add(roomInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a foglalások adatait tartalmazó listát
        /// </summary>
        private void UploadBookingsList()
        {
            string sql =
                "SELECT booking.ID, guest.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate FROM booking, guest, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);

                Guest guest = new Guest()
                {
                    Name = row["Name"].ToString()
                };

                Room room = new Room()
                {
                    Number = int.Parse(row["Number"].ToString())
                };

                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                string arrival = row["ArrivalDate"].ToString();
                string departure = row["DepartureDate"].ToString();

                Booking bookingInstance = new Booking(id, guest, room, numberOfGuests, arrival, departure);
                bookings.Add(bookingInstance);
            }
        }

        #endregion

        #region Adatelérési metódusok

        /// <summary>
        /// Metódus, amely feltölti a szobákat tartalmazó listát adatbázisból
        /// </summary>
        /// <returns>Az adatokkal feltöltött listával tér vissza a metódus</returns>
        public List<Room> GetRooms()
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            return rooms;
        }

        /// <summary>
        /// Metódus, amely feltölti a foglalásokat tartalmazó listát adatbázisból
        /// </summary>
        /// <returns>Az adatokkal feltöltött listával tér vissza a metódus</returns>
        public List<Booking> GetBookings()
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            return bookings;
        }

        #endregion

        #region Adatmanipulációs metódusok

        /// <summary>
        /// Új foglalás felvétele adatbázisba
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Create(Booking booking)
        {
            string sql =
                $"INSERT INTO booking(GuestID, RoomID, NumberOfGuests, ArrivalDate, DepartureDate) VALUES ((SELECT guest.ID FROM guest WHERE guest.Name LIKE \"{booking.Guest.Name}\"), (SELECT room.ID FROM room WHERE room.Number = \"{booking.Room.Number}\"), \"{booking.NumberOfGuests}\", \"{booking.ArrivalDate}\", \"{booking.DepartureDate}\");";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő foglalás törlése adatbázisból
        /// </summary>
        /// <param name="booking">Booking objektum</param>>
        public void Delete(Booking booking)
        {
            string sql = $"DELETE FROM booking WHERE booking.ID = \"{booking.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő foglalás módosítása adatbázisban
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Update(Booking booking)
        {
            string sql =
                $"UPDATE room SET booking.GuestID = (SELECT guest.Name FROM guest WHERE guest.Name = \"{booking.Guest.Name}\"), booking.RoomID = (SELECT room.Name FROM room WHERE room.ID = \"{booking.Room.Name}\"), NumberOfGuests = \"{booking.NumberOfGuests}\", ArrivalDate = \"{booking.ArrivalDate}\", DepartureDate = \"{booking.DepartureDate}\" WHERE booking.ID = \"{booking.ID}\"";
            database.DML(sql);
        }

        #endregion

        #region Üzleti logika

        /// <summary>
        /// Metódus, amely kiszűri a foglalások adatait tartalmazó listából azokat a foglalásokat, amelyek a paraméterben megadott dátum szerint érkeznek és egy új listába menti őket
        /// </summary>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <returns>A szűrt adatokkal feltöltött listával tér vissza a függvény</returns>
        public List<Booking> GetGuestBookingsByArrivalDate(string arrivalDate)
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            List<Booking> bookingsByArrivalDate = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                if (booking.ArrivalDate == arrivalDate)
                {
                    bookingsByArrivalDate.Add(booking);
                }
            }

            return bookingsByArrivalDate;
        }

        /// <summary>
        /// Metódus, amely kiszűri a foglalások adatait tartalmazó listából azokat a foglalásokat, amelyek a paraméterben megadott dátum szerint távoznak és egy új listába menti őket
        /// </summary>
        /// <param name="departureDate"></param>
        /// <returns>A szűrt adatokkal feltöltött listával tér vissza a függvény</returns>
        public List<Booking> GetGuestBookingsByDepartureDate(string departureDate)
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            List<Booking> bookingsByDepartureDate = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                if (booking.DepartureDate == departureDate)
                {
                    bookingsByDepartureDate.Add(booking);
                }
            }

            return bookingsByDepartureDate;
        }

        #endregion
    }
}
