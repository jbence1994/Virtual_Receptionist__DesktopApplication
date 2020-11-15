using System.Collections.Generic;
using System.Data;
using System.Linq;
using virtual_receptionist.Models;
using virtual_receptionist.Repositories;

namespace virtual_receptionist.Controllers
{
    public class GuestDatabaseController : Controller
    {
        private readonly GuestRepository guestRepository = new GuestRepository();

        public DataTable GetGuests()
        {
            var guestDataTable = new DataTable();
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

            foreach (var guest in guestRepository.GetGuests())
            {
                guestDataTable.Rows.Add(guest.ID, guest.Name, guest.DocumentNumber,
                    guest.Citizenship, guest.BirthDate, guest.Country, guest.ZipCode,
                    guest.City, guest.Address, guest.PhoneNumber, guest.EmailAddress);
            }

            return guestDataTable;
        }

        public List<string> GetGuestNames()
        {
            return guestRepository.GetGuests().Select(guest => guest.Name).ToList();
        }

        /// <summary>
        /// Metódus, amely beállítja a vendégtáblázat alapján ComboBoxban a kijelölt rekord országát
        /// </summary>
        /// <param name="selectedCountryInTable">Táblázatban kijelölt ország</param>
        public string SetSelectedCountry(string selectedCountryInTable)
        {
            string selectedCountry = null;

            foreach (var country in GetCountries().Where(selectedCountryInTable.Contains))
                selectedCountry = country;

            return selectedCountry;
        }

        public string GetNextGuestId()
        {
            return guestRepository.GetNextGuestID().ToString();
        }

        public void AddGuest(params object[] guestParameters)
        {
            var name = guestParameters[0].ToString();
            var documentNumber = guestParameters[1].ToString();
            var citizenship = guestParameters[2].ToString();
            var birthDate = guestParameters[3].ToString();
            var country = guestParameters[4].ToString();
            var zipCode = guestParameters[5].ToString();
            var city = guestParameters[6].ToString();
            var address = guestParameters[7].ToString();
            var phoneNumber = guestParameters[8].ToString();
            var email = guestParameters[9].ToString();

            var guest = new Guest
            {
                Name = name,
                DocumentNumber = documentNumber,
                Citizenship = citizenship,
                BirthDate = birthDate,
                Country = country,
                ZipCode = zipCode,
                City = city,
                Address = address,
                PhoneNumber = phoneNumber,
                EmailAddress = email
            };

            guestRepository.AddGuest(guest);
        }

        public void UpdateGuest(params object[] guestParameters)
        {
            var id = int.Parse(guestParameters[0].ToString());
            var name = guestParameters[1].ToString();
            var documentNumber = guestParameters[2].ToString();
            var citizenship = guestParameters[3].ToString();
            var birthDate = guestParameters[4].ToString();
            var country = guestParameters[5].ToString();
            var zipCode = guestParameters[6].ToString();
            var city = guestParameters[7].ToString();
            var address = guestParameters[8].ToString();
            var phoneNumber = guestParameters[9].ToString();
            var email = guestParameters[10].ToString();

            var guest = new Guest
            {
                ID = id,
                Name = name,
                DocumentNumber = documentNumber,
                Citizenship = citizenship,
                BirthDate = birthDate,
                Country = country,
                ZipCode = zipCode,
                City = city,
                Address = address,
                PhoneNumber = phoneNumber,
                EmailAddress = email
            };

            guestRepository.UpdateGuest(guest);
        }

        public void DeleteGuest(params object[] guestParameters)
        {
            var id = int.Parse(guestParameters[0].ToString());
            var name = guestParameters[1].ToString();
            var documentNumber = guestParameters[2].ToString();
            var citizenship = guestParameters[3].ToString();
            var birthDate = guestParameters[4].ToString();
            var country = guestParameters[5].ToString();
            var zipCode = guestParameters[6].ToString();
            var city = guestParameters[7].ToString();
            var address = guestParameters[8].ToString();
            var phoneNumber = guestParameters[9].ToString();
            var email = guestParameters[10].ToString();

            var guest = new Guest
            {
                ID = id,
                Name = name,
                DocumentNumber = documentNumber,
                Citizenship = citizenship,
                BirthDate = birthDate,
                Country = country,
                ZipCode = zipCode,
                City = city,
                Address = address,
                PhoneNumber = phoneNumber,
                EmailAddress = email
            };

            guestRepository.DeleteGuest(guest);
        }
    }
}
