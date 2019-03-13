using System;
using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Models.ORM;
using static virtual_receptionist.Controllers.Validation.InputValidation;

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
        private Booking booking;

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
        /// <exception cref="InvalidBookingException"></exception>
        public void ValidateBooking()
        {
            if (true)
            {

            }
        }

        #endregion
    }
}
