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
            billingDataTable = InitializeBillingDataTable();
        }

        #region Számlázó modul nézetfrissítései

        public DataTable AddNewRow(params object[] items) // <= modális ablak prezenterétől kapja
        {
            billingDataTable.Rows.Add(items);
            return billingDataTable;
        }

        public DataTable DeleteRow(int index)
        {
            billingDataTable.Rows.RemoveAt(index);
            return billingDataTable;
        }

        public DataTable UpdateRow(int index, params object[] items)
        {
            billingDataTable.Rows.RemoveAt(index);
            billingDataTable.Rows.Add(items);
            return billingDataTable;
        }

        private DataTable InitializeBillingDataTable()
        {
            DataTable billingDataTable = new DataTable();

            billingDataTable.Columns.Add("Item", typeof(string));
            billingDataTable.Columns.Add("Price", typeof(double));
            billingDataTable.Columns.Add("Unit", typeof(string));
            billingDataTable.Columns.Add("Quantity", typeof(int));

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
