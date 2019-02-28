using System.Data;

namespace virtual_receptionist.ApplicationLayer
{
    /// <summary>
    /// Vendég bejelentkező lap vezérlője
    /// </summary>
    public class RegistrationCardPresenter : DefaultController
    {
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
        public DataTable GetCompanyData() //Szétbontás elemi aattípusra az objektum mezőit
        {
            repository.GetSpecifiedCompanyData();
            return new DataTable();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetGuestData() //Szétbontás elemi aattípusra az objektum mezőit
        {
            repository.GetSpecifiedGuestData();
            return new DataTable();
        }

        #endregion
    }
}
