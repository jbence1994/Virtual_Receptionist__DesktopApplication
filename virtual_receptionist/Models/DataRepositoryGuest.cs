using System;
using System.Data;
using System.Security.Policy;

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
                "SELECT privateGuest.Name, privateGuest.DocumentNumber, privateGuest.Citizenship, privateGuest.BirthDate, country.CountryName, privateGuest.ZipCode, privateGuest.City, privateGuest.Address, privateGuest.VATNumber, privateGuest.PhoneNumber, privateGuest.EmailAddress FROM privateGuest, country WHERE privateGuest.Country = country.ID AND privateGuest.DocumentNumber != \"\"";
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

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a céges vendégeket és lista adatszerkezetbe menti őket
        /// </summary>
        private void UploadCorporateGuestList()
        {
            string sql =
                "SELECT privateGuest.Name, privateGuest.VATNumber, country.CountryName, privateGuest.ZipCode, privateGuest.City, privateGuest.Address, privateGuest.VATNumber, privateGuest.PhoneNumber, privateGuest.EmailAddress FROM privateGuest, country WHERE privateGuest.Country = country.ID AND privateGuest.VATNumber != \"\"";
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
        public DataTable GetPrivateGuests()
        {
            if (privateGuests.Count == 0)
            {
                UploadPrivateGuestsList();
            }

            DataTable privateGuestsDataTable = new DataTable();
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
                privateGuestsDataTable.Rows.Add(privateGuest.Name, privateGuest.DocumentNumber,
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
                corporateGuestDataTable.Rows.Add(corporateGuest.Name, corporateGuest.VatNumber,
                    corporateGuest.Country, corporateGuest.ZipCode, corporateGuest.City, corporateGuest.Address,
                    corporateGuest.PhoneNumber, corporateGuest.EmailAddress);
            }

            return corporateGuestDataTable;
        }

        /// <summary>
        /// Vendég törlése
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void DeleteGuest(PrivateGuest privateGuest)
        {
            string sql = $"DELETE FROM guest WHERE guest.Name LIKE \"{privateGuest.Name}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Céges vendég törlése
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void DeleteGuest(CorporateGuest corporateGuest)
        {
            string sql = $"DELETE FROM guest WHERE guest.Name LIKE \"{corporateGuest.Name}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void UpdateGuest(PrivateGuest privateGuest)
        {
            string sql =
                $"UPDATE guest SET guest.Name=\"{privateGuest.Name}\", guest.DocumentNumber=\"{privateGuest.DocumentNumber}\", guest.Citizenship=\"{privateGuest.Citizenship}\", guest.BirthDate=\"{privateGuest.BirthDate}\", guest.Country=\"{privateGuest.Country}\", guest.ZipCode=\"{privateGuest.ZipCode}\", guest.City=\"{privateGuest.City}\", guest.Address=\"{privateGuest.Address}\", guest.PhoneNumber=\"{privateGuest.PhoneNumber}\", guest.EmailAddress=\"{privateGuest.EmailAddress}\" WHERE guest.Name LIKE \"{privateGuest.Name}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void UpdateGuest(CorporateGuest corporateGuest)
        {
            string sql =
                $"UPDATE guest SET guest.Name=\"{corporateGuest.Name}\", guest.VATNumber=\"{corporateGuest.VatNumber}\", guest.Country=\"{corporateGuest.Country}\", guest.ZipCode=\"{corporateGuest.ZipCode}\", guest.City=\"{corporateGuest.City}\", guest.Address=\"{corporateGuest.Address}\", guest.PhoneNumber=\"{corporateGuest.PhoneNumber}\", guest.EmailAddress=\"{corporateGuest.EmailAddress}\" WHERE guest.Name LIKE \"{corporateGuest.Name}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég létrehozása
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void CreateGuest(PrivateGuest privateGuest)
        {
            string sql =
                $"INSERT INTO guest(Name, DocumentNumber, Citizenship, BirthDate, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{privateGuest.Name}\", \"{privateGuest.DocumentNumber}\", \"{privateGuest.Citizenship}\", \"{privateGuest.BirthDate}\", \"{privateGuest.Country}\", \"{privateGuest.ZipCode}\", \"{privateGuest.City}\", \"{privateGuest.Address}\", \"{privateGuest.PhoneNumber}\", \"{privateGuest.EmailAddress}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void CreateGuest(CorporateGuest corporateGuest)
        {
            string sql =
                $"INSERT INTO guest(Name, VATNumber, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{corporateGuest.Name}\", \"{corporateGuest.VatNumber}\", \"{corporateGuest.Country}\", \"{corporateGuest.ZipCode}\", \"{corporateGuest.City}\", \"{corporateGuest.Address}\", \"{corporateGuest.PhoneNumber}\", \"{corporateGuest.EmailAddress}\"";
            database.DML(sql);
        }

        #endregion
    }
}
