using System;
using System.Data;
using MySQL_ORM;
using System.Collections.Generic;
using virtual_receptionist.Exceptions;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Model.Repository
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatokat tároló adattár osztály, amely az alkalmazás üzleti logikájáért felel
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
        private List<BillingItem> billingItems;

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
        private List<Booking> bookings;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adattár konstruktora
        /// </summary>
        public DataRepository()
        {
            database = Database.DatabaseInstance;

            accomodations = new List<Accomodation>();
            billingItems = new List<BillingItem>();
            privateGuests = new List<PrivateGuest>();
            corporateGuests = new List<CorporateGuest>();
            countries = new List<Country>();
            rooms = new List<Room>();
            bookings = new List<Booking>();
        }

        #endregion

        #region Getter és setter metódusok

        /// <summary>
        /// Alkalmazást futtató számítógép NetBIOS neve
        /// </summary>
        public static string Client
        {
            get { return Environment.MachineName; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a szálláshelyek adatait és lista adatszerkezetek menti őket
        /// </summary>
        private void UploadAccomodationList()
        {
            Accomodation accomodation = Accomodation.GetInstance;

            string sql =
                "SELECT accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress, accomodation_profile.AccomodationID, accomodation_profile.Password FROM accomodation, accomodation_profile WHERE accomodation.ID = accomodation_profile.Accomodation";
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
            return Accomodation.GetInstance;
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti az országok kódjait és neveit tartalmazó listát
        /// </summary>
        private void UploadCountriesList()
        {
            string sql = "SELECT * FROM country";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["CountryName"].ToString();

                Country countryInstance = new Country(name);
                countries.Add(countryInstance);
            }
        }

        /// <summary>
        /// Metódus, amely országok neveit tartalmazza
        /// </summary>
        /// <returns>Országok neveivel feltöltött listát adja vissza</returns>
        public List<Country> GetCountries()
        {
            if (countries.Count == 0)
            {
                UploadCountriesList();
            }

            return countries;
        }

        /// <summary>
        /// Metódus, amely beállítja az adatbáziskapcsolódás típusát és autentikációt végez az alkalmazásba belépéskor
        /// </summary>
        /// <param name="accomodationID">Szálláshely azonosító</param>
        /// <param name="password">Regisztrációhoz tartozó jelszó</param>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <returns>Egyezés esetén logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        /// <exception cref="FailedLoginException"></exception>
        /// <exception cref="InvalidConnectionTypeException"></exception>
        public bool Authentication(string accomodationID, string password, string connectionType)
        {
            try
            {
                bool entry = false;
                database.SetConnection(connectionType);

                UploadAccomodationList();

                foreach (Accomodation account in accomodations)
                {
                    if (account.AccomodationID == accomodationID && account.Password == password)
                    {
                        entry = true;
                        break;
                    }

                    throw new FailedLoginException();
                }

                return entry;
            }
            catch (InvalidConnectionTypeException)
            {
                throw new InvalidConnectionTypeException();
            }
        }

        /// <summary>
        /// Metódus, amely naplózza a bejelentkezéseket az alkalmazásba
        /// </summary>
        public void Login()
        {
            string sql =
                $"INSERT INTO log(Client, OS_Version, LoginDate, LogoutDate) VALUES (\"{Client}\", \"{Environment.OSVersion}\", \"{DateTime.Now}\", \"Logged in\")";
            database.DML(sql);
        }

        /// <summary>
        /// Metódus, amely naplózza a kijelentlezéseket az alkalmazásból
        /// </summary>
        public void Logout()
        {
            string sql =
                $"UPDATE log SET LogoutDate = \"{DateTime.Now}\" WHERE LogoutDate LIKE \"Logged in\"";
            database.DML(sql);
        }

        #endregion
    }
}
