using System.Data;
using System.Collections.Generic;
using virtual_receptionist.DataAccessLayer.Model;
using virtual_receptionist.DataAccessLayer.DatabaseConnection;

namespace virtual_receptionist.DataAccessLayer.Data
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatbázis adatokat perzisztensen tároló adattár osztály
    /// </summary>
    public class Repository
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke osztály egy példánya
        /// </summary>
        protected static Database database;

        /// <summary>
        /// Szálláshelyeket tartalmazó lista
        /// </summary>
        private static List<Accomodation> accomodations;

        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        private static List<Country> countries;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adattár konstruktora
        /// </summary>
        public Repository()
        {
            database = Database.DatabaseInstance;
            countries = new List<Country>();
            accomodations = new List<Accomodation>();
        }

        #endregion

        #region Getter tulajdonságok

        /// <summary>
        /// Szálláshely egyed
        /// </summary>
        public Accomodation Accomodation
        {
            get { return Accomodation.GetInstance; }
        }

        /// <summary>
        /// Szálláshelyeket tartalmazó lista
        /// </summary>
        public static List<Accomodation> Accomodations
        {
            get
            {
                if (accomodations.Count == 0)
                {
                    UploadAccomodationList();
                }

                return accomodations;
            }
        }

        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        protected static List<Country> Countries
        {
            get
            {
                if (countries.Count == 0)
                {
                    UploadCountriesList();
                }

                return countries;
            }
        }

        #endregion

        #region Adatelérési és adatfeltöltő metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti az országok adatait tartalmazó listát
        /// </summary>
        private static void UploadCountriesList()
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
        /// Metódus, amely adatbázisból feltölti a szálláshelyek adatait tartalmazó listát
        /// </summary>
        private static void UploadAccomodationList()
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

        #endregion
    }
}
