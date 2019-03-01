using System;
using System.Collections.Generic;
using virtual_receptionist.DataAccessLayer;
using virtual_receptionist.DataAccessLayer.Model;

namespace virtual_receptionist.BusinessLogicLayer
{
    public class BookingBLL
    {
        #region Foglalási napló üzleti logika metódusok

        /// <summary>
        /// Metódus, amely kiszűri a foglalások adatait tartalmazó listából azokat a foglalásokat, amelyek a paraméterben megadott dátum szerint érkeznek és egy új listába menti őket
        /// </summary>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <returns>A szűrt adatokkal feltöltött listával tér vissza a függvény</returns>
        public List<Booking> GetBookingsByArrivalDate(string arrivalDate)
        {
            List<Booking> bookings = Repository.Bookings;

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
            List<Booking> bookings = Repository.Bookings;

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
