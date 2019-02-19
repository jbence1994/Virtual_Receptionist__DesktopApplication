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
        /// Metódus, amely visszaadja a foglalásokat adattárból
        /// </summary>
        /// <returns>A foglalásokkal feltöltött adattbálát adja vissza a függvény</returns>
        /// <param name="arrivalDate">Érkezési dátum</param>
        public DataTable GetBookings(DateTime arrivalDate)
        {
            string arrival = arrivalDate.ToString("yyyy-MM-dd");

            DataTable bookings = dataRepository.GetBookings(arrival);
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
        /// <param name="bookingParameters"></param>
        public void AddNewRecordToBookingTable(params object[] bookingParameters)
        {
            Booking booking = new Booking();
            dataRepository.CreateBooking(booking);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookingParameters"></param>
        public void DeleteRecordFromBookingTable(params object[] bookingParameters)
        {
            Booking booking = new Booking();
            dataRepository.DeleteBooking(booking);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookingParameters"></param>
        public void UpdateRecordInBookingTable(params object[] bookingParameters)
        {
            Booking booking = new Booking();
            dataRepository.UpdateBooking(booking);
        }

        #endregion
    }
}
