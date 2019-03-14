using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Models.ORM;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Foglalás érkezési és tábozási idejét ellenőrző osztály
    /// </summary>
    public class BookingDateValidation
    {
        #region Adattagok

        /// <summary>
        /// Fogolalás egyed egy példánya
        /// </summary>
        private readonly Booking booking;
        
        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalás érkezési és tábozási idejét ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="booking">Foglalás egyed</param>
        public BookingDateValidation(Booking booking)
        {
            this.booking = booking;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Foglalás érkezési és tábozási idejét ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidBookingParameterException"></exception>
        public void ValidateBookingDate()
        {
            if (booking.ArrivalDate == booking.DepartureDate)
            {
                throw new InvalidBookingParameterException("A távozás dátuma megegyezik az érkezés dátumával!");
            }
        }

        #endregion
    }
}
