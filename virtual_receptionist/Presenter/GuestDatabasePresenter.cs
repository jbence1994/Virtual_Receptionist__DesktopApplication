using System;
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
        /// Metódus, amely visszaaadja a vendégeket az adattárból
        /// </summary>
        /// <returns>A vendégekkkel feltöltött adattbálát adja vissza a függvény</returns>
        public DataTable InitializePrivateGuests()
        {
            DataTable privateGuestDataTable = dataRepository.GetPrivateGuests();
            return privateGuestDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaaadja a céges vendégeket az adattárból
        /// </summary>
        /// <returns>A céges vendégekkkel feltöltött adattbálát adja vissza a függvény</returns>
        public DataTable InitializeCorporateGuests()
        {
            DataTable corporateGuestDataTable = dataRepository.GetCorporateGuests();
            return corporateGuestDataTable;
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
        /// Vendég adatbázis tábla soron következő azonosítóját visszaadó metódus
        /// </summary>
        /// <returns>Soron következő vendégazonosítóval tér vissza a függvény</returns>
        public int GetNextID()
        {
            return dataRepository.GetNextGuestID();
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

        #endregion
    }
}
