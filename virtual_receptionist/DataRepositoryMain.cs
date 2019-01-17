using System;
using System.Data;
using System.Collections.Generic;
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

        #region Metódusok

        /// <summary>
        /// Metódus, amely beállítja az adott szálláshely adatait
        /// </summary>
        public Accomodation SetAccomodation()
        {
            string sql = "SELECT accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress FROM accomodation, accomodation_registration WHERE accomodation.ID = accomodation_registration.Accomodation";

            Accomodation accomodation = Accomodation.AccomodationInstance;

            try
            {
                DataTable dt = database.Query(sql);

                foreach (DataRow row in dt.Rows)
                {
                    string name = row["AccomodationName"].ToString();
                    string company = row["CompanyName"].ToString();
                    string contact = row["Contact"].ToString();
                    string vat = row["VATNUmber"].ToString();
                    string headquarters = row["Headquarters"].ToString();
                    string site = row["Site"].ToString();
                    string phoneNumber = row["PhoneNumber"].ToString();
                    string emailAddress = row["EmailAddress"].ToString();

                    accomodation.Name = name;
                    accomodation.Company = company;
                    accomodation.Contact = contact;
                    accomodation.VatNumber = vat;
                    accomodation.Headquarters = headquarters;
                    accomodation.Site = site;
                    accomodation.PhoneNumber = phoneNumber;
                    accomodation.EmailAddress = emailAddress;
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
