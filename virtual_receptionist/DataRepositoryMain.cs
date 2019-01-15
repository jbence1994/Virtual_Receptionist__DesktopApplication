using System;
using System.Collections.Generic;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatokat tároló adattár osztály, amely az alkalmazás üzleti logikájáért is felel
    /// </summary>
    public partial class DataRepository
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító ORM osztály egy példánya
        /// </summary>
        private Database database;
        /// <summary>
        /// Számlázási tételeket tartalmazó lista
        /// </summary>
        private List<BillingItems> billingItems;
        /// <summary>
        /// Vendégeket tartalmazó lista
        /// </summary>
        private List<Guest> guests;
        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        private List<Country> countries;
        /// <summary>
        /// Magyarországi irányítószámokat és településeket tartalmazó lista
        /// </summary>
        private List<HungarianZipCodesAndCities> hungarianZipCodesAndCities;
        /// <summary>
        /// Szobákat tartalmazó lista
        /// </summary>
        private List<Room> rooms;
        /// <summary>
        /// Foglalásokat tartalmazó lista
        /// </summary>
        private List<Reservation> reservations;
        /// <summary>
        /// Alkalmazást futtató számítógép NetBIOS neve
        /// </summary>
        private static string client;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adattár konstruktora
        /// </summary>
        public DataRepository()
        {
            database = new Database();

            billingItems = new List<BillingItems>();
            guests = new List<Guest>();
            countries = new List<Country>();
            hungarianZipCodesAndCities = new List<HungarianZipCodesAndCities>();
            rooms = new List<Room>();
            reservations = new List<Reservation>();
        }

        #endregion

        #region Getter és setter metódusok

        /// <summary>
        /// Alkalmazást futtató számítógép NetBIOS neve
        /// </summary>
        public static string Client
        {
            get
            {
                return client = Environment.MachineName;
            }
        }

        #endregion
    }
}
