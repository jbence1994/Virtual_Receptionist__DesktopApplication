using System;
using System.Data;
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
            string sql =
                "SELECT booking_to_bill.ID, guest.Name, room.Name, room.Number, room_category.CategoryName, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate FROM booking_to_bill, guest, booking, room_category, room WHERE booking_to_bill.BookingID=booking.ID AND booking.GuestID = guest.ID AND booking.RoomID = room.ID AND room.Category = room_category.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["ID"].ToString());
                string guestName = row["Name"].ToString();
                int roomNumber = int.Parse(row["Number"].ToString());
                string roomCategory = row["CategoryName"].ToString();
                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                DateTime arrivalDate = DateTime.Parse(row["ArrivalDate"].ToString());
                DateTime departureDate = DateTime.Parse(row["DepartureDate"].ToString());

                BillingData billingDataInstance =
                    new BillingData(id, guestName, roomNumber, roomCategory, numberOfGuests, arrivalDate,
                        departureDate);
                billingData.Add(billingDataInstance);
            }
        }

        /// <summary>
        /// Metódus, amely feltölti a számlázási adatokat tartalmazó adattáblát a listában tárolt adatokkal
        /// </summary>
        /// <returns>A számlázási adatokat tartalmazó listából feltöltött adattáblával tér vissza a függvény</returns>
        public DataTable GetBillingData()
        {
            if (billingData.Count == 0)
            {
                UploadBillingDataList();
            }

            DataTable billingDataDataTable = new DataTable();
            billingDataDataTable.Columns.Add("ID", typeof(int));
            billingDataDataTable.Columns.Add("Name", typeof(string));
            billingDataDataTable.Columns.Add("RoomNumber", typeof(int));
            billingDataDataTable.Columns.Add("RoomCategory", typeof(string));
            billingDataDataTable.Columns.Add("NumberOfGuests", typeof(int));
            billingDataDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
            billingDataDataTable.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (BillingData data in billingData)
            {
                billingDataDataTable.Rows.Add(data.ID, data.GuestName, data.RoomNumber, data.RoomCategory,
                    data.NumberOfGuest, data.ArrivalDate, data.DepartureDate);
            }

            return billingDataDataTable;
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
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double CountTotalPrice()
        {
            return new double();
        }

        #endregion
    }
}
