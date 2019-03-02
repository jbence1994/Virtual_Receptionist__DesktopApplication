using virtual_receptionist.DataAccessLayer.Model;
using System.Collections.Generic;
using System;
using System.Data;

namespace virtual_receptionist.DataAccessLayer.Data
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
        private static List<Room> rooms;

        /// <summary>
        /// Foglalásokat tartalmazó lista
        /// </summary>
        private static List<Booking> bookings;

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

        #region Getter tulajdonságok

        /// <summary>
        /// Szobákat tartalmazó lista
        /// </summary>
        public static List<Room> Rooms
        {
            get
            {
                if (rooms.Count == 0)
                {
                    UploadRoomsList();
                }

                return rooms;
            }
        }

        /// <summary>
        /// Foglalásokat tartalmazó lista
        /// </summary>
        public static List<Booking> Bookings
        {
            get
            {
                if (bookings.Count == 0)
                {
                    UploadBookingsList();
                }

                return bookings;
            }
        }

        #endregion

        #region Adatfeltöltő és adatmanipulációs metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobák adatait tartalmazó listát
        /// </summary>
        private static void UploadRoomsList()
        {
            string sql =
                "SELECT room.Name, room.Number, billing_item.BillingItemName, room.Capacity FROM room, billing_item WHERE room.Category = billing_item.ID ORDER BY room.Number ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                int number = int.Parse(row["Number"].ToString());
                string category = row["BillingItemName"].ToString();
                int capacity = int.Parse(row["Capacity"].ToString());

                Room roomInstance = new Room(name, number, category, capacity);
                rooms.Add(roomInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a foglalások adatait tartalmazó listát
        /// </summary>
        private static void UploadBookingsList()
        {
            string sql =
                "SELECT booking.ID, guest.Name, company.CompanyName, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate FROM booking, guest, company, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID AND booking.CompanyID = company.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);

                Guest guest = new Guest()
                {
                    Name = row["Name"].ToString()
                };

                Company company = new Company()
                {
                    Name = row["CompanyName"].ToString()
                };

                Room room = new Room()
                {
                    Number = int.Parse(row["Number"].ToString())
                };

                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                DateTime arrival = (DateTime) row["ArrivalDate"];
                DateTime departure = (DateTime) row["DepartureDate"];

                Booking bookingInstance = new Booking(id, guest, company, room, numberOfGuests, arrival, departure);
                bookings.Add(bookingInstance);
            }
        }

        /// <summary>
        /// Új foglalás felvétele adatbázisba
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Create(Booking booking)
        {
            string sql =
                $"INSERT INTO booking(GuestID, RoomID, NumberOfGuests, ArrivalDate, DepartureDate) VALUES ((SELECT guest.ID FROM guest WHERE guest.Name LIKE \"{booking.Guest.Name}\"), (SELECT room.ID FROM room WHERE room.Number LIKE \"{booking.Room.Number}\"), {booking.NumberOfGuests}, {booking.ArrivalDate}, {booking.DepartureDate});";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő foglalás törlése adatbázisból
        /// </summary>
        /// <param name="booking">Booking objektum</param>>
        public void Delete(Booking booking)
        {
            string sql = $"DELETE FROM booking WHERE ";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő foglalás módosítása adatbázisban
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Update(Booking booking)
        {
            string sql = $"UPDATE room SET WHERE";
            database.DML(sql);
        }

        #endregion
    }
}
