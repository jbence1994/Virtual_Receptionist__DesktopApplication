using virtual_receptionist.Models.ORM;
using System.Collections.Generic;
using System.Data;
using System;

namespace virtual_receptionist.Models.Data
{
    /// <summary>
    /// Vendég adattár
    /// </summary>
    public class GuestRepository : Repository, IManipulable<Guest>
    {
        #region Adattagok

        /// <summary>
        /// Vendégeket tartalmazó lista
        /// </summary>
        private List<Guest> guests;

        /// <summary>
        /// Országokat tartalmazó lista
        /// </summary>
        private List<Country> countries;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég adattár konstruktora
        /// </summary>
        public GuestRepository()
        {
            guests = new List<Guest>();
            countries = new List<Country>();
        }

        #endregion

        #region Adatfeltöltő metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a vendégek adatait tartalmazó listát
        /// </summary>
        private void UploadGuestsList()
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

        #endregion

        #region Adatelérési metódusok

        /// <summary>
        /// Metódus, amely feltölti a vendégeket tartalmazó listát adatbázisból
        /// </summary>
        /// <returns>Az adatokkal feltöltött listával tér vissza a metódus</returns>
        public List<Guest> GetGuests()
        {
            if (guests.Count == 0)
            {
                UploadGuestsList();
            }

            return guests;
        }

        #endregion

        #region Adatmanipulációs metódusok

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
        /// Új vendég létrehozása adatbázisban
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void Create(Guest guest)
        {
            string sql =
                $"INSERT INTO guest(Name, DocumentNumber, Citizenship, BirthDate, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{guest.Name}\", \"{guest.DocumentNumber}\", \"{guest.Citizenship}\", \"{guest.BirthDate}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{guest.Country}\"), \"{guest.ZipCode}\", \"{guest.City}\", \"{guest.Address}\", \"{guest.PhoneNumber}\", \"{guest.EmailAddress}\")";
            database.DML(sql);
        }

        #endregion

        #region Üzleti logika

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
        /// 
        /// </summary>
        public void GetSpecifiedGuestData()
        {

        }

        #endregion
    }
}
