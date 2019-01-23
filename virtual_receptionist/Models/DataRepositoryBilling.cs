using System.Collections.Generic;
using System.Data;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Számlázó modul metódusai

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a számlázási tételeket tartalmazó listát
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
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

                BillingItems billingItemInstance = new BillingItems(name, category, vat, unit, price);
                billingItems.Add(billingItemInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti az országok kódjait és neveit tartalmazó listát
        /// </summary>
        private void UploadCountriesList()
        {
            string sql = "SELECT * FROM country";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string code = row["CountryCode"].ToString();
                string name = row["CountryName"].ToString();

                Country countryInstance = new Country(code, name);
                countries.Add(countryInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a magyarországi irányítószámokat és településeket tartalmazó listát
        /// </summary>
        private void UploadHungarianZipCodesAndCitiesList()
        {
            string sql = "SELECT * FROM hungarian_zip_code_and_city";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();

                HungarianZipCodesAndCities hungarianZipCodesAndCitiesInstance =
                    new HungarianZipCodesAndCities(zipCode, city);
                hungarianZipCodesAndCities.Add(hungarianZipCodesAndCitiesInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatforrásként szolgál a számlázó főablak DataGridView komponensének
        /// </summary>
        /// <returns>A metódus visszatér egy Dattable adatszerkezettel, oszlopokkal</returns>
        public DataTable GetBillingItems()
        {
            if (billingItems.Count != 0)
            {
                UploadBillingItemsList();
            }

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
        /// Metódus, amely adatforrásként szolgál a számlázó modális ablak ComboBox komponensének
        /// </summary>
        /// <returns>Országok neveivel feltöltött listát adja vissza</returns>
        public List<string> GetCountries()
        {
            if (countries.Count != 0)
            {
                UploadCountriesList();
            }

            List<string> filtratedCountries = new List<string>();

            foreach (Country country in countries)
            {
                if (!filtratedCountries.Contains(country.Name))
                {
                    filtratedCountries.Add(country.Name);
                }
            }

            filtratedCountries.Sort();

            return filtratedCountries;
        }

        /// <summary>
        /// Metódus, amely visszaadja az országok neveit a hozzátartozó országkóddal
        /// </summary>
        /// <returns>Országok neveivel és országkódjaival feltöltött listát adja vissza</returns>
        public List<Country> GetCountriesWithCountryCode()
        {
            if (countries.Count != 0)
            {
                UploadCountriesList();
            }

            return countries;
        }

        /// <summary>
        /// Metódus, amely adatforrásként szolgált a számlázó modális ablak ComboBox komponensének
        /// </summary>
        /// <returns>Adatokkal feltöltött szótárat adja vissza</returns>
        public List<HungarianZipCodesAndCities> GetHungarianZipCodesAndCities()
        {
            if (hungarianZipCodesAndCities.Count != 0)
            {
                UploadHungarianZipCodesAndCitiesList();
            }

            return hungarianZipCodesAndCities;
        }

        /// <summary>
        /// Metódus, amely elmenti egy listába a magyar települések neveit
        /// </summary>
        /// <returns>Magyar települések neveivel feltöltött listát adja vissza</returns>
        public List<string> GetHungarianCities()
        {
            if (hungarianZipCodesAndCities.Count != 0)
            {
                UploadHungarianZipCodesAndCitiesList();
            }

            List<string> filtratedCities = new List<string>();

            foreach (HungarianZipCodesAndCities hungarianZipCodesAndCities in hungarianZipCodesAndCities)
            {
                if (!filtratedCities.Contains(hungarianZipCodesAndCities.City))
                {
                    filtratedCities.Add(hungarianZipCodesAndCities.City);
                }
            }

            filtratedCities.Sort();
            return filtratedCities;
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
