using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Repositories.Models;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Szabad szobakapacitás ellenőrző osztály
    /// </summary>
    public class FreeCapacityValidaiton
    {
        #region Adattagok

        /// <summary>
        /// Szoba egyed
        /// </summary>
        private Room room;

        /// <summary>
        /// Foglalás egyed
        /// </summary>
        private Booking booking;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Szabad szobakapacitás ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="room"></param>
        /// <param name="booking"></param>
        public FreeCapacityValidaiton(Room room, Booking booking)
        {
            this.room = room;
            this.booking = booking;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Szabad szobakapcitást ellenőrző metódus
        /// </summary>
        public void FreeCapacityValidation()
        {
            throw new InvalidCapacityException();
        }

        #endregion
    }
}
