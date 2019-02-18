using System;

namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Számlázási adat egyed modell osztálya
    /// </summary>
    public class BillingData
    {
        #region Adattagok

        /// <summary>
        /// Számlázási adat azonosítója
        /// </summary>
        private int id;

        /// <summary>
        /// Vendég neve
        /// </summary>
        private string guestName;

        /// <summary>
        /// Szobaszám
        /// </summary>
        private int roomNumber;

        /// <summary>
        /// Szobakategória
        /// </summary>
        private string roomCategory;

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

        #region Konstruktor

        /// <summary>
        /// BillingData osztály konstruktora
        /// </summary>
        /// <param name="id">Számlázási adat azonosítója</param>
        /// <param name="guestName">Vendég neve</param>
        /// <param name="roomNumber">Szobaszám</param>
        /// <param name="roomCategory">Szobakategória</param>
        /// <param name="numberOfGuests">Vendégek száma</param>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <param name="departureDate">Távozás dátuma</param>
        public BillingData(int id, string guestName, int roomNumber, string roomCategory, int numberOfGuests,
            DateTime arrivalDate, DateTime departureDate)
        {
            this.id = id;
            this.guestName = guestName;
            this.roomNumber = roomNumber;
            this.roomCategory = roomCategory;
            this.numberOfGuests = numberOfGuests;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Számlázási adat azonosítója
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Vendég neve
        /// </summary>
        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }

        /// <summary>
        /// Szobaszám
        /// </summary>
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        /// <summary>
        /// Szobakategória
        /// </summary>
        public string RoomCategory
        {
            get { return roomCategory; }
            set { roomCategory = value; }
        }

        /// <summary>
        /// Vendégek száma
        /// </summary>
        public int NumberOfGuest
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
        /// BillingData osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a BillingData típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{id} {guestName} {roomNumber} {roomCategory} {numberOfGuests} {arrivalDate} {departureDate}";
        }

        #endregion
    }
}
