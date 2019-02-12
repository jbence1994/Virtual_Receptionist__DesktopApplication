using System.Data;
using virtual_receptionist.View;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó modul prezentere
    /// </summary>
    public class BillingPresenter : DefaultPresenter
    {
        private DataTable billingDataTable;

        public BillingPresenter()
        {
            billingDataTable = new DataTable();
        }

        #region Számlázó modul nézetfrissítései

        public DataTable AddNewRow(params object[] items) // <= modális ablak prezenterétől kapja
        {
            DataTable addToDataTable = InitializeBillingDataTable();
            addToDataTable.Rows.Add(items);

            return addToDataTable;
        }

        public DataTable DeleteRow(int index)
        {
            DataTable deleteFromDataTable = InitializeBillingDataTable();
            deleteFromDataTable.Rows.RemoveAt(index);

            return deleteFromDataTable;
        }

        public DataTable UpdateRow(int index, params object[] items)
        {
            DataTable updateInDataTable = InitializeBillingDataTable();
            updateInDataTable.Rows.RemoveAt(index);
            updateInDataTable.Rows.Add(items);

            return updateInDataTable;
        }

        private DataTable InitializeBillingDataTable()
        {
            billingDataTable.Columns.Add("Tétel", typeof(string));
            billingDataTable.Columns.Add("Ár", typeof(double));
            billingDataTable.Columns.Add("Egység", typeof(string));
            billingDataTable.Columns.Add("Mennyiség", typeof(int));

            return billingDataTable;
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
