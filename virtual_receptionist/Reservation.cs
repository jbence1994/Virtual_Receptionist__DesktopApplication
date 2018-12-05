using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist
{
    /// <summary>
    /// Foglalások modell osztálya
    /// </summary>
    public class Reservation
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
        private int numberOfGuest;
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
        /// Reservation osztály konstruktora
        /// </summary>
        public Reservation(Guest guest, Room room, int numberOfGuest, DateTime arrival, DateTime departure)
        {
            this.guest = guest;
            this.room = room;
            this.numberOfGuest = numberOfGuest;
            this.arrival = arrival;
            this.departure = departure;
        }
        /// <summary>
        /// Reservation osztály üres konstruktora
        /// </summary>
        public Reservation()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Guest modell osztály egy példánya
        /// </summary>
        public Guest Guest
        {
            get
            {
                return guest;
            }
            set
            {
                guest = value;
            }
        }
        /// <summary>
        /// Room modell osztály egy példánya
        /// </summary>
        public Room Room
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
            }
        }
        /// <summary>
        /// Vendégek száma
        /// </summary>
        public int NumberOfGuest
        {
            get
            {
                return numberOfGuest;
            }
            set
            {
                numberOfGuest = value;
            }
        }
        /// <summary>
        /// Érkezés dátuma
        /// </summary>
        public DateTime Arrival
        {
            get
            {
                return arrival;
            }
            set
            {
                arrival = value;
            }
        }
        /// <summary>
        /// Távozás dátuma
        /// </summary>
        public DateTime Departure
        {
            get
            {
                return departure;
            }
            set
            {
                departure = value;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Reservation osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Reservation típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return guest + "" + room + "" + numberOfGuest + "" + arrival + "" + departure;
        }

        #endregion
    }
}
