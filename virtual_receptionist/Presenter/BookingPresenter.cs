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
        public DataTable GetBookings(string arrivalDate)
        {
            DataTable bookings = dataRepository.GetBookings();

            foreach (DataRow row in bookings.Rows)
            {
                DateTime arrival = (DateTime) row["ArrivalDate"];
                string vmi = arrival.ToString("yyyy-MM-dd");

                if (vmi == arrivalDate)
                {
                    throw new NotImplementedException();
                }
            }

            return null;
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

        #endregion
    }
}
