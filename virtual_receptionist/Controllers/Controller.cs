using System.Collections.Generic;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.ORM;
using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Controllers.Validation;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Az alkalmazás vezárlője, amely a bemenetek validálásért és megfelelő nézet megjelenítéséért felel
    /// </summary>
    public class Controller
    {
        #region Adattagok

        /// <summary>
        /// Ország adattár egy példánya
        /// </summary>
        private CountryRepository countryRepository;

        /// <summary>
        /// Foglalások adattár egy példánya
        /// </summary>
        private BookingRepository bookingRepository;

        /// <summary>
        /// Országokat tartalmazó lista
        /// </summary>
        private List<Country> countries;

        /// <summary>
        /// Szobákat tároló lista
        /// </summary>
        private List<Room> rooms;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vezárlő konstruktora
        /// </summary>
        public Controller()
        {
            countryRepository = new CountryRepository();
            bookingRepository = new BookingRepository();

            countries = countryRepository.GetCountries();
            rooms = bookingRepository.GetRooms();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely visszaadja az országok neveit adattárból
        /// </summary>
        /// <returns>Az országnevekkel feltöltött listával tér vissza a metódus</returns>
        public List<string> GetCountries()
        {
            List<string> countryNames = new List<string>();

            foreach (Country country in countries)
            {
                countryNames.Add(country.Name);
            }

            return countryNames;
        }

        /// <summary>
        /// Metódus, amely visszaadja a szobaszámokat adattárból
        /// </summary>
        /// <returns></returns>
        public List<int> GetRooms()
        {
            List<int> roomNumbers = new List<int>();

            foreach (Room room in rooms)
            {
                roomNumbers.Add(room.Number);
            }

            return roomNumbers;
        }

        /// <summary>
        /// Név validátor
        /// </summary>
        /// <param name="name">Név</param>
        /// <exception cref="InvalidNameException"></exception>
        public void NameValidator(string name)
        {
            try
            {
                NameValidation nameValidation = new NameValidation(name);
                nameValidation.ValidateName();
            }
            catch (InvalidNameException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Okmányazonosító validátor
        /// </summary>
        /// <param name="documentNumber"></param>
        /// <exception cref="InvalidDocumentNumberException"></exception>
        public void DocumentNumberValidator(string documentNumber)
        {
            try
            {
                DocumentNumberValidation documentNumberValidation = new DocumentNumberValidation(documentNumber);
                documentNumberValidation.ValidateDocumentNumber();
            }
            catch (InvalidDocumentNumberException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Állampolgárság validátor
        /// </summary>
        /// <param name="citizenship">Állampolgárság</param>
        /// <exception cref="InvalidCitizenshipException"></exception>
        public void CitizenshipValidator(string citizenship)
        {
            try
            {
                CitizenshipValidation citizenshipValidation = new CitizenshipValidation(citizenship);
                citizenshipValidation.ValidateCitizenship();
            }
            catch (InvalidCitizenshipException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Születési dátum validátor
        /// </summary>
        /// <param name="birthDate">Születési dátum</param>
        /// <exception cref="InvalidBirthDateException"></exception>
        public void BirthDateValidator(string birthDate)
        {
            try
            {
                BirthDateValidation birthDateValidation = new BirthDateValidation(birthDate);
                birthDateValidation.ValidateBirthDate();
            }
            catch (InvalidBirthDateException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Irányítószám vlaidátor
        /// </summary>
        /// <param name="zipCode">Irányítószám</param>
        /// <exception cref="InvalidZipCodeException"></exception>
        public void ZipCodeValidator(string zipCode)
        {
            try
            {
                ZipCodeValidation zipCodeValidation = new ZipCodeValidation(zipCode);
                zipCodeValidation.ValidateZipCode();
            }
            catch (InvalidZipCodeException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Település validátor
        /// </summary>
        /// <param name="city">Település</param>
        /// <exception cref="InvalidCityException"></exception>
        public void CityValidator(string city)
        {
            try
            {
                CityValidation cityValidation = new CityValidation(city);
                cityValidation.ValidateCity();
            }
            catch (InvalidCityException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Lakcím validátor
        /// </summary>
        /// <param name="address"></param>
        /// <exception cref="InvalidAddressException"></exception>
        public void AddressValidator(string address)
        {
            try
            {
                AddressValidation addressValidation = new AddressValidation(address);
                addressValidation.ValidateAddress();
            }
            catch (InvalidAddressException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Telefonszám validátor
        /// </summary>
        /// <param name="phoneNumber">Telefonszám</param>
        /// <exception cref="InvalidPhoneNumberException"></exception>
        public void PhoneNumberValidator(string phoneNumber)
        {
            try
            {
                PhoneNumberValidation phoneNumberValidation = new PhoneNumberValidation(phoneNumber);
                phoneNumberValidation.ValidatePhoneNumber();
            }
            catch (InvalidPhoneNumberException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// E-mail cím validátor
        /// </summary>
        /// <param name="email">E-mail cím</param>
        /// <exception cref="InvalidEmailAddressException"></exception>
        public void EmailAddressValidator(string email)
        {
            try
            {
                EmailValidation emailValidation = new EmailValidation(email);
                emailValidation.ValidateEmail();
            }
            catch (InvalidEmailAddressException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Adószám validátor
        /// </summary>
        /// <param name="vatNumber">Adószám</param>
        ///<exception cref="InvalidVATNumberException"></exception>
        public void VATNumberValidator(string vatNumber)
        {
            try
            {
                VATNumberValidation vatNumberValidation = new VATNumberValidation(vatNumber);
                vatNumberValidation.ValidateVATNumber();
            }
            catch (InvalidVATNumberException exception)
            {
                throw exception;
            }
        }

        #endregion
    }
}
