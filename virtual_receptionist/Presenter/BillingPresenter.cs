using System;
using System.Data;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó ablak és számlázási tételek modális ablak prezentere
    /// </summary>
    public class BillingPresenter : DefaultPresenter
    {
        #region Számlázó modul nézetfrissítései

        private DataTable table;
        private static string item;
        private static double price;
        private static string unit;
        private static int quantity;

        public BillingPresenter()
        {
            table = new DataTable();
            table.Columns.Add("Tétel", typeof(string));
            table.Columns.Add("Ár", typeof(double));
            table.Columns.Add("Egység", typeof(string));
            table.Columns.Add("Mennyiség", typeof(int));
        }

        public DataTable AddNewRow()
        {
            table.Rows.Add(item, price, unit, quantity);
            return table;
        }

        public DataTable DeleteRow(int index)
        {
            table.Rows.RemoveAt(index);
            return table;
        }

        public DataTable UpdateRow(int index, params object[] items)
        {
            table.Rows.RemoveAt(index);
            table.Rows.Add(item, price, unit, quantity);
            return table;
        }

        /// <summary>
        /// Metódus, amely visszaadja a számlázási tételeket az adattárból
        /// </summary>
        /// <returns>A számlázási tételekkel feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable InitializeBillingItemsTable()
        {
            DataTable billingItems = dataRepository.GetBillingItems();
            return billingItems;
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

        public void AddItemToTable(params object[] itemParamteres)
        {
            item = itemParamteres[0].ToString();
            price = double.Parse(itemParamteres[1].ToString());
            unit = itemParamteres[2].ToString();
            quantity = int.Parse(itemParamteres[3].ToString());
        }
    }
}
