using virtual_receptionist.Model.Entity;
using virtual_receptionist.Model.Interfaces;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository : IManipulable<PrivateGuest>, IManipulable<CorporateGuest>
    {
        #region Vendégadatbázis modul üzleti logika

        /// <summary>
        /// Vendég törlése
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void Delete(PrivateGuest privateGuest)
        {
            string sql = $"DELETE FROM guest WHERE guest.ID LIKE \"{privateGuest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Céges vendég törlése
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void Delete(CorporateGuest corporateGuest)
        {
            string sql = $"DELETE FROM guest WHERE guest.ID LIKE \"{corporateGuest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void Update(PrivateGuest privateGuest)
        {
            string sql =
                $"UPDATE guest SET guest.Name=\"{privateGuest.Name}\", guest.DocumentNumber=\"{privateGuest.DocumentNumber}\", guest.Citizenship=\"{privateGuest.Citizenship}\", guest.BirthDate=\"{privateGuest.BirthDate}\", guest.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{privateGuest.Country}\"), guest.ZipCode=\"{privateGuest.ZipCode}\", guest.City=\"{privateGuest.City}\", guest.Address=\"{privateGuest.Address}\", guest.PhoneNumber=\"{privateGuest.PhoneNumber}\", guest.EmailAddress=\"{privateGuest.EmailAddress}\" WHERE guest.ID LIKE \"{privateGuest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void Update(CorporateGuest corporateGuest)
        {
            string sql =
                $"UPDATE guest SET guest.Name=\"{corporateGuest.Name}\", guest.VATNumber=\"{corporateGuest.VatNumber}\", guest.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{corporateGuest.Country}\"), guest.ZipCode=\"{corporateGuest.ZipCode}\", guest.City=\"{corporateGuest.City}\", guest.Address=\"{corporateGuest.Address}\", guest.PhoneNumber=\"{corporateGuest.PhoneNumber}\", guest.EmailAddress=\"{corporateGuest.EmailAddress}\" WHERE guest.ID LIKE \"{corporateGuest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég létrehozása
        /// </summary>
        /// <param name="privateGuest">PrivateGuest objektum</param>
        public void Create(PrivateGuest privateGuest)
        {
            string sql =
                $"INSERT INTO guest(Name, DocumentNumber, Citizenship, BirthDate, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{privateGuest.Name}\", \"{privateGuest.DocumentNumber}\", \"{privateGuest.Citizenship}\", \"{privateGuest.BirthDate}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{privateGuest.Country}\"), \"{privateGuest.ZipCode}\", \"{privateGuest.City}\", \"{privateGuest.Address}\", \"{privateGuest.PhoneNumber}\", \"{privateGuest.EmailAddress}\")";
            database.DML(sql);
        }

        /// <summary>
        /// Vendég módosítása
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void Create(CorporateGuest corporateGuest)
        {
            string sql =
                $"INSERT INTO guest(Name, VATNumber, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{corporateGuest.Name}\", \"{corporateGuest.VatNumber}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{corporateGuest.Country}\"), \"{corporateGuest.ZipCode}\", \"{corporateGuest.City}\", \"{corporateGuest.Address}\", \"{corporateGuest.PhoneNumber}\", \"{corporateGuest.EmailAddress}\")";
            database.DML(sql);
        }

        #endregion
    }
}
