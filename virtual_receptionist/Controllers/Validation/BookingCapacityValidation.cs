using System;
using virtual_receptionist.Models;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Foglalás vendégszámát és szoba kapacitását ellenőrző osztály
    /// </summary>
    public class BookingCapacityValidation
    {
        #region Adattagok

        /// <summary>
        /// Fogolalás egyed egy példánya
        /// </summary>
        private readonly Booking booking;

        /// <summary>
        /// Szoba egyed
        /// </summary>
        private readonly Room room;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalás vendégszámát és szoba kapacitását ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="booking">Foglalás egyed</param>
		/// <param name="room">Szoba egyed</param>
        public BookingCapacityValidation(Booking booking, Room room)
        {
            this.booking = booking;
            this.room = room;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Foglalás vendégszámát és szoba kapacitását ellenőrző metódus
        /// </summary>
        /// <exception cref="InvalidBookingParameterException"></exception>
        public void ValidateBookingCapacity()
        {
            if (booking.NumberOfGuests > booking.Room.Capacity)
            {
                throw new Exception("A vendégek száma nem lehet nagyobb, mint a kiválasztott szoba maximális férőhelye!");
            }
        }

        #endregion
    }
}
