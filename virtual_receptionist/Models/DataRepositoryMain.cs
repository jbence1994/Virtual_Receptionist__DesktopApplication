using System;
using virtual_receptionist.MySQL_ORM;
using System.Collections.Generic;
using System.Data;

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
        /// Szálláshelyek adatait tároló lista
        /// </summary>
        private List<Accomodation> accomodations;

        /// <summary>
        /// Számlázási tételeket tartalmazó lista
        /// </summary>
        private List<BillingItems> billingItems;

        /// <summary>
        /// Magánvendégeket tartalmazó lista
        /// </summary>
        private List<PrivateGuest> privateGuests;

        /// <summary>
        /// Vállalati vendégeket tartalmazó lista
        /// </summary>
        private List<CorporateGuest> corporateGuests;

        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        private List<Country> countries;

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

            accomodations = new List<Accomodation>();
            billingItems = new List<BillingItems>();
            privateGuests = new List<PrivateGuest>();
            corporateGuests = new List<CorporateGuest>();
            countries = new List<Country>();
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
            get { return client; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a szálláshelyek adatait és lista adatszerkezetek menti őket
        /// </summary>
        private void UploadAccomodationList()
        {
            Accomodation accomodation = Accomodation.AccomodationInstance;

            string sql =
                "SELECT accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress, accomodation.AccomodationID, accomodation.Password FROM accomodation, accomodation_registration WHERE accomodation.ID = accomodation_registration.Accomodation";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                accomodation.Name = row["AccomodationName"].ToString();
                accomodation.Company = row["CompanyName"].ToString();
                accomodation.Contact = row["Contact"].ToString();
                accomodation.VatNumber = row["VATNumber"].ToString();
                accomodation.Headquarters = row["Headquarters"].ToString();
                accomodation.Site = row["Site"].ToString();
                accomodation.PhoneNumber = row["PhoneNumber"].ToString();
                accomodation.EmailAddress = row["EmailAddress"].ToString();
                accomodation.AccomodationID = row["AccomodationID"].ToString();
                accomodation.Password = row["Password"].ToString();

                accomodations.Add(accomodation);
            }
        }

        /// <summary>
        /// Metódus, amely beállítja az adott szálláshely adatait
        /// </summary>
        public Accomodation SetAccomodation()
        {
            if (accomodations.Count == 0)
            {
                UploadAccomodationList();
            }

            return Accomodation.AccomodationInstance;
        }

        /// <summary>
        /// Metódus, amely naplózza az alkalmazásba bejelentkezést
        /// </summary>
        public void Login()
        {
            string sql =
                $"INSERT INTO desktop_log(Client, OS_Version, LoginDate, LogoutDate) VALUES (\"{client}\", \"{Environment.OSVersion}\", \"{DateTime.Now}\", \"Logged in...\")";
            database.DML(sql);
        }

        /// <summary>
        /// Metódus, amely naplózza az alkalmazásból kijelentkezést
        /// </summary>
        public void Logout()
        {
            string sql =
                $"UPDATE desktop_log SET LogoutDate = \"{DateTime.Now}\" WHERE LogoutDate LIKE \"Logged in...\"";
            database.DML(sql);
        }

        #endregion
    }
}
