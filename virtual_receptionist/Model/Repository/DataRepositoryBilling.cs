using System.Data;
using System.Linq;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository
    {
        #region Számlázó modul

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a számlázási tételeket tartalmazó listát
        /// </summary>
        private void UploadBillingItemsList()
        {
            string sql =
                "SELECT billing_item.BillingItemName, billing_item.Price, billing_item_category.VAT, billing_item_category.BillingItemCategoryName, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["BillingItemName"].ToString();
                string category = row["BillingItemCategoryName"].ToString();
                double vat = double.Parse(row["VAT"].ToString());
                string unit = row["Unit"].ToString();
                double price = double.Parse(row["Price"].ToString());

                BillingItem billingItemInstance = new BillingItem(name, category, vat, unit, price);
                billingItems.Add(billingItemInstance);
            }
        }

        /// <summary>
        /// Metódus, amely feltölti a számlázási tételeket tartalmazó adattáblát a listában tárolt adatokkal
        /// </summary>
        /// <returns>A számlázási tételeket tartalmazó listából feltöltött adattáblával tér vissza a függvény</returns>
        public DataTable GetBillingItems()
        {
            if (billingItems.Count == 0)
            {
                UploadBillingItemsList();
            }

            DataTable billingItemsDataTable = new DataTable();
            billingItemsDataTable.Columns.Add("Name", typeof(string));
            billingItemsDataTable.Columns.Add("Price", typeof(double));
            billingItemsDataTable.Columns.Add("VAT", typeof(double));
            billingItemsDataTable.Columns.Add("Category", typeof(string));
            billingItemsDataTable.Columns.Add("Unit", typeof(string));

            foreach (BillingItem item in billingItems)
            {
                billingItemsDataTable.Rows.Add(item.Name, item.Price, item.Vat, item.Category, item.Unit);
            }

            return billingItemsDataTable;
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a számlázási adatokat tartalmazó listát
        /// </summary>
        private void UploadBillingDataList()
        {
        }

        /// <summary>
        /// Metódus, amely feltölti a számlázási adatokat tartalmazó adattáblát a listában tárolt adatokkal
        /// </summary>
        /// <returns>A számlázási adatokat tartalmazó listából feltöltött adattáblával tér vissza a függvény</returns>
        public DataTable GetBillingData()
        {
            return null;
        }

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

        #endregion
    }
}
