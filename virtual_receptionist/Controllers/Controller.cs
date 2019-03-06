using System.Collections.Generic;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.ORM;

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

        #endregion
    }
}
