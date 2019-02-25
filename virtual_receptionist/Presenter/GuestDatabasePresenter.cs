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
        /// Metódus, amely lekéri a céges vendégek adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A céges vendégek adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetCorporateGuests()
        {
            List<CorporateGuest> corporateGuests = dataRepository.CorporateGuests;

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
        /// Metódus, amely lekéri a vendégek adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A vendégek adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetPrivateGuests()
        {
            List<PrivateGuest> privateGuests = dataRepository.PrivateGuests;

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
                    privateGuest.Citizenship, privateGuest.BirthDate, privateGuest.Country, privateGuest.ZipCode,
                    privateGuest.City, privateGuest.Address, privateGuest.PhoneNumber, privateGuest.EmailAddress);
            }

            return privateGuestsDataTable;
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
        public void AddNewRecordToPrivateGuestTable(params object[] guestParameters)
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

            PrivateGuest privateGuest =
                new PrivateGuest(id, name, documentNumber, citizenship, birthDate, country, zipCode, city, address,
                    phoneNumber, email);

            dataRepository.Create(privateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Céges vendég paraméterei</param>
        public void AddNewRecordToCorporateGuestTable(params object[] guestParameters)
        {
            int id = int.Parse(guestParameters[0].ToString());
            string name = guestParameters[1].ToString();
            string country = guestParameters[2].ToString();
            string vatNumber = guestParameters[3].ToString();
            string zipCode = guestParameters[4].ToString();
            string city = guestParameters[5].ToString();
            string address = guestParameters[6].ToString();
            string phoneNumber = guestParameters[7].ToString();
            string email = guestParameters[8].ToString();

            CorporateGuest corporateGuest =
                new CorporateGuest(id, name, vatNumber, country, zipCode, city, address, phoneNumber, email);

            dataRepository.Create(corporateGuest);
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void UpdateRecordInPrivateGuestTable(params object[] guestParameters)
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

            PrivateGuest privateGuest = new PrivateGuest(id, name, documentNumber, citizenship, birthDate, country,
                zipCode,
                city, address, phoneNumber, email);

            dataRepository.Update(privateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Céges vendég paraméterei</param>
        public void UpdateRecordInCorporateGuestTable(params object[] guestParameters)
        {
            int id = int.Parse(guestParameters[0].ToString());
            string name = guestParameters[1].ToString();
            string country = guestParameters[2].ToString();
            string vatNumber = guestParameters[3].ToString();
            string zipCode = guestParameters[4].ToString();
            string city = guestParameters[5].ToString();
            string address = guestParameters[6].ToString();
            string phoneNumber = guestParameters[7].ToString();
            string email = guestParameters[8].ToString();

            CorporateGuest corporateGuest =
                new CorporateGuest(id, name,
                    vatNumber, country, zipCode, city, address, phoneNumber, email);

            dataRepository.Update(corporateGuest);
        }

        /// <summary>
        /// Vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void DeleteRecordFromPrivateGuestTable(params object[] guestParameters)
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

            PrivateGuest privateGuest = new PrivateGuest(id, name, documentNumber, citizenship, birthDate,
                country,
                zipCode, city, address, phoneNumber, email);

            dataRepository.Delete(privateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Céges vendég paraméterei</param>
        public void DeleteRecordFromCorporateGuestTable(params object[] guestParameters)
        {
            int id = int.Parse(guestParameters[0].ToString());
            string name = guestParameters[1].ToString();
            string country = guestParameters[2].ToString();
            string vatNumber = guestParameters[3].ToString();
            string zipCode = guestParameters[4].ToString();
            string city = guestParameters[5].ToString();
            string address = guestParameters[6].ToString();
            string phoneNumber = guestParameters[7].ToString();
            string email = guestParameters[8].ToString();

            CorporateGuest corporateGuest = new CorporateGuest(id, name, vatNumber, country, zipCode, city,
                address,
                phoneNumber, email);

            dataRepository.Delete(corporateGuest);
        }

        #endregion
    }
}
