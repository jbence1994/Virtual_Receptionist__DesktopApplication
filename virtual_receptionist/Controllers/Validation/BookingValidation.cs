using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Models.ORM;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Foglalás adatait ellenőrző osztály
    /// </summary>
    public class BookingValidation
    {
        #region Adattagok

        /// <summary>
        /// Fogolalás egyed egy példánya
        /// </summary>
        private readonly Booking booking;

        #endregion

        #region Konstruktor

        public BookingValidation(Booking booking)
        {
            this.booking = booking;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Foglalás ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidBookingParameterException"></exception>
        public void ValidateBooking()
        {
            if (booking.ArrivalDate == booking.DepartureDate)
            {
                throw new InvalidBookingParameterException("A távozás dátuma megegyezik az érkezés dátumával!");
            }

            if (booking.NumberOfGuests > booking.Room.Capacity)
            {
                throw new InvalidBookingParameterException(
                    "A vendégszám nem lehet nagyobb, mint a kiválasztott szoba maximális férőhelye!");
            }
        }

        #endregion
    }
}
