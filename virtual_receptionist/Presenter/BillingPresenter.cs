using System;
using virtual_receptionist.View;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó modul prezentere
    /// </summary>
    public class BillingPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak egy példánya
        /// </summary>
        private FormModalBillingItems formModalBillingItems;

        #endregion

        #region Konstruktor

        #endregion

        #region Számlázó modul nézetfrissítései

        /// <summary>
        /// Számlázási tételek táblázatba új rekordot beszúró metódus
        /// </summary>
        public void AddNewRow()
        {
            formModalBillingItems = new FormModalBillingItems();
            formModalBillingItems.ShowDialog();
        }

        /// <summary>
        /// Számlázási tételek táblázatból meglévő rekordot törlő metódus
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void DeleteRow()
        {
            throw new Exception("");
        }

        /// <summary>
        /// Számlázási tételek táblázatból meglévő rekordot módosító metódus
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void UpdateRow()
        {
            throw new Exception("");
        }

        /// <summary>
        /// Metódus, amely visszaadja a fizetendő végösszeget
        /// </summary>
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double GetTotalPrice()
        {
            double total = dataRepository.CountTotalPrice();
            return total;
        }

        #endregion
    }
}
