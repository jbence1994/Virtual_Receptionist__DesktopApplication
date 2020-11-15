using System.Collections.Generic;
using System.Linq;
using virtual_receptionist.Repositories;

namespace virtual_receptionist.Controllers
{
    public class Controller
    {
        private readonly CountryRepository countryRepository = new CountryRepository();
        private readonly BookingRepository bookingRepository = new BookingRepository();

        public List<string> GetCountries()
        {
            return countryRepository.GetCountries().Select(country => country.Name).ToList();
        }

        public List<int> GetRooms()
        {
            return bookingRepository.GetRooms().Select(room => room.Number).ToList();
        }
    }
}
