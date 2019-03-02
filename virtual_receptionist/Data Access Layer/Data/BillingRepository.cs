using virtual_receptionist.DataAccessLayer.Model;
using System.Collections.Generic;
using System.Data;

namespace virtual_receptionist.DataAccessLayer.PersistentDataRepository
{
    /// <summary>
    /// Számlázás adattár
    /// </summary>
    public class BillingRepository : Repository
    {
        #region Adattagok

        /// <summary>
        /// Számlázási tételeket tartalmazó lista
        /// </summary>
        private static List<BillingItem> billingItems;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázás adattár konstruktora
        /// </summary>
        public BillingRepository()
        {
            billingItems = new List<BillingItem>();
        }

        #endregion

        #region Getter tulajdonságok

        /// <summary>
        /// Számlázási tételeket tartalmazó lista
        /// </summary>
        public static List<BillingItem> BillingItems
        {
            get
            {
                if (billingItems.Count == 0)
                {
                    UploadBillingItemsList();
                }

                return billingItems;
            }
        }

        #endregion

        #region Adatfeltöltő és adatelérési metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a számlázási tételek adatait tartalmazó listát
        /// </summary>
        private static void UploadBillingItemsList()
        {
            string sql =
                "SELECT billing_item.BillingItemName, billing_item.Price, billing_item_category.VAT, billing_item_category.BillingItemCategoryName, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["BillingItemName"].ToString();
                string categoryName = row["BillingItemCategoryName"].ToString();
                double vat = double.Parse(row["VAT"].ToString());
                string unit = row["Unit"].ToString();
                double price = double.Parse(row["Price"].ToString());

                BillingItemCategory billingItemCategoryInstance = new BillingItemCategory(categoryName, vat, unit);
                BillingItem billingItemInstance = new BillingItem(name, billingItemCategoryInstance, price);
                billingItems.Add(billingItemInstance);
            }
        }

        #endregion
    }
}
