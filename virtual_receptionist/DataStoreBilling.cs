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

        /// <summary>
        /// 
        /// </summary>
        private DataTable tableOfBillingItems;
        /// <summary>
        /// 
        /// </summary>
        private List<BillingItems> listOfBillingItems;

        #endregion

        #region Számlázó modul konstruktora

        /// <summary>
        /// Konstruktor
        /// </summary>
        public DataStore()
        {
            tableOfBillingItems = new DataTable();
            listOfBillingItems = new List<BillingItems>();
        }

        #endregion

        #region Getter és setter tulajdonságok

        public List<BillingItems> ListOfBillingItems
        {
            get
            {
                return listOfBillingItems;
            }
        }

        #endregion

        #region Számlázó modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a számlázási tételeket és DataTable, valamint List<T> adatszerkezetek menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public void GetBillingItems()
        {
            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "SELECT billing_item.Item, billing_item.Price, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID",
                    Connection = mySqlConnection
                };

                mySqlDataAdapter = new MySqlDataAdapter()
                {
                    SelectCommand = mySqlCommand
                };

                mySqlCommandBuilder = new MySqlCommandBuilder()
                {
                    DataAdapter = mySqlDataAdapter
                };

                mySqlDataAdapter.Fill(tableOfBillingItems);


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
        /// Metódus, amely megadja a számlázó főablak DataGridView vezérlőnek az adatkonténer és azok oszlopainak forrását
        /// </summary>
        /// <returns>A metódus visszatér egy Dattable adatszerkezettel, oszlopokkal</returns>
        public DataTable InitializeDataTableBillingItemsColumns()
        {
            DataTable items = new DataTable();

            items.Columns.Add("Tétel", typeof(string));
            items.Columns.Add("Ár", typeof(double));
            items.Columns.Add("Egység", typeof(string));
            items.Columns.Add("Mennyiség", typeof(double));

            return items;
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
