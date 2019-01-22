using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatokat tároló adattár osztály, amely az alkalmazás üzleti logikájáért is felel
    /// </summary>
    public partial class DataRepository
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke ORM osztály egy példánya
        /// </summary>
        private static Database database;
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
            database = Database.DatabaseInstance;
            client = Environment.MachineName;

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
                return client;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely beállítja az adott szálláshely adatait
        /// </summary>
        public Accomodation SetAccomodation()
        {
            Accomodation accomodation = Accomodation.AccomodationInstance;

            string sql =
                "SELECT accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress FROM accomodation, accomodation_registration WHERE accomodation.ID = accomodation_registration.Accomodation";

            try
            {
                DataTable accomodationData = database.DQL(sql);

                foreach (DataRow row in accomodationData.Rows)
                {
                    accomodation.Name = row["AccomodationName"].ToString();
                    accomodation.Company = row["CompanyName"].ToString();
                    accomodation.Contact = row["Contact"].ToString();
                    accomodation.VatNumber = row["VATNumber"].ToString();
                    accomodation.Headquarters = row["Headquarters"].ToString();
                    accomodation.Site = row["Site"].ToString();
                    accomodation.PhoneNumber = row["PhoneNumber"].ToString();
                    accomodation.EmailAddress = row["EmailAddress"].ToString();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return accomodation;
        }

        #endregion
    }
}
