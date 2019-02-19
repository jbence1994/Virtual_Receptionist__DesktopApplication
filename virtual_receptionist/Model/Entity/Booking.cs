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
        private List<Guest> guests;

        /// <summary>
        /// Room modell osztály egy példánya
        /// </summary>
        private List<Room> rooms;

        /// <summary>
        /// Vendégek száma
        /// </summary>
        private int numberOfGuests;

        /// <summary>
        /// Érkezés dátuma
        /// </summary>
        private DateTime arrival;

        /// <summary>
        /// Távozás dátuma
        /// </summary>
        private DateTime departure;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Booking osztály konstruktora
        /// </summary>
        public Booking(List<Guest> guests, List<Room> rooms, int numberOfGuests, DateTime arrival, DateTime departure)
        {
            this.guests = guests;
            this.rooms = rooms;
            this.numberOfGuests = numberOfGuests;
            this.arrival = arrival;
            this.departure = departure;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Guest modell osztály egy példánya
        /// </summary>
        public List<Guest> Guests
        {
            get { return guests; }
            set { guests = value; }
        }

        /// <summary>
        /// Room modell osztály egy példánya
        /// </summary>
        public List<Room> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
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
        public DateTime Arrival
        {
            get { return arrival; }
            set { arrival = value; }
        }

        /// <summary>
        /// Távozás dátuma
        /// </summary>
        public DateTime Departure
        {
            get { return departure; }
            set { departure = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Reservation osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Reservation típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{guests} {rooms} {numberOfGuests} {arrival} {departure}";
        }

        #endregion
    }
}
