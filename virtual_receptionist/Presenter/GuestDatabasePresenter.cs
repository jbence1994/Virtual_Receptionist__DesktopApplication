using System.Collections.Generic;
using System.Data;
using System.Reflection;
using virtual_receptionist.Model;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Vendégadatbázis-kezelő prezentere
    /// </summary>
    public class GuestDatabasePresenter : DefaultPresenter
    {
        #region Adattagok


        #endregion

        #region Konstruktor


        #endregion

        #region Vendégadatbázis-kezelő nézetfrissítései

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable InitializePrivateGuests()
        {
            DataTable privateGuestDataTable = dataRepository.GetPrivateGuests();
            return privateGuestDataTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable InitializeCorporateGuests()
        {
            DataTable corporateGuestDataTable = dataRepository.GetCorporateGuests();
            return corporateGuestDataTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Country> GetCountries()
        {
            List<Country> countries = dataRepository.GetCountries();
            return countries;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetNextID()
        {
            int nextID = 1;

            if (dataRepository.GetMaxGuestID() != "")
            {
                nextID = int.Parse(dataRepository.GetMaxGuestID()) + 1;
            }

            return nextID;
        }

        /// <summary>
        /// Vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToPrivateGuestTable(int id, string name, string documentNumber, string citizenship,
            string birthDate, string country, string zipCode, string city, string address, string
                phoneNumber, string email)
        {
            PrivateGuest privateGuest = new PrivateGuest(id, name, documentNumber, citizenship, birthDate, country,
                zipCode,
                city, address, phoneNumber, email);

            dataRepository.CreateGuest(privateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatba és adatbázisba új rekord félvetélére szolgáló metódus
        /// </summary>
        public void AddNewRecordToCorporateGuestTable(int id, string name, string vatNumber, string country,
            string zipCode, string city, string address, string phoneNumber, string email)
        {
            CorporateGuest corporateGuest =
                new CorporateGuest(id, name, vatNumber, country, zipCode, city, address, phoneNumber, email);
            dataRepository.CreateGuest(corporateGuest);
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInPrivateGuestTable(int id, string name, string documentNumber, string citizenship,
            string birthDate, string country,
            string zipCode,
            string city, string address, string phoneNumber, string email)
        {
            PrivateGuest privateGuest = new PrivateGuest(id, name, documentNumber, citizenship, birthDate, country,
                zipCode,
                city, address, phoneNumber, email);
            dataRepository.UpdateGuest(privateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        public void UpdateRecordInCorporateGuestTable(int id, string name, string vatNumber, string country,
            string zipCode, string city, string address, string phoneNumber, string email)
        {
            CorporateGuest corporateGuest =
                new CorporateGuest(id, name,
                    vatNumber, country, zipCode, city, address, phoneNumber, email);
            dataRepository.UpdateGuest(corporateGuest);
        }

        /// <summary>
        /// Vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordFromPrivateGuestTable(int id, string name, string documentNumber, string citizenship,
            string birthDate, string country, string zipCode, string city,
            string address, string phoneNumber, string email)
        {
            PrivateGuest privateGuest = new PrivateGuest(id, name, documentNumber, citizenship, birthDate,
                country,
                zipCode, city, address, phoneNumber, email);
            dataRepository.DeleteGuest(privateGuest);
        }

        /// <summary>
        /// Céges vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        public void DeleteRecordFromCorporateGuestTable(int id, string name, string vatNumber, string country,
            string zipCode, string city, string
                address, string
                phoneNumber, string email)
        {
            CorporateGuest corporateGuest = new CorporateGuest(id, name, vatNumber, country, zipCode, city,
                address,
                phoneNumber, email);
            dataRepository.DeleteGuest(corporateGuest);
        }

        /// <summary>
        /// Ha megváltozik a vendégtáblázat, a megfelelő táblázat cellák adatai kerüljenek a megfelelő szövegmezőkbe
        /// </summary>
        public void ListViewPrivateGuestsSelectedIndexChanged()
        {

        }

        /// <summary>
        /// Ha megváltozik a céges vendégtáblázat, a megfelelő táblázat cellák adatai kerüljenek a megfelelő szövegmezőkbe
        /// </summary>
        public void ListViewCorporateGuestsSelectedIndexChanged()
        {

        }

        #endregion
    }
}
