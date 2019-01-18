using System;
using System.Data;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Vendégadatbázis-kezelő modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a vendégeket és lista adatszerkezetek menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void UploadGuestsList()
        {
            string sql = "SELECT guest.Name, guest.Nationality, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.VATNumber, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                bool nationality = Convert.ToBoolean(row["Nationality"]);
                string country = row["CountryName"].ToString();
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();
                string address = row["Address"].ToString();
                string vatNumber = row["VATNumber"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                Guest guestInstance = new Guest(name, nationality, country, zipCode, city, address, vatNumber, phoneNumber, emailAddress);
                guests.Add(guestInstance);
            }
        }
        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes vendéget egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetGuests()
        {
            UploadGuestsList();

            DataTable guestsDataTable = new DataTable();
            guestsDataTable.Columns.Add("Name", typeof(string));
            guestsDataTable.Columns.Add("Nationality", typeof(string));
            guestsDataTable.Columns.Add("Country", typeof(string));
            guestsDataTable.Columns.Add("ZipCode", typeof(string));
            guestsDataTable.Columns.Add("City", typeof(string));
            guestsDataTable.Columns.Add("Address", typeof(string));
            guestsDataTable.Columns.Add("VATNumber", typeof(string));
            guestsDataTable.Columns.Add("PhoneNumber", typeof(string));
            guestsDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (Guest guest in guests)
            {
                guestsDataTable.Rows.Add(guest.Name, guest.Nationality, guest.Country, guest.ZipCode, guest.City, guest.Address, guest.VatNumber, guest.PhoneNumber, guest.EmailAddress);
            }

            return guestsDataTable;
        }
        /// <summary>
        /// Vendég törlése
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void DeleteGuest(Guest guest)
        {
            string sql = $"DELETE FROM guest WHERE guest.Name LIKE \"{guest.Name}\"";
            database.DML(sql);
        }
        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void UpdateGuest(Guest guest)
        {
            string sql = $"UPDATE guest SET guest.Name=\"{guest.Name}\", guest.Nationality=\"{guest.Nationality}\", guest.Country=\"{guest.Country}\", guest.ZipCode=\"{guest.ZipCode}\", guest.City=\"{guest.City}\", guest.Address=\"{guest.Address}\", guest.VATNumber=\"{guest.VatNumber}\", guest.PhoneNumber=\"{guest.PhoneNumber}\", guest.EmailAddress=\"{guest.EmailAddress}\" WHERE guest.Name LIKE \"{guest.Name}\"";
            database.DML(sql);
        }
        /// <summary>
        /// Vendég létrehozása
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void CreateGuest(Guest guest)
        {
            string sql = $"INSERT INTO guest(Name, Nationality, Country, ZipCode, City, Address, VATNumber, PhoneNumber, EmailAddress) VALUES(\"{guest.Name}\", \"{guest.Nationality}\", \"{guest.Country}\", \"{guest.ZipCode}\", \"{guest.City}\", \"{guest.Address}\", \"{guest.VatNumber}\", \"{guest.PhoneNumber}\", \"{guest.EmailAddress}\"";
            database.DML(sql);
        }

        #endregion
    }
}
