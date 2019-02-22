using System;
using System.Data;
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
            string arrival = arrivalDate.ToString("yyyy-MM-dd");

            DataTable bookings = dataRepository.GetBookingsByArrivalDate(arrival);
            return bookings;
        }

        /// <summary>
        /// Metódus, amely visszaadja a foglalásokat adattárból távozás dátuma szerint
        /// </summary>
        /// <param name="departureDate">Távozás dátuma</param>
        /// <returns></returns>
        public DataTable GetBookingsByDepartureDate(DateTime departureDate)
        {
            string departure = departureDate.ToString("yyyy-MM-dd");

            DataTable bookings = dataRepository.GetBookingsByDepartureDate(departure);
            return bookings;
        }

        /// <summary>
        /// Metódus, amely visszaadja a szobákat az adattárból
        /// </summary>
        /// <returns>A szobákkal feltöltött adattbálát adja vissza a függvény</returns>
        public DataTable GetRooms()
        {
            DataTable rooms = dataRepository.GetRooms();
            return rooms;
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
