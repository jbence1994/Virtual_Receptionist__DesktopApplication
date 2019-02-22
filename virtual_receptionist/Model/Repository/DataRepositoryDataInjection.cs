using MySQL_ORM;
using System.Data;
using System.Collections.Generic;
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
        /// Metódus, amely adatbázisból feltölti az országok neveit tartalmazó listát
        /// </summary>
        /// <returns>Országok neveivel feltöltött listát adja vissza</returns>
        public List<Country> GetCountries()
        {
            if (countries.Count == 0)
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

            return countries;
        }

        #endregion
    }
}
