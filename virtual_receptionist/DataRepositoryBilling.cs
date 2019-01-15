using System.Data;
using System.Collections.Generic;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Számlázó modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a számlázási tételeket és lista adatszerkezetek menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void UploadBillingItemsList()
        {
            string sql = "SELECT billing_item.BillingItemName, billing_item.Price, billing_item_category.VAT, billing_item_category.BillingItemCategoryName, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID";
            DataTable dt = database.GetTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["BillingItemName"].ToString();
                string category = row["BillingItemCategoryName"].ToString();
                double vat = double.Parse(row["VAT"].ToString());
                string unit = row["Unit"].ToString();
                double price = double.Parse(row["Price"].ToString());

                BillingItems billingItemInstance = new BillingItems(name, category, vat, unit, price);
                billingItems.Add(billingItemInstance);
            }
        }
        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa az országok kódjait, neveit és lista adatszerkezetek menti őket
        /// </summary>
        private void UploadCountriesList()
        {
            string sql = "SELECT * FROM country";
            DataTable dt = database.GetTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                string code = row["CountryCode"].ToString();
                string name = row["CountryName"].ToString();

                Country country = new Country(code, name);
                countries.Add(country);
            }
        }
        /// <summary>
        /// Metódus, amely adatforrásként szolgál a számlázó főablak DataGridView komponensének
        /// </summary>
        /// <returns>A metódus visszatér egy Dattable adatszerkezettel, oszlopokkal</returns>
        public DataTable GetBillingItems()
        {
            UploadBillingItemsList();

            DataTable billingItemsDataTable = new DataTable();
            billingItemsDataTable.Columns.Add("Name", typeof(string));
            billingItemsDataTable.Columns.Add("Price", typeof(double));
            billingItemsDataTable.Columns.Add("VAT", typeof(double));
            billingItemsDataTable.Columns.Add("Category", typeof(string));
            billingItemsDataTable.Columns.Add("Unit", typeof(string));

            foreach (BillingItems item in billingItems)
            {
                billingItemsDataTable.Rows.Add(item.Name, item.Price, item.Vat, item.Category, item.Unit);
            }

            return billingItemsDataTable;
        }
        /// <summary>
        /// Metódus, amely adatforrásként szolgált a számlázó modálkis ablak ComboBox komponensének
        /// </summary>
        /// <returns>Adatokkal feltöltött listát adja vissza</returns>
        public List<Country> GetCountries()
        {
            UploadCountriesList();
            return countries;
        }
        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a magyarországi irányítószámok és települések nevét és egy szótár adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött szótárat adja vissza</returns>
        public Dictionary<string, string> GetHungarianZipCodesAndCities()
        {
            //   string sql = "SELECT * FROM hungarian_zip_code_and_city";

            return new Dictionary<string, string>();
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
