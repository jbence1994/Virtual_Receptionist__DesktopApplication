using System;
using System.Data;

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
        public void AddNewRecordToBookingTable()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteRecordFromBookingTable()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateRecordInBookingTable()
        {

        }

        #endregion
    }
}
