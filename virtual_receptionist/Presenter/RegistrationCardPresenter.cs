using System.Collections.Generic;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Vendég bejelentkező lap prezentere
    /// </summary>
    public class RegistrationCardPresenter : DefaultPresenter
    {
        #region Vendég bejelentkező lap nézetfrissítései

        /// <summary>
        /// Metódus, amely elmenti a szobakiadást adatbázisba
        /// </summary>
        public void Save()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int> GetRoomNumbers()
        {
            return new List<int>();
        }

        #endregion
    }
}
