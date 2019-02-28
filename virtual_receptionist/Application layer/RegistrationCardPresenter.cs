using System.Data;
using virtual_receptionist.BusinessLogicLayer;

namespace virtual_receptionist.ApplicationLayer
{
    /// <summary>
    /// Vendég bejelentkező lap vezérlője
    /// </summary>
    public class RegistrationCardPresenter : DefaultController
    {
        private GuestBLL guestLogic;

        public RegistrationCardPresenter()
        {
            guestLogic = new GuestBLL();
        }

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
        public DataTable GetCompanyData() //Szétbontás elemi adattípusra az objektum mezőit
        {
            guestLogic.GetSpecifiedCompanyData();
            return new DataTable();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetGuestData() //Szétbontás elemi adattípusra az objektum mezőit
        {
            guestLogic.GetSpecifiedGuestData();
            return new DataTable();
        }

        #endregion
    }
}
