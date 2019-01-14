using System;
using System.Diagnostics;
using System.Data;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Számlázó modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a számlázási tételeket és lista adatszerkezetek menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void GetBillingItemsToList()
        {
            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "SELECT billing_item.BillingItemName, billing_item.Price, billing_item_category.VAT, billing_item_category.BillingItemCategoryName, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID",
                    Connection = mySqlConnection
                };

                mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    string name = mySqlDataReader["BillingItemName"].ToString();
                    string category = mySqlDataReader["BillingItemCategoryName"].ToString();
                    double vat = double.Parse(mySqlDataReader["VAT"].ToString());
                    string unit = mySqlDataReader["Unit"].ToString();
                    double price = double.Parse(mySqlDataReader["Price"].ToString());

                    BillingItems items = new BillingItems(name, category, vat, unit, price);
                    billingItems.Add(items);
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
                Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            }
        }
        /// <summary>
        /// Metódus, amely adatforrásként szolál a számlázó főablak DataGridView komponensének
        /// </summary>
        /// <returns>A metódus visszatér egy Dattable adatszerkezettel, oszlopokkal</returns>
        public DataTable GetBillingItemsToDataTable()
        {
            GetBillingItemsToList();

            DataTable items = new DataTable();
            items.Columns.Add("Name", typeof(string));
            items.Columns.Add("Price", typeof(double));
            items.Columns.Add("VAT", typeof(double));
            items.Columns.Add("Category", typeof(string));
            items.Columns.Add("Unit", typeof(string));

            foreach (BillingItems item in billingItems)
            {
                items.Rows.Add(item.Name, item.Price, item.Vat, item.Category, item.Unit);
            }

            return items;
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

        #endregion
    }
}
