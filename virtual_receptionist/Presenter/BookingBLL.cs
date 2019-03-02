using System;
using System.Collections.Generic;
using virtual_receptionist.DataAccessLayer.Model;
using virtual_receptionist.DataAccessLayer.Data;

namespace virtual_receptionist.BusinessLogicLayer
{
    /// <summary>
    /// Foglalás üzleti logika osztálya
    /// </summary>
    public class BookingBLL
    {
        #region Adattagok

        /// <summary>
        /// Foglalások adattár egy példánya
        /// </summary>
        private BookingRepository repository;

        #endregion

        #region Konstuktor

        /// <summary>
        /// Foglalás üzleti logika osztály konstruktora
        /// </summary>
        public BookingBLL()
        {
            repository = new BookingRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely kiszűri a foglalások adatait tartalmazó listából azokat a foglalásokat, amelyek a paraméterben megadott dátum szerint érkeznek és egy új listába menti őket
        /// </summary>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <returns>A szűrt adatokkal feltöltött listával tér vissza a függvény</returns>
        public List<Booking> GetBookingsByArrivalDate(string arrivalDate)
        {
            List<Booking> bookings = repository.Bookings;

            List<Booking> bookingsByArrivalDate = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                if (booking.ArrivalDate == DateTime.Parse(arrivalDate))
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
        public List<Booking> GetBookingsByDepartureDate(string departureDate)
        {
            List<Booking> bookings = repository.Bookings;

            List<Booking> bookingsByDepartureDate = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                if (booking.DepartureDate == DateTime.Parse(departureDate))
                {
                    bookingsByDepartureDate.Add(booking);
                }
            }

            return bookingsByDepartureDate;
        }

        #endregion
    }
}
