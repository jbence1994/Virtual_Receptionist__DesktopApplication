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
        /// Országokat lista adatszerkezetben visszaadó metódus
        /// </summary>
        /// <returns>Országlistával tér vissza a függvény</returns>
        public List<Country> GetCountries()
        {
            List<Country> countries = dataRepository.GetCountries();
            return countries;
        }

        /// <summary>
        /// Vendég adatbázis tábla soron következő azonosítóját visszaadó metódus
        /// </summary>
        /// <returns>Soron következő vendégazonosítóval tér vissza a függvény</returns>
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
        /// <param name="guestParameters">Vendég pataméterei</param>
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

            dataRepository.CreateGuest(privateGuest);
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

            dataRepository.CreateGuest(corporateGuest);
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

            dataRepository.UpdateGuest(privateGuest);
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

            dataRepository.UpdateGuest(corporateGuest);
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

            dataRepository.DeleteGuest(privateGuest);
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
