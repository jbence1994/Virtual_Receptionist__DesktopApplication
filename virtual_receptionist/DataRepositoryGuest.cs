﻿using System.Data;
using System;

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
            DataTable dt = database.Query(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                string nationality = row["Nationality"].ToString();
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
        /// <exception cref="MySqlException"></exception>
        /// <exception cref="Exception"></exception>
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
        /// <exception cref="MySqlException"></exception>
        /// <exception cref="Exception"></exception>
        public void Delete(Guest guest)
        {

        }
        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <exception cref="MySqlException"></exception>
        /// <exception cref="Exception"></exception>
        public void Update(Guest guest)
        {

        }
        /// <summary>
        /// Vendég létrehozása
        /// </summary>
        /// <exception cref="MySqlException"></exception>
        /// <exception cref="Exception"></exception>
        public void Create(Guest guest)
        {

        }

        #endregion
    }
}
