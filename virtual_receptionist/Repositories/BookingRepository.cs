using System.Collections.Generic;
using System;
using System.Data;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
{
    /// <summary>
    /// Foglalások adattár
    /// </summary>
    public class BookingRepository : Repository
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
                int number = Convert.ToInt32(row["Number"]);
                string category = row["BillingItemName"].ToString();
                int capacity = Convert.ToInt32(row["Capacity"]);

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
                "SELECT booking.ID, guest.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate, booking.Paid FROM booking, guest, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID";
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
                    Number = Convert.ToInt32(row["Number"])
                };

                int numberOfGuests = Convert.ToInt32(row["NumberOfGuests"]);
                string arrival = Convert.ToDateTime(row["ArrivalDate"]).ToString("yyyy-MM-dd");
                string departure = Convert.ToDateTime(row["DepartureDate"]).ToString("yyyy-MM-dd");
                bool paid = Convert.ToBoolean(row["Paid"]);

                Booking bookingInstance = new Booking(id, guest, room, numberOfGuests, arrival, departure, paid);
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
                $"INSERT INTO booking(GuestID, RoomID, NumberOfGuests, ArrivalDate, DepartureDate, Paid) VALUES ((SELECT guest.ID FROM guest WHERE guest.Name LIKE \"{booking.Guest.Name}\"), (SELECT room.ID FROM room WHERE room.Number = \"{booking.Room.Number}\"), \"{booking.NumberOfGuests}\", \"{booking.ArrivalDate}\", \"{booking.DepartureDate}\", \"{booking.Paid}\");";
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
                $"UPDATE booking SET booking.GuestID = (SELECT guest.ID FROM guest WHERE guest.Name = \"{booking.Guest.Name}\"), booking.RoomID = (SELECT room.ID FROM room WHERE room.Number = \"{booking.Room.Number}\"), NumberOfGuests = \"{booking.NumberOfGuests}\", ArrivalDate = \"{booking.ArrivalDate}\", DepartureDate = \"{booking.DepartureDate}\" WHERE booking.ID = \"{booking.ID}\"";
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
            bookings.Clear();
            UploadBookingsList();

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
            bookings.Clear();
            UploadBookingsList();

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

        /// <summary>
        /// Metódus, amely kiszűri a foglalások adatait tartalmazó listából azokat a foglalásokat, amelyek nem fizettek még és egy új listába menti őket
        /// </summary>
        /// <returns>A szűrt adatokkal feltöltött listával tér vissza a függvény</returns>
        public List<Booking> GetBookingsNotPaid()
        {
            bookings.Clear();
            UploadBookingsList();

            List<Booking> bookingsNotPaid = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                if (!booking.Paid)
                {
                    bookingsNotPaid.Add(booking);
                }
            }

            return bookingsNotPaid;
        }

        /// <summary>
        /// Metódus, amely visszaadja egy adott szoba maximális férőhelyét (kapacitását)
        /// </summary>
        /// <param name="roomNumber">Szoba kapacitása</param>
        /// <returns>A maximális szoba férőhellyel tér vissza a függvény</returns>
        public int GetRoomCapacity(int roomNumber)
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            foreach (Room room in rooms)
            {
                if (room.Number == roomNumber)
                {
                    return room.Capacity;
                }
            }

            return 0;
        }

        #endregion
    }
}
