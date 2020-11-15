using System.Collections.Generic;
using virtual_receptionist.Repositories;
using virtual_receptionist.Models;

namespace virtual_receptionist.Controllers
{
    public class Controller
    {
        private readonly CountryRepository countryRepository = new CountryRepository();
        private readonly BookingRepository bookingRepository = new BookingRepository();

        /// <summary>
        /// Metódus, amely visszaadja az országok neveit adattárból
        /// </summary>
        /// <returns>Az országnevekkel feltöltött listával tér vissza a metódus</returns>
        public List<string> GetCountries()
        {
            List<Country> countries = countryRepository.GetCountries();

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
            List<Room> rooms = bookingRepository.GetRooms();

            List<int> roomNumbers = new List<int>();

            foreach (Room room in rooms)
            {
                roomNumbers.Add(room.Number);
            }

            return roomNumbers;
        }
    }
}
