using System.Data;
using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Controllers.Validation;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.ORM;

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

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő modul vezérlő konstruktora
        /// </summary>
        public GuestDatabaseController()
        {
            repository = new GuestRepository();
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

            foreach (Guest guest in repository.GetGuests())
            {
                guestDataTable.Rows.Add(guest.ID, guest.Name, guest.DocumentNumber,
                    guest.Citizenship, guest.BirthDate, guest.Country, guest.ZipCode,
                    guest.City, guest.Address, guest.PhoneNumber, guest.EmailAddress);
            }

            return guestDataTable;
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
        /// <exception cref="InvalidNameException"></exception>
        /// <exception cref="InvalidCitizenshipException"></exception>
        /// <exception cref="InvalidCitizenshipException"></exception>
        /// <exception cref="InvalidBirthDateException"></exception>
        /// <exception cref="InvalidZipCodeException"></exception>
        /// <exception cref="InvalidCityException"></exception>
        /// <exception cref="InvalidAddressException"></exception>
        /// <exception cref="InvalidPhoneNumberException"></exception>
        /// <exception cref="InvalidEmailAddressException"></exception>
        public void AddNewRecordToGuestTable(params object[] guestParameters)
        {
            int id = int.Parse(guestParameters[0].ToString());

            string name = guestParameters[1].ToString();

            try
            {
                NameValidation nameValidation = new NameValidation(name);
                nameValidation.ValidateName();
            }
            catch (InvalidNameException e)
            {
                throw e;
            }

            string documentNumber = guestParameters[2].ToString();

            try
            {
                DocumentNumberValidation documentNumberValidation = new DocumentNumberValidation(documentNumber);
                documentNumberValidation.ValidateDocumentNumber();
            }
            catch (InvalidDocumentNumberException e)
            {
                throw e;
            }

            string citizenship = guestParameters[3].ToString();

            try
            {
                CitizenshipValidation citizenshipValidation = new CitizenshipValidation(citizenship);
                citizenshipValidation.ValidateDocumentNumber();
            }
            catch (InvalidCitizenshipException e)
            {
                throw e;
            }

            string birthDate = guestParameters[4].ToString();

            try
            {
                BirthDateValidation birthDateValidation = new BirthDateValidation(birthDate);
                birthDateValidation.ValidateBirthDate();
            }
            catch (InvalidBirthDateException e)
            {
                throw e;
            }

            string country = guestParameters[5].ToString();
            
            string zipCode = guestParameters[6].ToString();

            try
            {
                ZipCodeValidation zipCodeValidation = new ZipCodeValidation(zipCode);
                zipCodeValidation.ValidateZipCode();
            }
            catch (InvalidZipCodeException e)
            {
                throw e;
            }

            string city = guestParameters[7].ToString();

            try
            {
                CityValidation cityValidation = new CityValidation(city);
                cityValidation.ValidateCity();
            }
            catch (InvalidCityException e)
            {
                throw e;
            }

            string address = guestParameters[8].ToString();

            try
            {
                AddressValidation addressValidation = new AddressValidation(address);
                addressValidation.ValidateAddress();
            }
            catch (InvalidAddressException e)
            {
                throw e;
            }

            string phoneNumber = guestParameters[9].ToString();

            try
            {
                PhoneNumberValidation phoneNumberValidation = new PhoneNumberValidation(phoneNumber);
                phoneNumberValidation.ValidatePhoneNumber();
            }
            catch (InvalidPhoneNumberException e)
            {
                throw e;
            }

            string email = guestParameters[10].ToString();

            try
            {
                EmailValidation emailValidation = new EmailValidation(email);
                emailValidation.ValidateEmail();
            }
            catch (InvalidEmailAddressException e)
            {
                throw e;
            }

            Guest guest = new Guest(id, name, documentNumber, citizenship, birthDate, country, zipCode, city, address,
                phoneNumber, email);
            repository.Create(guest);
        }

        /// <summary>
        /// Vendégtáblázatban és adatbázisban meglévő rekord módosítására szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        /// <exception cref="InvalidNameException"></exception>
        /// <exception cref="InvalidCitizenshipException"></exception>
        /// <exception cref="InvalidCitizenshipException"></exception>
        /// <exception cref="InvalidBirthDateException"></exception>
        /// <exception cref="InvalidZipCodeException"></exception>
        /// <exception cref="InvalidCityException"></exception>
        /// <exception cref="InvalidAddressException"></exception>
        /// <exception cref="InvalidPhoneNumberException"></exception>
        /// <exception cref="InvalidEmailAddressException"></exception>
        public void UpdateRecordInGuestTable(params object[] guestParameters)
        {
            int id = int.Parse(guestParameters[0].ToString());

            string name = guestParameters[1].ToString();

            try
            {
                NameValidation nameValidation = new NameValidation(name);
                nameValidation.ValidateName();
            }
            catch (InvalidNameException e)
            {
                throw e;
            }

            string documentNumber = guestParameters[2].ToString();

            try
            {
                DocumentNumberValidation documentNumberValidation = new DocumentNumberValidation(documentNumber);
                documentNumberValidation.ValidateDocumentNumber();
            }
            catch (InvalidDocumentNumberException e)
            {
                throw e;
            }

            string citizenship = guestParameters[3].ToString();

            try
            {
                CitizenshipValidation citizenshipValidation = new CitizenshipValidation(citizenship);
                citizenshipValidation.ValidateDocumentNumber();
            }
            catch (InvalidCitizenshipException e)
            {
                throw e;
            }

            string birthDate = guestParameters[4].ToString();

            try
            {
                BirthDateValidation birthDateValidation = new BirthDateValidation(birthDate);
                birthDateValidation.ValidateBirthDate();
            }
            catch (InvalidBirthDateException e)
            {
                throw e;
            }

            string country = guestParameters[5].ToString();

            string zipCode = guestParameters[6].ToString();

            try
            {
                ZipCodeValidation zipCodeValidation = new ZipCodeValidation(zipCode);
                zipCodeValidation.ValidateZipCode();
            }
            catch (InvalidZipCodeException e)
            {
                throw e;
            }

            string city = guestParameters[7].ToString();

            try
            {
                CityValidation cityValidation = new CityValidation(city);
                cityValidation.ValidateCity();
            }
            catch (InvalidCityException e)
            {
                throw e;
            }

            string address = guestParameters[8].ToString();

            try
            {
                AddressValidation addressValidation = new AddressValidation(address);
                addressValidation.ValidateAddress();
            }
            catch (InvalidAddressException e)
            {
                throw e;
            }

            string phoneNumber = guestParameters[9].ToString();

            try
            {
                PhoneNumberValidation phoneNumberValidation = new PhoneNumberValidation(phoneNumber);
                phoneNumberValidation.ValidatePhoneNumber();
            }
            catch (InvalidPhoneNumberException e)
            {
                throw e;
            }

            string email = guestParameters[10].ToString();

            try
            {
                EmailValidation emailValidation = new EmailValidation(email);
                emailValidation.ValidateEmail();
            }
            catch (InvalidEmailAddressException e)
            {
                throw e;
            }

            Guest guest = new Guest(id, name, documentNumber, citizenship, birthDate, country, zipCode, city, address,
                phoneNumber, email);
            repository.Update(guest);
        }

        /// <summary>
        /// Vendégtáblázatból és adatbázisból meglévő rekord törlésére szolgáló metódus
        /// </summary>
        /// <param name="guestParameters">Vendég paraméterei</param>
        public void DeleteRecordFromGuestTable(params object[] guestParameters)
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
