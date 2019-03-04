using System;

namespace virtual_receptionist.Models.ORM
{
    /// <summary>
    /// Céges foglalások egyed
    /// </summary>
    public class CompanyBooking : Booking
    {
        #region Adattagok

        /// <summary>
        /// Company modell osztály egy példánya
        /// </summary>
        private Company company;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Booking osztály konstruktora
        /// </summary>
        /// <param name="id">Foglalás azonosító</param>
        /// <param name="guest">Guest egyed</param>
        /// <param name="company">Company egyed</param>
        /// <param name="room">Room egyed</param>
        /// <param name="numberOfGuests">Vendégek száma</param>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <param name="departureDate">Távozás dátuma</param>
        public CompanyBooking(int id, Guest guest, Company company, Room room, int numberOfGuests, DateTime arrivalDate,
            DateTime departureDate) : base(id, guest, room, numberOfGuests, arrivalDate, departureDate)
        {
            this.company = company;
        }

        /// <summary>
        /// Booking osztály üres konstruktora
        /// </summary>
        public CompanyBooking()
        {
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Company modell osztály egy példánya
        /// </summary>
        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// CompnayBooking osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a CompanyBooking típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{id} {guest} {company} {room} {numberOfGuests} {arrivalDate} {departureDate}";
        }

        #endregion
    }
}
