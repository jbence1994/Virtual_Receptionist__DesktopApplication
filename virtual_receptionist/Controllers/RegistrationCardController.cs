using System.Data;
using virtual_receptionist.Models;
using virtual_receptionist.Models.Data;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Vendég bejelentkező lap vezérlője
    /// </summary>
    public class RegistrationCardController
    {
        #region Adattagok

        /// <summary>
        /// Vendég adattár osztály egy példánya
        /// </summary>
        private GuestRepository repository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég bejelentkező lap vezérlő konstruktora
        /// </summary>
        public RegistrationCardController()
        {
            repository = new GuestRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely elmenti a vendég, cég és foglalás adatait adatbázisba
        /// </summary>
        public void SaveData(bool isCompany, params object[] dataParameters)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetGuestData() //Szétbontás elemi adattípusra az objektum mezőit
        {
            repository.GetSpecifiedGuestData();
            return new DataTable();
        }

        #endregion
    }
}
