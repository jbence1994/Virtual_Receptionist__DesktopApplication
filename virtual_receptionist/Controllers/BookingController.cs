using System;
using System.Data;
using System.Collections.Generic;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.ORM;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Foglalási napló modul vezérlője
    /// </summary>
    public class BookingController : Controller
    {
        #region Adattagok

        /// <summary>
        /// Foglalások adattár osztály egy példánya
        /// </summary>
        private BookingRepository repository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló modul vezérlő konstruktora
        /// </summary>
        public BookingController()
        {
            repository = new BookingRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely lekéri a szobák adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A szobák adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetRooms()
        {
            List<Room> rooms = repository.GetRooms();

            DataTable roomsDataTable = new DataTable();
            roomsDataTable.Columns.Add("Number", typeof(int));
            roomsDataTable.Columns.Add("Name", typeof(string));
            roomsDataTable.Columns.Add("CategoryName", typeof(string));
            roomsDataTable.Columns.Add("Capacity", typeof(int));

            foreach (Room room in rooms)
            {
                roomsDataTable.Rows.Add(room.Number, room.Name, room.Category, room.Capacity);
            }

            return roomsDataTable;
        }

        /// <summary>
        /// Metódus, amely lekéri a foglalások adatait érkezés dátuma alapján az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <returns>A céges foglalások adataival - érkezés dátuma szerint - feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetBookingsByArrivalDate(DateTime arrivalDate)
        {
            string arrival = arrivalDate.ToString("yyyy-MM-dd");
            List<Booking> bookingsByArrival = repository.GetGuestBookingsByArrivalDate(arrival);

            DataTable bookingsDataTableByArrival = new DataTable();
            bookingsDataTableByArrival.Columns.Add("ID", typeof(int));
            bookingsDataTableByArrival.Columns.Add("GuestName", typeof(string));
            bookingsDataTableByArrival.Columns.Add("CompanyName", typeof(string));
            bookingsDataTableByArrival.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTableByArrival.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTableByArrival.Columns.Add("ArrivalDate", typeof(DateTime));
            bookingsDataTableByArrival.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (Booking booking in bookingsByArrival)
            {
                bookingsDataTableByArrival.Rows.Add(booking.ID, booking.Guest.Name, booking.Room.Number,
                    booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate);
            }

            return bookingsDataTableByArrival;
        }

        /// <summary>
        /// Metódus, amely lekéri a foglalások adatait távozás dátuma alapján az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <param name="departureDate">Távozás dátuma</param>
        /// <returns>A foglalások adataival - távozás dátuma szerint - feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetBookingsByDepartureDate(DateTime departureDate)
        {
            string departure = departureDate.ToString("yyyy-MM-dd");
            List<Booking> bookingsByDeparture = repository.GetGuestBookingsByDepartureDate(departure);

            DataTable bookingsDataTableByDeparture = new DataTable();
            bookingsDataTableByDeparture.Columns.Add("ID", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("GuestName", typeof(string));
            bookingsDataTableByDeparture.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("ArrivalDate", typeof(DateTime));
            bookingsDataTableByDeparture.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (Booking booking in bookingsByDeparture)
            {
                bookingsDataTableByDeparture.Rows.Add(booking.ID, booking.Guest.Name, booking.Room.Number,
                    booking.NumberOfGuests,
                    booking.ArrivalDate, booking.DepartureDate);
            }

            return bookingsDataTableByDeparture;
        }

        /// <summary>
        /// Új foglalás felvétele
        /// </summary>
        /// <param name="bookingParameters">Foglalás paraméterei</param>
        public void AddNewRecordToBookingTable(params object[] bookingParameters)
        {
            int id = Convert.ToInt32(bookingParameters[0]);

            Guest guest = new Guest()
            {
                Name = bookingParameters[1].ToString()
            };

            Room room = new Room()
            {
                Number = Convert.ToInt32(bookingParameters[3])
            };

            int numberOfGuests = Convert.ToInt32(bookingParameters[4]);

            DateTime arrivalDate = Convert.ToDateTime(bookingParameters[5]);

            DateTime departureDate = Convert.ToDateTime(bookingParameters[6]);

            Booking booking = new Booking(id, guest, room, numberOfGuests, arrivalDate, departureDate);

            repository.Create(booking);
        }

        /// <summary>
        /// Foglalás törlése
        /// </summary>
        /// <param name="bookingParameters">Foglalás paraméterei</param>
        public void DeleteRecordFromBookingTable(params object[] bookingParameters)
        {
            int id = Convert.ToInt32(bookingParameters[0]);

            Guest guest = new Guest()
            {
                Name = bookingParameters[1].ToString()
            };

            Room room = new Room()
            {
                Number = Convert.ToInt32(bookingParameters[3])
            };

            int numberOfGuests = Convert.ToInt32(bookingParameters[4]);

            DateTime arrivalDate = Convert.ToDateTime(bookingParameters[5]);

            DateTime departureDate = Convert.ToDateTime(bookingParameters[6]);

            Booking booking = new Booking(id, guest, room, numberOfGuests, arrivalDate, departureDate);

            repository.Delete(booking);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookingParameters">Foglalás paraméterei</param>
        public void UpdateRecordInBookingTable(params object[] bookingParameters)
        {
            int id = Convert.ToInt32(bookingParameters[0]);

            Guest guest = new Guest()
            {
                Name = bookingParameters[1].ToString()
            };

            Room room = new Room()
            {
                Number = Convert.ToInt32(bookingParameters[3])
            };

            int numberOfGuests = Convert.ToInt32(bookingParameters[4]);

            DateTime arrivalDate = Convert.ToDateTime(bookingParameters[5]);

            DateTime departureDate = Convert.ToDateTime(bookingParameters[6]);

            Booking booking = new Booking(id, guest, room, numberOfGuests, arrivalDate, departureDate);

            repository.Update(booking);
        }

        #endregion
    }
}
