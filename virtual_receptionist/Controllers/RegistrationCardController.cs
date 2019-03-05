using System.Data;
using System;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.ORM;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Vendég bejelentkező lap vezérlője
    /// </summary>
    public class RegistrationCardController : Controller
    {
        #region Adattagok

        /// <summary>
        /// Vendég adattár osztály egy példánya
        /// </summary>
        private GuestRepository guestRepository;

        /// <summary>
        /// Foglalások adattár egy példánya
        /// </summary>
        private BookingRepository bookingRepository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég bejelentkező lap vezérlő konstruktora
        /// </summary>
        public RegistrationCardController()
        {
            guestRepository = new GuestRepository();
            bookingRepository = new BookingRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely elmenti a vendég, cég és foglalás adatait adatbázisba
        /// </summary>
        public void SaveData(params object[] dataParameters)
        {
            /*
             * VALIDÁLNI !!!
             */
            string name = dataParameters[0].ToString();
            string citizenship = dataParameters[1].ToString();
            string birthDate = dataParameters[2].ToString();
            string documentNumber = dataParameters[3].ToString();
            string country = dataParameters[4].ToString();
            string zipCode = dataParameters[5].ToString();
            string city = dataParameters[6].ToString();
            string address = dataParameters[7].ToString();

            string phone = dataParameters[8].ToString();
            string email = dataParameters[9].ToString();

            string room = dataParameters[10].ToString();
            int numberOfGuests = Convert.ToInt32(dataParameters[11]);
            DateTime arrival = DateTime.Parse(dataParameters[12].ToString());
            DateTime departure = DateTime.Parse(dataParameters[13].ToString());

            Guest guestInstance = new Guest(name, documentNumber, citizenship, birthDate, country, zipCode, city,
                address,
                phone, email);

            Room roomInstance = new Room()
            {
                Name = room
            };

            Booking bookingInstance = new Booking(guestInstance, roomInstance, numberOfGuests, arrival, departure);

            guestRepository.Create(guestInstance);
            bookingRepository.Create(bookingInstance);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetGuestData() //Szétbontás elemi adattípusra az objektum mezőit
        {
            guestRepository.GetSpecifiedGuestData();
            return new DataTable();
        }

        #endregion
    }
}
