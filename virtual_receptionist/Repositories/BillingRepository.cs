using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
{
    public class BillingRepository : Repository
    {
        private readonly List<BillingItem> billingItems;

        public BillingRepository()
        {
            billingItems = new List<BillingItem>();
        }

        private void UploadBillingItemsList()
        {
            const string sql =
                "SELECT billing_item.BillingItemName, billing_item.Price, billing_item_category.VAT, billing_item_category.BillingItemCategoryName, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID";

            var dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                var name = row["BillingItemName"].ToString();
                var categoryName = row["BillingItemCategoryName"].ToString();
                var vat = double.Parse(row["VAT"].ToString());
                var unit = row["Unit"].ToString();
                var price = double.Parse(row["Price"].ToString());

                var billingItemCategory = new BillingItemCategory
                {
                    Name = categoryName,
                    Vat = vat,
                    Unit = unit
                };

                var billingItem = new BillingItem
                {
                    Name = name,
                    Category = billingItemCategory,
                    Price = price
                };

                billingItems.Add(billingItem);
            }
        }

        public List<BillingItem> GetBillingItems()
        {
            if (billingItems.Count == 0)
                UploadBillingItemsList();

            return billingItems;
        }

        public double CountDiscountPrice(double itemPrice, double footPercent)
        {
            return itemPrice - itemPrice * footPercent / 100;
        }

        public double CountTotalPrice(double price, int quantity)
        {
            return price * quantity;
        }

        public void SetBookingAsPaid(Booking booking)
        {
            var sql = $"UPDATE booking SET booking.Paid = 1 WHERE booking.ID = \"{booking.Id}\"";
            database.DML(sql);
        }
    }
}
