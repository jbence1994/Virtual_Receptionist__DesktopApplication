using System;

namespace virtual_receptionist.Models.ORM
{
    /// <summary>
    /// Vendég foglalások egyed
    /// </summary>
    public class GuestBooking : Booking
    {
        #region Konstruktorok

        /// <summary>
        /// GuestBooking osztály konstruktora
        /// </summary>
        /// <param name="id">Foglalás azonosító</param>
        /// <param name="guest">Guest egyed</param>
        /// <param name="room">Room egyed</param>
        /// <param name="numberOfGuests">Vendégek száma</param>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <param name="departureDate">Távozás dátuma</param>
        public GuestBooking(int id, Guest guest, Room room, int numberOfGuests, DateTime arrivalDate,
            DateTime departureDate) : base(id, guest, room, numberOfGuests, arrivalDate, departureDate)
        {
            this.id = id;
            this.guest = guest;
            this.room = room;
            this.numberOfGuests = numberOfGuests;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
        }

        /// <summary>
        /// GuestBooking osztály üres konstruktora
        /// </summary>
        public GuestBooking()
        {
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// GuestBooking osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a GuestBooking típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{id} {guest} {room} {numberOfGuests} {arrivalDate} {departureDate}";
        }

        #endregion
    }
}
