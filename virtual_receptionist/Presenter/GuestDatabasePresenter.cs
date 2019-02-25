using System;
using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Vendégadatbázis-kezelő prezentere
    /// </summary>
    public class GuestDatabasePresenter : DefaultPresenter
    {
        #region Vendégadatbázis-kezelő nézetfrissítései

        /// <summary>
        /// Metódus, amely lekéri a cégek adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A cégek adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetCompanies()
        {
            List<Company> companies = dataRepository.Companies;

            DataTable companyDataTable = new DataTable();
            companyDataTable.Columns.Add("ID", typeof(int));
            companyDataTable.Columns.Add("Name", typeof(string));
            companyDataTable.Columns.Add("VATNumber", typeof(string));
            companyDataTable.Columns.Add("Country", typeof(string));
            companyDataTable.Columns.Add("ZipCode", typeof(string));
            companyDataTable.Columns.Add("City", typeof(string));
            companyDataTable.Columns.Add("Address", typeof(string));
            companyDataTable.Columns.Add("PhoneNumber", typeof(string));
            companyDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (Company company in companies)
            {
                companyDataTable.Rows.Add(company.ID, company.Name, company.VatNumber,
                    company.Country, company.ZipCode, company.City, company.Address,
                    company.PhoneNumber, company.EmailAddress);
            }

            return companyDataTable;
        }

        /// <summary>
        /// Metódus, amely lekéri a vendégek adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A vendégek adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetGuests()
        {
            List<Guest> guests = dataRepository.Guests;

            DataTable guestDataTable = new DataTable();
            guestDataTable.Columns.Add("ID", typeof(int));
            guestDataTable.Columns.Add("Name", typeof(string));
            guestDataTable.Columns.Add("DocumentNumber", typeof(string));
            guestDataTable.Columns.Add("Citizenship", typeof(string));
            guestDataTable.Columns.Add("BirthDate", typeof(string));
            guestDataTable.Columns.Add("Country", typeof(string));
            guestDataTable.Columns.Add("ZipCode", typeof(string));
            guestDataTable.Columns.Add("City", typeof(string));
            guestDataTable.Columns.Add("Address", typeof(string));
            guestDataTable.Columns.Add("PhoneNumber", typeof(string));
            guestDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (Guest guest in guests)
            {
                guestDataTable.Rows.Add(guest.ID, guest.Name, guest.DocumentNumber,
                    guest.Citizenship, guest.BirthDate, guest.Country, guest.ZipCode,
                    guest.City, guest.Address, guest.PhoneNumber, guest.EmailAddress);
            }

            return guestDataTable;
        }

        /// <summary>
        /// Metódus, amely beállítja a vendégtáblázat alapján ComboBoxban a kijelölt rekord országát
        /// </summary>
        /// <param name="selectedCountryInTable">Táblázatban kijelölt ország</param>
        public Country SetSelectedCountry(string selectedCountryInTable)
        {
            Country selectedCountry = null;

            foreach (Country country in GetCountries())
            {
                if (selectedCountryInTable.Contains(country.Name))
                {
                    selectedCountry = country;
                }
            }

            return selectedCountry;
        }

        /// <summary>
        /// Metódus, amely visszaadja a vendégek tábla soron következő azonosítóját
        /// </summary>
        /// <returns>Soron következő vendégazonosítóval tér vissza a függvény</returns>
        public int GetNextGuestID()
        {
            return dataRepository.GetNextGuestID();
        }

        /// <summary>
        /// Metódus, amely visszaadja a céges vendégek tábla soron következő azonosítóját
        /// </summary>
        /// <returns>Soron következő cégazonosítóval tér vissza a függvény</returns>
        public int GetNextCompanyID()
        {
            return dataRepository.GetNextCompanyID();
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void AddNewRecordToGuestTable(params object[] guestParameters)
        {
            int id = int.Parse(guestParameters[0].ToString());
            string name = guestParameters[1].ToString();
            string documentNumber = guestParameters[2].ToString();
            string citizenship = guestParameters[3].ToString();
            string birthDate = guestParameters[4].ToString();
            string country = guestParameters[5].ToString();
            string zipCode = guestParameters[6].ToString();
            string city = guestParameters[7].ToString();
            string address = guestParameters[8].ToString();
            string phoneNumber = guestParameters[9].ToString();
            string email = guestParameters[10].ToString();

            Guest guest = new Guest(id, name, documentNumber, citizenship, birthDate, country, zipCode, city, address,
                phoneNumber, email);
            dataRepository.Create(guest);
        }

        /// <summary>
        /// Céges vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        /// <param name="companyParameters">Cég paraméterei</param>
        public void AddNewRecordToCompanyTable(params object[] companyParameters)
        {
            int id = int.Parse(companyParameters[0].ToString());
            string name = companyParameters[1].ToString();
            string vatNumber = companyParameters[2].ToString();
            string country = companyParameters[3].ToString();
            string zipCode = companyParameters[4].ToString();
            string city = companyParameters[5].ToString();
            string address = companyParameters[6].ToString();
            string phoneNumber = companyParameters[7].ToString();
            string email = companyParameters[8].ToString();

            Company company = new Company(id, name, vatNumber, country, zipCode, city, address, phoneNumber, email);
            dataRepository.Create(company);
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void UpdateRecordInGuestTable(params object[] guestParameters)
        {
            int id = int.Parse(guestParameters[0].ToString());
            string name = guestParameters[1].ToString();
            string documentNumber = guestParameters[2].ToString();
            string citizenship = guestParameters[3].ToString();
            string birthDate = guestParameters[4].ToString();
            string country = guestParameters[5].ToString();
            string zipCode = guestParameters[6].ToString();
            string city = guestParameters[7].ToString();
            string address = guestParameters[8].ToString();
            string phoneNumber = guestParameters[9].ToString();
            string email = guestParameters[10].ToString();

            Guest guest = new Guest(id, name, documentNumber, citizenship, birthDate, country, zipCode, city, address,
                phoneNumber, email);
            dataRepository.Update(guest);
        }

        /// <summary>
        /// Céges vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        /// <param name="companyParameters">Cég paraméterei</param>
        public void UpdateRecordInCompanyTable(params object[] companyParameters)
        {
            int id = int.Parse(companyParameters[0].ToString());
            string name = companyParameters[1].ToString();
            string vatNumber = companyParameters[2].ToString();
            string country = companyParameters[3].ToString();
            string zipCode = companyParameters[4].ToString();
            string city = companyParameters[5].ToString();
            string address = companyParameters[6].ToString();
            string phoneNumber = companyParameters[7].ToString();
            string email = companyParameters[8].ToString();

            Company company = new Company(id, name, vatNumber, country, zipCode, city, address, phoneNumber, email);
            dataRepository.Update(company);
        }

        /// <summary>
        /// Vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void DeleteRecordFromGuestTable(params object[] guestParameters)
        {
            int id = int.Parse(guestParameters[0].ToString());
            string name = guestParameters[1].ToString();
            string documentNumber = guestParameters[2].ToString();
            string citizenship = guestParameters[3].ToString();
            string birthDate = guestParameters[4].ToString();
            string country = guestParameters[5].ToString();
            string zipCode = guestParameters[6].ToString();
            string city = guestParameters[7].ToString();
            string address = guestParameters[8].ToString();
            string phoneNumber = guestParameters[9].ToString();
            string email = guestParameters[10].ToString();

            Guest guest = new Guest(id, name, documentNumber, citizenship, birthDate, country, zipCode, city, address,
                phoneNumber, email);
            dataRepository.Delete(guest);
        }

        /// <summary>
        /// Céges vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        /// <param name="companyParameters">Cég paraméterei</param>
        public void DeleteRecordFromCompanyTable(params object[] companyParameters)
        {
            int id = int.Parse(companyParameters[0].ToString());
            string name = companyParameters[1].ToString();
            string vatNumber = companyParameters[2].ToString();
            string country = companyParameters[3].ToString();
            string zipCode = companyParameters[4].ToString();
            string city = companyParameters[5].ToString();
            string address = companyParameters[6].ToString();
            string phoneNumber = companyParameters[7].ToString();
            string email = companyParameters[8].ToString();

            Company corporateGuest =
                new Company(id, name, vatNumber, country, zipCode, city, address, phoneNumber, email);
            dataRepository.Delete(corporateGuest);
        }

        #endregion
    }
}
