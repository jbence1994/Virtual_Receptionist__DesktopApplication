using System.Collections.Generic;
using virtual_receptionist.Model.Entity;
using virtual_receptionist.Model.Interfaces;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository : IManipulable<Booking>
    {
        #region Foglalási napló modul üzleti logika

        /// <summary>
        /// Új foglalás felvétele adatbázisba
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Create(Booking booking)
        {
            string sql =
                $"INSERT INTO booking(GuestID, RoomID, NumberOfGuests, ArrivalDate, DepartureDate) VALUES ((SELECT guest.ID FROM guest WHERE guest.Name LIKE \"{booking.Guest.Name}\"), (SELECT room.ID FROM room WHERE room.Number LIKE \"{booking.Room.Number}\"), {booking.NumberOfGuests}, {booking.ArrivalDate}, {booking.DepartureDate});";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő foglalás törlése adatbázisból
        /// </summary>
        /// <param name="booking">Booking objektum</param>>
        public void Delete(Booking booking)
        {
            string sql = $"DELETE FROM booking WHERE ";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő foglalás módosítása adatbázisban
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Update(Booking booking)
        {
            string sql = $"UPDATE room SET WHERE";
            database.DML(sql);
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt szobakiadások adatait érkezés dátuma szerint egy adattáblában
        /// </summary>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        public List<Booking> GetBookingsByArrivalDate(string arrivalDate)
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            return new List<Booking>();
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt szobakiadások adatait távozás dátuma szerint egy adattáblában
        /// </summary>
        /// <param name="departureDate"></param>
        /// <returns></returns>
        public List<Booking> GetBookingsByDepartureDate(string departureDate)
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            return new List<Booking>();
        }

        #endregion
    }
}
