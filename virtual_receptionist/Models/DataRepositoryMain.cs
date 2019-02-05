using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using MySQL_ORM;
using virtual_receptionist.Exceptions;

namespace virtual_receptionist.Model
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
            Accomodation accomodation = Accomodation.GetInstance;

            string sql =
                "SELECT accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress FROM accomodation";
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
        /// Metódus, amely összehasonlítja a felhasználó által megadott felhasználónevet és jelszót, egyezik-e az érvényes, előre regisztrált felhasználói fiókkal
        /// </summary>
        /// <param name="accomodationID">Szálláshely azonosító</param>
        /// <param name="password">Regisztrációhoz tartozó jelszó</param>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <returns>Egyezés esetén logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public bool Authentication(string accomodationID, string password, string connectionType)
        {
            bool entry = false;

            try
            {
                string sql =
                    "SELECT accomodation_profile.AccomodationID, accomodation_profile.Password FROM accomodation_profile";
                database.SetConnection(connectionType);

                var findAccount = from account in accomodations
                    where account.AccomodationID == accomodationID
                    select account;

                if (true)
                {

                }
                else
                {
                    throw new LoginException("Hibás szállásazonosító vagy jelszó!");
                }

                entry = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return entry;
        }

        /// <summary>
        /// Metódus, amely naplózza a bejelentkezéseket az alkalmazásba
        /// </summary>
        public void Login()
        {
            string sql =
                $"INSERT INTO desktop_log(Client, OS_Version, LoginDate, LogoutDate) VALUES (\"{client}\", \"{Environment.OSVersion}\", \"{DateTime.Now}\", \"Logged in\")";
            database.DML(sql);
        }

        /// <summary>
        /// Metódus, amely naplózza a kijelentlezéseket az alkalmazásból
        /// </summary>
        public void Logout()
        {
            string sql =
                $"UPDATE desktop_log SET LogoutDate = \"{DateTime.Now}\" WHERE LogoutDate LIKE \"Logged in\"";
            database.DML(sql);
        }

        #endregion
    }
}
