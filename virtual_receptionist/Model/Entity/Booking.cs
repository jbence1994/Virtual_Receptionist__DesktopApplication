using System;
using System.Collections.Generic;

namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Foglalások modell osztálya
    /// </summary>
    public class Booking
    {
        #region Adattagok

        /// <summary>
        /// Guest modell osztály egy példánya
        /// </summary>
        private Guest guest;

        /// <summary>
        /// Room modell osztály egy példánya
        /// </summary>
        private Room room;

        /// <summary>
        /// Vendégek száma
        /// </summary>
        private int numberOfGuests;

        /// <summary>
        /// Érkezés dátuma
        /// </summary>
        private DateTime arrivalDate;

        /// <summary>
        /// Távozás dátuma
        /// </summary>
        private DateTime departureDate;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Booking osztály konstruktora
        /// </summary>
        /// <param name="guest">Guest egyed</param>
        /// <param name="room">Room egyed</param>
        /// <param name="numberOfGuests">Vendégek száma</param>
        /// <param name="arrival">Érkezés dátuma</param>
        /// <param name="departure">Távozás dátuma</param>
        public Booking(Guest guest, Room room, int numberOfGuests, DateTime arrivalDate, DateTime departureDate)
        {
            this.guest = guest;
            this.room = room;
            this.numberOfGuests = numberOfGuests;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Guest modell osztály egy példánya
        /// </summary>
        public Guest Guest
        {
            get { return guest; }
            set { guest = value; }
        }

        /// <summary>
        /// Room modell osztály egy példánya
        /// </summary>
        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        /// <summary>
        /// Vendégek száma
        /// </summary>
        public int NumberOfGuests
        {
            get { return numberOfGuests; }
            set { numberOfGuests = value; }
        }

        /// <summary>
        /// Érkezés dátuma
        /// </summary>
        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        /// <summary>
        /// Távozás dátuma
        /// </summary>
        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Reservation osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Reservation típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{guest} {room} {numberOfGuests} {arrivalDate} {departureDate}";
        }

        #endregion
    }
}
