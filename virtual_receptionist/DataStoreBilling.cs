using System.Diagnostics;
using System.Data;
using MySql.Data.MySqlClient;

namespace virtual_receptionist
{
    public partial class DataStore
    {
        #region Adattagok

        /// <summary>
        /// 
        /// </summary>
        private DataTable items;

        #endregion

        #region Számlázó modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a számlázási tételeket és egy DataTable adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetBillingItems()
        {
            DataTable billingItems = new DataTable();

            mySqlConnection.Open();
            Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

            mySqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM billing_items",
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

            mySqlDataAdapter.Fill(billingItems);

            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");

            return billingItems;
        }
        /// <summary>
        /// Metódus, amely kiszámolja egy adott tétel árát a mennyiségből
        /// </summary>
        /// <param name="price">Tétel ára</param>
        /// <param name="quantity">Tétel mennyisége</param>
        /// <returns>A metódus a kiszámolt értékkel tér vissza</returns>
        public double CalculatePriceByQuantityFromPrice(double price, double quantity)
        {
            return price * quantity;
        }
        /// <summary>
        /// Metódus, amely 'DataTable' típusú adatszerkezetbe menti a modális ablak által átadott számlázási adatok paramétereiből
        /// </summary>
        /// <param name="item">Tétel neve</param>
        /// <param name="price">Tétel ára</param>
        /// <param name="unit">Tétel egység</param>
        /// <param name="quantity">Tétel mennyisége</param>
        /// <returns></returns>
        public void SetDataTableByBillingItems(string item, double price, string unit, double quantity)
        {
            items = new DataTable();

            items.Columns.Add("Tétel", typeof(string));
            items.Columns.Add("Egységár", typeof(double));
            items.Columns.Add("Egység", typeof(string));
            items.Columns.Add("Mennyiség", typeof(double));

            items.Rows.Add(item);
            items.Rows.Add(price);
            items.Rows.Add(unit);
            items.Rows.Add(quantity);
        }

        #endregion
    }
}
