using System.Data;
using virtual_receptionist.Models.Data;

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
