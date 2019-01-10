using System;
using System.Windows.Forms;
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
        public void ReadBillingItems()
        {
            BillingItems items = new BillingItems();

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
                    items.Name = mySqlDataReader["BillingItemName"].ToString();
                    items.Category = mySqlDataReader["BillingItemCategoryName"].ToString();
                    items.Vat = double.Parse(mySqlDataReader["VAT"].ToString());
                    items.Unit = mySqlDataReader["Unit"].ToString();
                    items.Price = double.Parse(mySqlDataReader["Price"].ToString());

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

            items.Columns.Add("Tétel", typeof(string));
            items.Columns.Add("Kateógia", typeof(string));
            items.Columns.Add("Áfa", typeof(double));
            items.Columns.Add("Egység", typeof(string));
            items.Columns.Add("Ár", typeof(double));

            foreach (BillingItems item in billingItems)
            {
                items.Rows.Add(item.Name, item.Category, item.Vat, item.Unit, item.Price);
            }

            return items;
        }


        // TDD fejlesztést igényel:

        /// <summary>
        /// Metódus, amely DataTable típusú adatszerkezetbe menti a modális ablak által átadott számlázási adatok paramétereiből
        /// </summary>
        /// <param name="item">Tétel neve</param>
        /// <param name="price">Tétel ára</param>
        /// <param name="unit">Tétel egység</param>
        /// <param name="quantity">Tétel mennyisége</param>
        public void AddNewBillingItemsRow(DataTable billingItems, string item, double price, string unit, double quantity)
        {
            billingItems.Rows.Add(item, price, unit, quantity);
        }
        /// <summary>
        /// Metódus, amely megszámolja egy adott DataGridView árakat tartalmazó oszlopaiban a végösszeget
        /// </summary>
        ///<param name="dataGridView">DataGridView GUI vezérlő, amelyben tartalmaz tétel ár oszlopot</param>
        /// <param name="cellPrice">DataGridView cella, amely a megszámolandó árakat tartalmazza</param>
        /// <param name="totalPrice">TextBox GUI vezérlő, amely a végösszeget írja ki</param>
        public void CountTotalPrice(DataGridView dataGridView, int cellPrice, TextBox totalPrice)
        {
            double total = 0;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                total += Convert.ToDouble(dataGridView.Rows[i].Cells[cellPrice].Value);
            }

            totalPrice.Clear();
            totalPrice.Text = total.ToString();
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
