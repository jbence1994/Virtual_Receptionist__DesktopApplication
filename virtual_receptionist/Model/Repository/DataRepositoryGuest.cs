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
        /// <param name="company">Company objektum</param>
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
        /// <param name="company">Company objektum</param>
        public void Update(Company company)
        {
            string sql =
                $"UPDATE company SET company.CompanyName=\"{company.Name}\", company.VATNumber=\"{company.VatNumber}\", company.Country=(SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{company.Country}\"), company.ZipCode=\"{company.ZipCode}\", company.City=\"{company.City}\", company.Address=\"{company.Address}\", company.PhoneNumber=\"{company.PhoneNumber}\", company.EmailAddress=\"{company.EmailAddress}\" WHERE company.ID LIKE \"{company.ID}\"";
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
        /// <param name="company">Company objektum</param>
        public void Create(Company company)
        {
            string sql =
                $"INSERT INTO company(CompanyName, VATNumber, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{company.Name}\", \"{company.VatNumber}\", (SELECT Country.ID FROM Country WHERE Country.CountryName LIKE \"{company.Country}\"), \"{company.ZipCode}\", \"{company.City}\", \"{company.Address}\", \"{company.PhoneNumber}\", \"{company.EmailAddress}\")";
            database.DML(sql);
        }

        /// <summary>
        /// Metódus, amely visszaadja a soron következő vendégazonosítót adatbázisból
        /// </summary>
        /// <returns>Az adatbázisban soron következő vendégazonosítót adja vissza a függvény</returns>
        public int GetNextGuestID()
        {
            string sql = "SELECT MAX(guest.ID) FROM guest";
            string maxID = database.ScalarDQL(sql);

            int.TryParse(maxID, out int nextID);

            return nextID + 1;
        }

        /// <summary>
        /// Metódus, amely visszaadja a soron következő cégazonosítót adatbázisból
        /// </summary>
        /// <returns>Az adatbázisban soron következő cégazonosítót adja vissza a függvény</returns>
        public int GetNextCompanyID()
        {
            string sql = "SELECT MAX(company.ID) FROM company";
            string maxID = database.ScalarDQL(sql);

            int.TryParse(maxID, out int nextID);

            return nextID + 1;
        }

        #endregion
    }
}
