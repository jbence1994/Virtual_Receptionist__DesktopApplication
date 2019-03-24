using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Repository;
using virtual_receptionist.Repository.Models;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Vendégadatbázis-kezelő modul vezérlője
    /// </summary>
    public class GuestDatabaseController : Controller
    {
        #region Adattagok

        /// <summary>
        /// Vednég adattár osztály egy példánya
        /// </summary>
        private GuestRepository repository;

        /// <summary>
        /// Vendégeket tároló lista
        /// </summary>
        private List<Guest> guests;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő modul vezérlő konstruktora
        /// </summary>
        public GuestDatabaseController()
        {
            repository = new GuestRepository();
            guests = repository.GetGuests();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely lekéri a vendégek adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A vendégek adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetGuests()
        {
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
        /// Metódus, amely visszaadja a vendégadatbázis regisztrált vendégek neveit 
        /// </summary>
        /// <returns>A nevekkel feltöltött listával tér vissza a metódus</returns>
        public List<string> GetGuestNames()
        {
            List<string> guestNames = new List<string>();

            foreach (Guest guest in guests)
            {
                guestNames.Add(guest.Name);
            }

            return guestNames;
        }

        /// <summary>
        /// Metódus, amely beállítja a vendégtáblázat alapján ComboBoxban a kijelölt rekord országát
        /// </summary>
        /// <param name="selectedCountryInTable">Táblázatban kijelölt ország</param>
        public string SetSelectedCountry(string selectedCountryInTable)
        {
            string selectedCountry = null;

            foreach (string country in GetCountries())
            {
                if (selectedCountryInTable.Contains(country))
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
        public string GetNextGuestID()
        {
            return repository.GetNextGuestID().ToString();
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void AddGuest(params object[] guestParameters)
        {
            string name = guestParameters[0].ToString();
            string documentNumber = guestParameters[1].ToString();
            string citizenship = guestParameters[2].ToString();
            string birthDate = guestParameters[3].ToString();
            string country = guestParameters[4].ToString();
            string zipCode = guestParameters[5].ToString();
            string city = guestParameters[6].ToString();
            string address = guestParameters[7].ToString();
            string phoneNumber = guestParameters[8].ToString();
            string email = guestParameters[9].ToString();

            Guest guest = new Guest(name, documentNumber, citizenship, birthDate, country, zipCode, city, address,
                phoneNumber, email);
            repository.Create(guest);
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void UpdateGuest(params object[] guestParameters)
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
            repository.Update(guest);
        }

        /// <summary>
        /// Vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void DeleteGuest(params object[] guestParameters)
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
            repository.Delete(guest);
        }

        #endregion
    }
}
