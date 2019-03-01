using virtual_receptionist.DataAccessLayer.Model;
using System.Collections.Generic;
using System.Data;

namespace virtual_receptionist.DataAccessLayer.PersistentDataRepository
{
    /// <summary>
    /// Vendég adattár
    /// </summary>
    public class GuestRepository : Repository, IManipulable<Guest>, IManipulable<Company>
    {
        #region Adattagok

        /// <summary>
        /// Magánvendégeket tartalmazó lista
        /// </summary>
        private static List<Guest> guests;

        /// <summary>
        /// Cégeket tartalmazó lista
        /// </summary>
        private static List<Company> companies;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég adattár konstruktora
        /// </summary>
        public GuestRepository()
        {
            guests = new List<Guest>();
            companies = new List<Company>();
        }

        #endregion

        #region Getter tulajdonságok

        /// <summary>
        /// Vendégeket tartalmazó lista
        /// </summary>
        public static List<Guest> Guests
        {
            get
            {
                if (guests.Count == 0)
                {
                    UploadGuestsList();
                }

                return guests;
            }
        }

        /// <summary>
        /// Cégeket tartalmazó lista
        /// </summary>
        public static List<Company> Companies
        {
            get
            {
                if (companies.Count == 0)
                {
                    UploadCompaniesList();
                }

                return companies;
            }
        }

        #endregion

        #region Adatfeltöltő és adatmanipulúciós metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a vendégek adatait tartalmazó listát
        /// </summary>
        private static void UploadGuestsList()
        {
            string sql =
                "SELECT guest.ID, guest.Name, guest.DocumentNumber, guest.Citizenship, guest.BirthDate, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["ID"].ToString());
                string name = row["Name"].ToString();
                string documentNumber = row["DocumentNumber"].ToString();
                string citizenship = row["Citizenship"].ToString();
                string birthDate = DateTime.Parse(row["BirthDate"].ToString()).ToShortDateString();
                string country = row["CountryName"].ToString();
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();
                string address = row["Address"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                Guest privateGuestInstance = new Guest(id, name, documentNumber, citizenship, birthDate,
                    country, zipCode, city, address, phoneNumber, emailAddress);
                guests.Add(privateGuestInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a cégek adatait tartalmazó listát
        /// </summary>
        private static void UploadCompaniesList()
        {
            string sql =
                "SELECT company.ID, company.CompanyName, company.VATNumber, country.CountryName, company.ZipCode, company.City, company.Address, company.PhoneNumber, company.EmailAddress FROM company, country WHERE company.Country = country.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["ID"].ToString());
                string name = row["CompanyName"].ToString();
                string vatNumber = row["VATNumber"].ToString();
                string country = row["CountryName"].ToString();
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();
                string address = row["Address"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                Company companyInstance = new Company(id, name, vatNumber, country, zipCode, city, address, phoneNumber,
                    emailAddress);
                companies.Add(companyInstance);
            }
        }

        /// <summary>
        /// Meglévő vendég törlése adatbázisból
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void Delete(Guest guest)
        {
            string sql = $"DELETE FROM guest WHERE guest.ID LIKE \"{guest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő céges vendég törlése adatbázisból
        /// </summary>
        /// <param name="company">Company objektum</param>
        public void Delete(Company company)
        {
            string sql = $"DELETE FROM company WHERE company.ID LIKE \"{company.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő vendég módosítása adatbázisban
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void Update(Guest guest)
        {
            string sql =
                $"UPDATE guest SET guest.Name=\"{guest.Name}\", guest.DocumentNumber=\"{guest.DocumentNumber}\", guest.Citizenship=\"{guest.Citizenship}\", guest.BirthDate=\"{guest.BirthDate}\", guest.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{guest.Country}\"), guest.ZipCode=\"{guest.ZipCode}\", guest.City=\"{guest.City}\", guest.Address=\"{guest.Address}\", guest.PhoneNumber=\"{guest.PhoneNumber}\", guest.EmailAddress=\"{guest.EmailAddress}\" WHERE guest.ID LIKE \"{guest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő vendég módosítása adatbázisban
        /// </summary>
        /// <param name="company">Company objektum</param>
        public void Update(Company company)
        {
            string sql =
                $"UPDATE company SET company.CompanyName=\"{company.Name}\", company.VATNumber=\"{company.VatNumber}\", company.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{company.Country}\"), company.ZipCode=\"{company.ZipCode}\", company.City=\"{company.City}\", company.Address=\"{company.Address}\", company.PhoneNumber=\"{company.PhoneNumber}\", company.EmailAddress=\"{company.EmailAddress}\" WHERE company.ID LIKE \"{company.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Új vendég létrehozása adatbázisban
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void Create(Guest guest)
        {
            string sql =
                $"INSERT INTO guest(Name, DocumentNumber, Citizenship, BirthDate, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{guest.Name}\", \"{guest.DocumentNumber}\", \"{guest.Citizenship}\", \"{guest.BirthDate}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{guest.Country}\"), \"{guest.ZipCode}\", \"{guest.City}\", \"{guest.Address}\", \"{guest.PhoneNumber}\", \"{guest.EmailAddress}\")";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő vendég módosítása adatbázisban
        /// </summary>
        /// <param name="company">Company objektum</param>
        public void Create(Company company)
        {
            string sql =
                $"INSERT INTO company(CompanyName, VATNumber, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{company.Name}\", \"{company.VatNumber}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{company.Country}\"), \"{company.ZipCode}\", \"{company.City}\", \"{company.Address}\", \"{company.PhoneNumber}\", \"{company.EmailAddress}\")";
            database.DML(sql);
        }

        /// <summary>
        /// Metódus, amely visszaadja a soron következő vendégazonosítót adatbázisból
        /// </summary>
        /// <returns>Az adatbázisban soron következő vendégazonosítót adja vissza a függvény</returns>
        public int GetNextGuestID()
        {
            string sql = "SELECT MAX(guest.ID) FROM guest";
            string maxID = database.ScalarDQL(sql);

            int.TryParse(maxID, out int nextID);

            return nextID + 1;
        }

        /// <summary>
        /// Metódus, amely visszaadja a soron következő cégazonosítót adatbázisból
        /// </summary>
        /// <returns>Az adatbázisban soron következő cégazonosítót adja vissza a függvény</returns>
        public int GetNextCompanyID()
        {
            string sql = "SELECT MAX(company.ID) FROM company";
            string maxID = database.ScalarDQL(sql);

            int.TryParse(maxID, out int nextID);

            return nextID + 1;
        }

        #endregion
    }
}
