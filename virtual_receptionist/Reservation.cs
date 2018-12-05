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

        }
        /// <summary>
        /// Reservation osztály üres konstruktora
        /// </summary>
        public Reservation()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok



        #endregion


        #region Metódusok






        #endregion
    }
}
