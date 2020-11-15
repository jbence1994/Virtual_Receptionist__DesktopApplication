﻿using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
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
        private List<BillingItem> billingItems;

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

        #region Adatfeltöltő metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a számlázási tételek adatait tartalmazó listát
        /// </summary>
        private void UploadBillingItemsList()
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

        #region Adatelérési metódusok

        /// <summary>
        /// Metódus, amely feltölti a számlázási tételeket tartalmazó listát adatbázisból
        /// </summary>
        /// <returns>Az adatokkal feltöltött listával tér vissza a metódus</returns>
        public List<BillingItem> GetBillingItems()
        {
            if (billingItems.Count == 0)
            {
                UploadBillingItemsList();
            }

            return billingItems;
        }

        #endregion

        #region Üzleti logika

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
        /// <param name="price">Tétel egységár</param>
        /// <param name="quantity">Tétel mennyiség</param>
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double CountTotalPrice(double price, int quantity)
        {
            return price * quantity;
        }

        /// <summary>
        /// Metódus, amely számla nyomtatás esetén beállítja az adatbázisban fizetettre az adott foglalást
        /// </summary>
        /// <param name="booking">Számlázott foglalás</param>
        public void SetBookingAsPaid(Booking booking)
        {
            string sql = $"UPDATE booking SET booking.Paid = 1 WHERE booking.ID = \"{booking.ID}\"";
            database.DML(sql);
        }

        #endregion
    }
}
