using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Repositories.Models;

namespace virtual_receptionist.Controllers.Validation
{
    public class FreeCapacityValidaiton
    {
        #region Adattagok

        /// <summary>
        /// 
        /// </summary>
        private Room room;

        /// <summary>
        /// 
        /// </summary>
        private Booking booking;

        #endregion

        #region Konstruktor

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public void dd()
        {
            throw new InvalidCapacityException();
        }

        #endregion
    }
}
