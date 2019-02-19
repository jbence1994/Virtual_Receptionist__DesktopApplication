using System.Data;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó ablak és számlázási tételek modális ablak prezentere
    /// </summary>
    public class BillingPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Számlázási tételek adattábla
        /// </summary>
        private DataTable billingDataTable;

        /// <summary>
        /// Számlázási tétel modell osztály egy példánya
        /// </summary>
        private static BillingItem billingItem;

        private static BillingItemCategory billingItemCategory;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó ablak és számlázási tételek modális ablak prezenter konstruktora
        /// </summary>
        public BillingPresenter()
        {
            billingDataTable = new DataTable();
            billingDataTable.Columns.Add("Tétel", typeof(string));
            billingDataTable.Columns.Add("Ár", typeof(double));
            billingDataTable.Columns.Add("Egység", typeof(string));
            billingDataTable.Columns.Add("Mennyiség", typeof(int));
        }

        #endregion

        #region Számlázó modul nézetfrissítései

        /// <summary>
        /// Metódus, amely beállítja a számlázási tétel adatait
        /// </summary>
        /// <param name="itemParameters">Számlázási tétel adatai</param>
        public void SetBillingItemParameters(params object[] itemParameters)
        {
            string item = itemParameters[0].ToString();
            int vat = int.Parse(itemParameters[1].ToString());
            string unit = itemParameters[1].ToString();
            double price = double.Parse(itemParameters[2].ToString());
            int quantity = int.Parse(itemParameters[3].ToString());

            billingItemCategory = new BillingItemCategory("", vat, unit);
            billingItem = new BillingItem(item, billingItemCategory, price, quantity);
        }

        /// <summary>
        /// Metódus, amely ellenőrzi üres-e a számlázási tételek adattáblát tartalmazó GUI vezárlő
        /// </summary>
        /// <param name="rows">Rekordok száma</param>
        /// <returns>Ha üres a GUI vezérlő logikai igazzal tér vissza a metódus, ellenkező esetben logikai hamissal tér vissza a függvény</returns>
        public bool IsEmptyBillingTable(int rows)
        {
            if (rows != 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Új rekord hozzáadása
        /// </summary>
        /// <returns>Módosított adattáblát adja vissza a függvény</returns>
        public DataTable AddNewRow()
        {
            billingDataTable.Rows.Add(billingItem.Name, billingItem.Price, billingItemCategory.Unit,
                billingItem.Quantity);
            return billingDataTable;
        }

        /// <summary>
        /// Rekord törlése
        /// </summary>
        /// <param name="index">Törlendő rekord</param>
        /// <returns>Módosított adattáblát adja vissza a függvény</returns>
        public DataTable DeleteRow(int index)
        {
            billingDataTable.Rows.RemoveAt(index);
            return billingDataTable;
        }

        /// <summary>
        /// Rekord módosítása
        /// </summary>
        /// <param name="index">Módosítandó rekord</param>
        /// <returns>Módosított adattáblát adja vissza a függvény</returns>
        public DataTable UpdateRow(int index)
        {
            billingDataTable.Rows.RemoveAt(index);
            billingDataTable.Rows.Add(billingItem.Name, billingItem.Price, billingItemCategory.Unit,
                billingItem.Quantity);
            return billingDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja a számlázási tételeket az adattárból
        /// </summary>
        /// <returns>A számlázási tételekkel feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable InitializeBillingItemsTable()
        {
            DataTable billingItems = dataRepository.GetBillingItems();
            return billingItems;
        }

        /// <summary>
        /// Metódus, amely visszaadja a fizetendő végösszeget
        /// </summary>
        /// <param name="prices">Bementi paraméter tétel árak</param>
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double GetTotalPrice(params double[] prices)
        {
            double total = dataRepository.CountTotalPrice(prices);
            return total;
        }

        #endregion
    }
}
