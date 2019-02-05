using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Vendégadatbázis-kezelő modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a vendégeket és lista adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void UploadPrivateGuestsList()
        {
            string sql =
                "SELECT guest.ID, guest.Name, guest.DocumentNumber, guest.Citizenship, guest.BirthDate, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.VATNumber, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID AND guest.DocumentNumber != \"\"";
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

                PrivateGuest privateGuestInstance = new PrivateGuest(id, name, documentNumber, citizenship, birthDate,
                    country, zipCode, city, address, phoneNumber, emailAddress);

                privateGuests.Add(privateGuestInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a céges vendégeket és lista adatszerkezetbe menti őket
        /// </summary>
        private void UploadCorporateGuestList()
        {
            string sql =
                "SELECT guest.ID, guest.Name, guest.VATNumber, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.VATNumber, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID AND guest.VATNumber != \"\"";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["ID"].ToString());
                string name = row["Name"].ToString();
                string vatNumber = row["VATNumber"].ToString();
                string country = row["CountryName"].ToString();
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();
                string address = row["Address"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                CorporateGuest corporateGuestInstance = new CorporateGuest(id, name, vatNumber, country, zipCode, city,
                    address, phoneNumber, emailAddress);

                corporateGuests.Add(corporateGuestInstance);
            }
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes vendéget egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetPrivateGuests()
        {
            if (privateGuests.Count == 0)
            {
                UploadPrivateGuestsList();
            }

            DataTable privateGuestsDataTable = new DataTable();
            privateGuestsDataTable.Columns.Add("ID", typeof(int));
            privateGuestsDataTable.Columns.Add("Name", typeof(string));
            privateGuestsDataTable.Columns.Add("DocumentNumber", typeof(string));
            privateGuestsDataTable.Columns.Add("Citizenship", typeof(string));
            privateGuestsDataTable.Columns.Add("BirthDate", typeof(string));
            privateGuestsDataTable.Columns.Add("Country", typeof(string));
            privateGuestsDataTable.Columns.Add("ZipCode", typeof(string));
            privateGuestsDataTable.Columns.Add("City", typeof(string));
            privateGuestsDataTable.Columns.Add("Address", typeof(string));
            privateGuestsDataTable.Columns.Add("PhoneNumber", typeof(string));
            privateGuestsDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (PrivateGuest privateGuest in privateGuests)
            {
                privateGuestsDataTable.Rows.Add(privateGuest.ID, privateGuest.Name, privateGuest.DocumentNumber,
                    privateGuest.Citizenship,
                    privateGuest.BirthDate, privateGuest.Country, privateGuest.ZipCode, privateGuest.City,
                    privateGuest.Address, privateGuest.PhoneNumber, privateGuest.EmailAddress);
            }

            return privateGuestsDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes céges vendéget egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetCorporateGuests()
        {
            if (corporateGuests.Count == 0)
            {
                UploadCorporateGuestList();
            }

            DataTable corporateGuestDataTable = new DataTable();
            corporateGuestDataTable.Columns.Add("ID", typeof(int));
            corporateGuestDataTable.Columns.Add("Name", typeof(string));
            corporateGuestDataTable.Columns.Add("VATNumber", typeof(string));
            corporateGuestDataTable.Columns.Add("Country", typeof(string));
            corporateGuestDataTable.Columns.Add("ZipCode", typeof(string));
            corporateGuestDataTable.Columns.Add("City", typeof(string));
            corporateGuestDataTable.Columns.Add("Address", typeof(string));
            corporateGuestDataTable.Columns.Add("PhoneNumber", typeof(string));
            corporateGuestDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (CorporateGuest corporateGuest in corporateGuests)
            {
                corporateGuestDataTable.Rows.Add(corporateGuest.ID, corporateGuest.Name, corporateGuest.VatNumber,
                    corporateGuest.Country, corporateGuest.ZipCode, corporateGuest.City, corporateGuest.Address,
                    corporateGuest.PhoneNumber, corporateGuest.EmailAddress);
            }

            return corporateGuestDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja a legutolsó vendégazonosítót
        /// </summary>
        /// <returns>A legutolsó vendégazonosítót adja vissza a függvény</returns>
        public string GetMaxGuestID()
        {
            return database.DQLScalar("SELECT MAX(guest.ID) FROM guest");
        }

        /// <summary>
        /// Vendég törlése
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void DeleteGuest(PrivateGuest privateGuest)
        {
            string sql = $"DELETE FROM guest WHERE guest.ID LIKE \"{privateGuest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Céges vendég törlése
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void DeleteGuest(CorporateGuest corporateGuest)
        {
            string sql = $"DELETE FROM guest WHERE guest.ID LIKE \"{corporateGuest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void UpdateGuest(PrivateGuest privateGuest)
        {
            string sql =
                $"UPDATE guest SET guest.Name=\"{privateGuest.Name}\", guest.DocumentNumber=\"{privateGuest.DocumentNumber}\", guest.Citizenship=\"{privateGuest.Citizenship}\", guest.BirthDate=\"{privateGuest.BirthDate}\", guest.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{privateGuest.Country}\"), guest.ZipCode=\"{privateGuest.ZipCode}\", guest.City=\"{privateGuest.City}\", guest.Address=\"{privateGuest.Address}\", guest.PhoneNumber=\"{privateGuest.PhoneNumber}\", guest.EmailAddress=\"{privateGuest.EmailAddress}\" WHERE guest.ID LIKE \"{privateGuest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void UpdateGuest(CorporateGuest corporateGuest)
        {
            string sql =
                $"UPDATE guest SET guest.Name=\"{corporateGuest.Name}\", guest.VATNumber=\"{corporateGuest.VatNumber}\", guest.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{corporateGuest.Country}\"), guest.ZipCode=\"{corporateGuest.ZipCode}\", guest.City=\"{corporateGuest.City}\", guest.Address=\"{corporateGuest.Address}\", guest.PhoneNumber=\"{corporateGuest.PhoneNumber}\", guest.EmailAddress=\"{corporateGuest.EmailAddress}\" WHERE guest.ID LIKE \"{corporateGuest.ID}\"";
            System.Diagnostics.Debug.WriteLine(sql);

            database.DML(sql);
        }

        /// <summary>
        /// Vendég létrehozása
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void CreateGuest(PrivateGuest privateGuest)
        {
            string sql =
                $"INSERT INTO guest(Name, DocumentNumber, Citizenship, BirthDate, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{privateGuest.Name}\", \"{privateGuest.DocumentNumber}\", \"{privateGuest.Citizenship}\", \"{privateGuest.BirthDate}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{privateGuest.Country}\"), \"{privateGuest.ZipCode}\", \"{privateGuest.City}\", \"{privateGuest.Address}\", \"{privateGuest.PhoneNumber}\", \"{privateGuest.EmailAddress}\")";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void CreateGuest(CorporateGuest corporateGuest)
        {
            string sql =
                $"INSERT INTO guest(Name, VATNumber, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{corporateGuest.Name}\", \"{corporateGuest.VatNumber}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{corporateGuest.Country}\"), \"{corporateGuest.ZipCode}\", \"{corporateGuest.City}\", \"{corporateGuest.Address}\", \"{corporateGuest.PhoneNumber}\", \"{corporateGuest.EmailAddress}\")";
            database.DML(sql);
        }

        #endregion
    }
}
