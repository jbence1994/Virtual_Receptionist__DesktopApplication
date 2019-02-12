using System.Data;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó ablak és számlázási tételek modális ablak prezentere
    /// </summary>
    public class BillingPresenter : DefaultPresenter
    {
        #region Számlázó modul nézetfrissítései

        /// <summary>
        /// Metódus, amely visszaadja a számlázási tételeket az adattárból
        /// </summary>
        /// <returns>A számlázási tételekkel feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable InitializeBillingItemsTable()
        {
            DataTable billingItems = dataRepository.GetBillingItems();
            return billingItems;
        }

        public DataTable AddNewRow(params object[] items)
        {return new DataTable();
        }

        public DataTable DeleteRow(int index)
        {return new DataTable();
        }

        public DataTable UpdateRow(int index, params object[] items)
        {return new DataTable();
        }

        private DataTable InitializeBillingDataTable()
        {
            DataTable billingDataTable = new DataTable();

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
