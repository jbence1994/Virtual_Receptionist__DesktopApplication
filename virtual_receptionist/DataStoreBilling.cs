using System;
using System.Diagnostics;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace virtual_receptionist.Model
{
    public partial class DataStore
    {
        #region Adattagok



        #endregion

        #region Számlázó modul konstruktora



        #endregion

        #region Getter és setter tulajdonságok

        public List<BillingItems> BillingItems
        {
            get
            {
                return billingItems;
            }
        }

        #endregion

        #region Számlázó modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a számlázási tételeket és List<T> adatszerkezetek menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void ReadBillingItems()
        {
            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "SELECT billing_item.BillingItemName, billing_item_category.BillingItemCategoryName, billing_item_category.VAT, billing_item_category.Unit, billing_item.Price FROM billing_item, billing_item_category WHERE billing_item.Category=billing_item_category.ID",
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
        /// Metódus, amely adatforrásként szolál a számlázó főablak DataGridView GUI komponensnek
        /// </summary>
        /// <returns>A metódus visszatér egy Dattable adatszerkezettel, oszlopokkal</returns>
        public DataTable GetBillingItems()
        {
            DataTable items = new DataTable();

            items.Columns.Add("Name", typeof(string));
            items.Columns.Add("Price", typeof(double));
            items.Columns.Add("Unit", typeof(string));

            ReadBillingItems();
            foreach (BillingItems item in billingItems)
            {
                items.Rows.Add(item.Name, item.Price, item.Unit);
            }

            return items;
        }


        // TDD fejlesztést igényel:


        /// <summary>
        /// Metódus, amely DataTable típusú adatszerkezetbe menti a modális ablak által átadott számlázási adatok paramétereiből
        /// </summary>
        public void AddNewBillingItemsRow()
        {
        }
        /// <summary>
        /// Metódus, amely megszámolja egy adott DataGridView árakat tartalmazó oszlopaiban a végösszeget
        /// </summary>
        ///<param name="dataGridView">DataGridView GUI vezérlő, amelyben tartalmaz tétel ár oszlopot</param>
        /// <param name="cellPrice">DataGridView cella, amely a megszámolandó árakat tartalmazza</param>
        /// <param name="totalPrice">TextBox GUI vezérlő, amely a végösszeget írja ki</param>
        public void CountTotalPrice()
        {
        }
        /// <summary>
        /// Metódus, amely tétel kedvezményt számít
        /// </summary>
        /// <param name="itemPrice">Tétel értéke, amelyből kedvezményt számol a függvény</param>
        /// <returns>A kiszámolt kedvezmény értékével tér vissza a függvény</returns>
        public double CountItemDiscount(double itemPrice)
        {
            return 1;
        }
        /// <summary>
        /// Metódus, amely egy tétel ÁFA értékét számítja
        /// </summary>
        /// <param name="item">A kiszámolt kedvezmény értékével tér vissza a függvény</param>
        public double CountVAT(double item)
        {
            return 1;
        }

        #endregion
    }
}
