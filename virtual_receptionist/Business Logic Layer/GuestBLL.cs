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
        public DataTable GetCompanies()
        {
            List<Company> companies = repository.Companies;

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

        #endregion
    }
}
