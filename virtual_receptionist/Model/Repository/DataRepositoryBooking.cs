using System;
using System.Linq;
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
        /// Metódus, amely kiszűri a foglalások adatait tartalmazó listából azokat a foglalásokat, amelyek a paraméterben megadott dátum szerint érkeznek és egy új listába menti őket
        /// </summary>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <returns>A szűrt adatokkal feltöltött listával tér vissza a függvény</returns>
        public List<Booking> GetBookingsByArrivalDate(string arrivalDate)
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            List<Booking> bookingsByArrivalDate = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                if (booking.ArrivalDate == DateTime.Parse(arrivalDate))
                {
                    bookingsByArrivalDate.Add(booking);
                }
            }

            return bookingsByArrivalDate;
        }

        /// <summary>
        /// Metódus, amely kiszűri a foglalások adatait tartalmazó listából azokat a foglalásokat, amelyek a paraméterben megadott dátum szerint távoznak és egy új listába menti őket
        /// </summary>
        /// <param name="departureDate"></param>
        /// <returns>A szűrt adatokkal feltöltött listával tér vissza a függvény</returns>
        public List<Booking> GetBookingsByDepartureDate(string departureDate)
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            List<Booking> bookingsByDepartureDate = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                if (booking.DepartureDate == DateTime.Parse(departureDate))
                {
                    bookingsByDepartureDate.Add(booking);
                }
            }

            return bookingsByDepartureDate;
        }

        #endregion
    }
}
