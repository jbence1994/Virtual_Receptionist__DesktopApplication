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
        private void UploadPrivateGuestsList()
        {
            string sql =
                "SELECT guest.Name, guest.DocumentNumber, guest.Citizenship, guest.BirthDate, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.VATNumber, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID AND guest.DocumentNumber != \"\"";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
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

                PrivateGuest privateGuestInstance = new PrivateGuest(name, documentNumber, citizenship, birthDate,
                    country, zipCode, city, address, phoneNumber, emailAddress);

                privateGuests.Add(privateGuestInstance);
            }
        }

        private void UploadCorporateGuestList()
        {
            string sql =
                "SELECT guest.Name, guest.VATNumber, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.VATNumber, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID AND guest.VATNumber != \"\"";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                string vatNumber = row["VATNumber"].ToString();
                string country = row["CountryName"].ToString();
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();
                string address = row["Address"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                CorporateGuest corporateGuestInstance = new CorporateGuest(name, vatNumber, country, zipCode, city,
                    address, phoneNumber, emailAddress);

                corporateGuests.Add(corporateGuestInstance);
            }
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes vendéget egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetGuests()
        {
            if (privateGuests.Count == 0 && corporateGuests.Count == 0)
            {
                UploadPrivateGuestsList();
                UploadCorporateGuestList();
            }

            DataTable guestsDataTable = new DataTable();
            guestsDataTable.Columns.Add("Name", typeof(string));
            guestsDataTable.Columns.Add("DocumentNumber", typeof(string));
            guestsDataTable.Columns.Add("Citizenship", typeof(string));
            guestsDataTable.Columns.Add("BirthDate", typeof(string));
            guestsDataTable.Columns.Add("VATNumber", typeof(string));
            guestsDataTable.Columns.Add("Country", typeof(string));
            guestsDataTable.Columns.Add("ZipCode", typeof(string));
            guestsDataTable.Columns.Add("City", typeof(string));
            guestsDataTable.Columns.Add("Address", typeof(string));
            guestsDataTable.Columns.Add("PhoneNumber", typeof(string));
            guestsDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (PrivateGuest privateGuest in privateGuests)
            {
                guestsDataTable.Rows.Add(privateGuest.Name, privateGuest.DocumentNumber, privateGuest.Citizenship,
                    privateGuest.BirthDate, null, privateGuest.Country, privateGuest.ZipCode, privateGuest.City,
                    privateGuest.Address, privateGuest.PhoneNumber, privateGuest.EmailAddress);
            }

            foreach (CorporateGuest corporateGuest in corporateGuests)
            {
                guestsDataTable.Rows.Add(corporateGuest.Name, null, null, null, corporateGuest.VatNumber,
                    corporateGuest.Country, corporateGuest.ZipCode, corporateGuest.City, corporateGuest.Address,
                    corporateGuest.PhoneNumber, corporateGuest.EmailAddress);
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
            bool nationality = false;

            //if (guest.Nationality == "belföldi")
            //{
            //    nationality = true;
            //}

            //string sql =
            //    $"UPDATE guest SET guest.Name=\"{guest.Name}\", guest.Nationality=\"{nationality.ToString()}\", guest.Country=\"{guest.Country}\", guest.ZipCode=\"{guest.ZipCode}\", guest.City=\"{guest.City}\", guest.Address=\"{guest.Address}\", guest.VATNumber=\"{guest.VatNumber}\", guest.PhoneNumber=\"{guest.PhoneNumber}\", guest.EmailAddress=\"{guest.EmailAddress}\" WHERE guest.Name LIKE \"{guest.Name}\"";
            //database.DML(sql);
        }

        /// <summary>
        /// Vendég létrehozása
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void CreateGuest(Guest guest)
        {
            bool nationality;

            //if (guest.Nationality == "belföldi")
            //{
            //    nationality = true;
            //}
            //else
            //{
            //    nationality = false;
            //}

            //string sql =
            //    $"INSERT INTO guest(Name, Nationality, Country, ZipCode, City, Address, VATNumber, PhoneNumber, EmailAddress) VALUES(\"{guest.Name}\", \"{nationality.ToString()}\", \"{guest.Country}\", \"{guest.ZipCode}\", \"{guest.City}\", \"{guest.Address}\", \"{guest.VatNumber}\", \"{guest.PhoneNumber}\", \"{guest.EmailAddress}\"";
            //database.DML(sql);
        }

        #endregion
    }
}
