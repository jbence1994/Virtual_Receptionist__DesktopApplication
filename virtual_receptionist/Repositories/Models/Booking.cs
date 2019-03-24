namespace virtual_receptionist.Repositories.Models
{
    /// <summary>
    /// Foglalások egyed
    /// </summary>
    public class Booking
    {
        #region Adattagok

        /// <summary>
        /// Foglalás azonosító
        /// </summary>
        private int id;

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
        private string arrivalDate;

        /// <summary>
        /// Távozás dátuma
        /// </summary>
        private string departureDate;

        /// <summary>
        /// Foglalás fizetve van-e
        /// </summary>
        private bool paid;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Booking osztály konstruktora
        /// </summary>
        /// <param name="id">Foglalás azonosító</param>
        /// <param name="guest">Guest egyed</param>
        /// <param name="room">Room egyed</param>
        /// <param name="numberOfGuests">Vendégek száma</param>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <param name="departureDate">Távozás dátuma</param>
        /// <param name="paid">Foglalás fizetve van-e</param>
        public Booking(int id, Guest guest, Room room, int numberOfGuests, string arrivalDate,
            string departureDate, bool paid)
        {
            this.id = id;
            this.guest = guest;
            this.room = room;
            this.numberOfGuests = numberOfGuests;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
            this.paid = paid;
        }

        /// <summary>
        /// Booking osztály konstruktora
        /// </summary>
        /// <param name="id">Foglalás azonosító</param>
        /// <param name="guest">Guest egyed</param>
        /// <param name="room">Room egyed</param>
        /// <param name="numberOfGuests">Vendégek száma</param>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <param name="departureDate">Távozás dátuma</param>
        public Booking(int id, Guest guest, Room room, int numberOfGuests, string arrivalDate,
            string departureDate)
        {
            this.id = id;
            this.guest = guest;
            this.room = room;
            this.numberOfGuests = numberOfGuests;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
        }

        /// <summary>
        /// Booking osztály konstruktora
        /// </summary>
        /// <param name="guest">Guest egyed</param>
        /// <param name="room">Room egyed</param>
        /// <param name="numberOfGuests">Vendégek száma</param>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <param name="departureDate">Távozás dátuma</param>
        /// <param name="paid">Foglalás fizetve van-e</param>
        public Booking(Guest guest, Room room, int numberOfGuests, string arrivalDate,
            string departureDate, bool paid)
        {
            this.guest = guest;
            this.room = room;
            this.numberOfGuests = numberOfGuests;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
            this.paid = paid;
        }

        /// <summary>
        /// Booking osztály üres konstruktora
        /// </summary>
        public Booking()
        {
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Foglalás azonosító
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

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
        public string ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        /// <summary>
        /// Távozás dátuma
        /// </summary>
        public string DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        /// <summary>
        /// Foglalás fizetve van-e
        /// </summary>
        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Booking osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Booking típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{id} {guest} {room} {numberOfGuests} {arrivalDate} {departureDate} {paid}";
        }

        #endregion
    }
}
