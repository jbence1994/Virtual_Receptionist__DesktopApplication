using virtual_receptionist.Model.Entity;
using virtual_receptionist.Model.Interfaces;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository : IManipulable<Guest>, IManipulable<Company>
    {
        #region Vendégadatbázis modul üzleti logika

        /// <summary>
        /// Meglévő vendég törlése adatbázisból
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void Delete(Guest guest)
        {
            string sql = $"DELETE FROM guest WHERE guest.ID LIKE \"{guest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő céges vendég törlése adatbázisból
        /// </summary>
        /// <param name="compnay">Company objektum</param>
        public void Delete(Company company)
        {
            string sql = $"DELETE FROM company WHERE company.ID LIKE \"{company.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő vendég módosítása adatbázisban
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void Update(Guest guest)
        {
            string sql =
                $"UPDATE guest SET guest.Name=\"{guest.Name}\", guest.DocumentNumber=\"{guest.DocumentNumber}\", guest.Citizenship=\"{guest.Citizenship}\", guest.BirthDate=\"{guest.BirthDate}\", guest.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{guest.Country}\"), guest.ZipCode=\"{guest.ZipCode}\", guest.City=\"{guest.City}\", guest.Address=\"{guest.Address}\", guest.PhoneNumber=\"{guest.PhoneNumber}\", guest.EmailAddress=\"{guest.EmailAddress}\" WHERE guest.ID LIKE \"{guest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő vendég módosítása adatbázisban
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void Update(Company corporateGuest)
        {
            string sql =
                $"UPDATE company SET company.CompanyName=\"{corporateGuest.Name}\", company.VATNumber=\"{corporateGuest.VatNumber}\", company.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{corporateGuest.Country}\"), company.ZipCode=\"{corporateGuest.ZipCode}\", company.City=\"{corporateGuest.City}\", company.Address=\"{corporateGuest.Address}\", company.PhoneNumber=\"{corporateGuest.PhoneNumber}\", company.EmailAddress=\"{corporateGuest.EmailAddress}\" WHERE company.ID LIKE \"{corporateGuest.ID}\"";
            database.DML(sql);
        }

        /// <summary>
        /// Új vendég létrehozása adatbázisban
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public void Create(Guest guest)
        {
            string sql =
                $"INSERT INTO guest(Name, DocumentNumber, Citizenship, BirthDate, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{guest.Name}\", \"{guest.DocumentNumber}\", \"{guest.Citizenship}\", \"{guest.BirthDate}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{guest.Country}\"), \"{guest.ZipCode}\", \"{guest.City}\", \"{guest.Address}\", \"{guest.PhoneNumber}\", \"{guest.EmailAddress}\")";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő vendég módosítása adatbázisban
        /// </summary>
        /// <param name="corporateGuest">CorporateGuest objektum</param>
        public void Create(Company corporateGuest)
        {
            string sql =
                $"INSERT INTO company(CompanyName, VATNumber, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{corporateGuest.Name}\", \"{corporateGuest.VatNumber}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{corporateGuest.Country}\"), \"{corporateGuest.ZipCode}\", \"{corporateGuest.City}\", \"{corporateGuest.Address}\", \"{corporateGuest.PhoneNumber}\", \"{corporateGuest.EmailAddress}\")";
            database.DML(sql);
        }

        /// <summary>
        /// Metódus, amely visszaadja a soron következő vendégazonosítót adatbázisból
        /// </summary>
        /// <returns>Az adatbázisban soron következő vendégazonosítót adja vissza a függvény</returns>
        public int GetNextGuestID()
        {
            int nextID;

            string sql = "SELECT MAX(guest.ID) FROM guest";
            string maxID = database.DQLScalar(sql);

            int.TryParse(maxID, out nextID);

            return nextID + 1;
        }

        /// <summary>
        /// Metódus, amely visszaadja a soron következő cégazonosítót adatbázisból
        /// </summary>
        /// <returns>Az adatbázisban soron következő cégazonosítót adja vissza a függvény</returns>
        public int GetNextCompanyID()
        {
            int nextID;

            string sql = "SELECT MAX(company.ID) FROM company";
            string maxID = database.DQLScalar(sql);

            int.TryParse(maxID, out nextID);

            return nextID + 1;
        }

        #endregion
    }
}
