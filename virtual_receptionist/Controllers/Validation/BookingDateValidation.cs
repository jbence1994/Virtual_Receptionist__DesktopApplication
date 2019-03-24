using System;
using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Repositories.Models;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Foglalás érkezési és távozási idejét ellenőrző osztály
    /// </summary>
    public class BookingDateValidation
    {
        #region Adattagok

        /// <summary>
        /// Foglalás egyed egy példánya
        /// </summary>
        private readonly Booking booking;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalás érkezési és távozási idejét ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="booking">Foglalás egyed</param>
        public BookingDateValidation(Booking booking)
        {
            this.booking = booking;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Foglalás érkezési és távozási idejét ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidBookingParameterException"></exception>
        public void ValidateBookingDate()
        {
            if (Convert.ToDateTime(booking.ArrivalDate) == Convert.ToDateTime(booking.DepartureDate))
            {
                throw new InvalidBookingParameterException("A távozás dátuma megegyezik az érkezés dátumával!");
            }

            if (Convert.ToDateTime(booking.DepartureDate) < Convert.ToDateTime(booking.ArrivalDate))
            {
                throw new InvalidBookingParameterException(
                    "A távozás dátuma nem lehet hamarabb, mint az érkezés dátuma!");
            }
        }

        #endregion
    }
}
