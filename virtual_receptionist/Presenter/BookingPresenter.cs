using System;
using System.Data;
using System.Collections.Generic;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Foglalási napló modul prezentere
    /// </summary>
    public class BookingPresenter : DefaultPresenter
    {
        #region Foglalási napló nézetfrissítései

        /// <summary>
        /// Metódus, amely visszaadja a foglalásokat adattárból érkezés dátuma szerint
        /// </summary>
        /// <returns>A foglalásokkal feltöltött adattbálát adja vissza a függvény</returns>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        public DataTable GetBookingsByArrivalDate(DateTime arrivalDate)
        {
            /*
             * ÜZELTI LOGIKA MEGÍRANDÓ A MODELBE!
             */

            string arrival = arrivalDate.ToString("yyyy-MM-dd");

            return new DataTable();
        }

        /// <summary>
        /// Metódus, amely visszaadja a foglalásokat adattárból távozás dátuma szerint
        /// </summary>
        /// <param name="departureDate">Távozás dátuma</param>
        /// <returns></returns>
        public DataTable GetBookingsByDepartureDate(DateTime departureDate)
        {
            /*
             * ÜZLETI LOGIKA MEGÍRANDÓ A MODELBE!
             */

            string departure = departureDate.ToString("yyyy-MM-dd");

            return new DataTable();
        }

        /// <summary>
        /// Metódus, amely lekéri a foglalások adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A foglalások adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetBookings()
        {
            List<Booking> bookings = dataRepository.Bookings;

            DataTable bookingsDataTable = new DataTable();
            bookingsDataTable.Columns.Add("ID", typeof(int));
            bookingsDataTable.Columns.Add("GuestName", typeof(string));
            bookingsDataTable.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTable.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
            bookingsDataTable.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (Booking booking in bookings)
            {
                bookingsDataTable.Rows.Add(booking.ID, booking.Guest.Name, booking.Room.Number, booking.NumberOfGuests,
                    booking.ArrivalDate, booking.DepartureDate);
            }

            return bookingsDataTable;
        }

        /// <summary>
        /// Metódus, amely lekéri a szobák adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A szobák adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetRooms()
        {
            List<Room> rooms = dataRepository.Rooms;

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
        /// <param name="bookingParameters">Foglalás paraméterei</param>
        public void AddNewRecordToBookingTable(params object[] bookingParameters)
        {
            int id = Convert.ToInt32(bookingParameters[0]);

            Guest guest = new CorporateGuest()
            {
                Name = bookingParameters[1].ToString()
            };

            Room room = new Room()
            {
                Number = Convert.ToInt32(bookingParameters[2])
            };

            int numberOfGuests = Convert.ToInt32(bookingParameters[3]);

            DateTime arrivalDate = Convert.ToDateTime(bookingParameters[4]);

            DateTime departureDate = Convert.ToDateTime(bookingParameters[5]);

            Booking booking = new Booking(id, guest, room, numberOfGuests, arrivalDate, departureDate);

            dataRepository.Create(booking);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookingParameters">Foglalás paraméterei</param>
        public void DeleteRecordFromBookingTable(params object[] bookingParameters)
        {
            int id = Convert.ToInt32(bookingParameters[0]);

            Guest guest = new CorporateGuest()
            {
                Name = bookingParameters[1].ToString()
            };

            Room room = new Room()
            {
                Number = Convert.ToInt32(bookingParameters[2])
            };

            int numberOfGuests = Convert.ToInt32(bookingParameters[3]);

            DateTime arrivalDate = Convert.ToDateTime(bookingParameters[4]);

            DateTime departureDate = Convert.ToDateTime(bookingParameters[5]);

            Booking booking = new Booking(id, guest, room, numberOfGuests, arrivalDate, departureDate);

            dataRepository.Delete(booking);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookingParameters">Foglalás paraméterei</param>
        public void UpdateRecordInBookingTable(params object[] bookingParameters)
        {
            int id = Convert.ToInt32(bookingParameters[0]);

            Guest guest = new CorporateGuest()
            {
                Name = bookingParameters[1].ToString()
            };

            Room room = new Room()
            {
                Number = Convert.ToInt32(bookingParameters[2])
            };

            int numberOfGuests = Convert.ToInt32(bookingParameters[3]);

            DateTime arrivalDate = Convert.ToDateTime(bookingParameters[4]);

            DateTime departureDate = Convert.ToDateTime(bookingParameters[5]);

            Booking booking = new Booking(id, guest, room, numberOfGuests, arrivalDate, departureDate);

            dataRepository.Update(booking);
        }

        #endregion
    }
}
