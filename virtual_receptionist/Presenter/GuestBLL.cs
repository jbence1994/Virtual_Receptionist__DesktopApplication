using virtual_receptionist.DataAccessLayer.Model;
using System.Collections.Generic;
using System.Data;
using virtual_receptionist.DataAccessLayer.Data;

namespace virtual_receptionist.BusinessLogicLayer
{
    /// <summary>
    /// Vendégadatbázis-kezelő üzleti logika osztály
    /// </summary>
    public class GuestBLL
    {
        #region Adattagok

        /// <summary>
        /// Vendég adattár egy példánya
        /// </summary>
        private GuestRepository repository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő üzleti logika osztály konstruktora
        /// </summary>
        public GuestBLL()
        {
            repository = new GuestRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// 
        /// </summary>
        public void GetSpecifiedGuestData()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void GetSpecifiedCompanyData()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Company> GetCompanies()
        {
            return repository.Companies;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Guest> GetGuests()
        {
            return repository.Guests;
        }

        /// <summary>
        /// Adattárból országok neveit listában tárolva visszaadó metódusat
        /// </summary>
        /// <returns>Országlistával tér vissza a függvény</returns>
        public List<Country> GetCountries()
        {
            return repository.Countries;
        }

        #endregion
    }
}
