using System.Data;
using System.Linq;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository
    {
        #region Számlázó modul üzleti logika

        /// <summary>
        /// Metódus, amely tétel kedvezményt számít
        /// </summary>
        /// <param name="itemPrice">Tétel értéke, amelyből kedvezményt számol a függvény</param>
        ///<param name="footPercent">Százalékláb értéke</param>
        /// <returns>A kiszámolt kedvezmény értékével tér vissza a függvény</returns>
        public double CountDiscountPrice(double itemPrice, double footPercent)
        {
            double difference = (itemPrice * footPercent) / 100;
            return itemPrice - difference;
        }

        /// <summary>
        /// Metódus, amely kiszámolja a fizetendő végösszeget
        /// </summary>
        /// <param name="prices">Bementi paraméter tétel árak</param>
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double CountTotalPrice(params double[] prices)
        {
            return prices.Sum();
        }

        /// <summary>
        /// Metódus, amely feltölti a számlázási tételeket tartalmazó adattáblát a listában tárolt adatokkal
        /// </summary>
        /// <returns>A számlázási tételeket tartalmazó listából feltöltött adattáblával tér vissza a függvény</returns>
        public DataTable GetBillingItems()
        {
            DataTable billingItemsDataTable = new DataTable();
            billingItemsDataTable.Columns.Add("Name", typeof(string));
            billingItemsDataTable.Columns.Add("Price", typeof(double));
            billingItemsDataTable.Columns.Add("VAT", typeof(double));
            billingItemsDataTable.Columns.Add("CategoryName", typeof(string));
            billingItemsDataTable.Columns.Add("Unit", typeof(string));

            foreach (BillingItem item in billingItems)
            {
                billingItemsDataTable.Rows.Add(item.Name, item.Price, item.Category.VAT, item.Category.Name,
                    item.Category.Unit);
            }

            return billingItemsDataTable;
        }

        #endregion
    }
}
