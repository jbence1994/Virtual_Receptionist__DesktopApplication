using System.Data;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó modul tételek felvételéhez szükséges modális ablak prezentere
    /// </summary>
    public class ModalBillingItemsPresenter : DefaultPresenter
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        #endregion

        #region Számlázási tételek modális ablak nézetfrissítései

        /// <summary>
        /// Számlázi tételek táblázatot adatbázisból adatokkal feltöltő metódus
        /// </summary>
        /// <returns>Feltöltött adattáblával tér vissza a függvény</returns>
        public DataTable InitializeBillingItemsTable()
        {
            DataTable billingItems = dataRepository.GetBillingItems();
            return billingItems;
        }

        #endregion
    }
}
