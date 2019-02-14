using System.Data;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó ablak és számlázási tételek modális ablak prezentere
    /// </summary>
    public class BillingPresenter : DefaultPresenter
    {
        #region Számlázó modul nézetfrissítései

        /// <summary>
        /// Számlázási tételek adattábla
        /// </summary>
        private DataTable billingDataTable;

        /// <summary>
        /// Számlázási tétel modell osztály egy példánya
        /// </summary>
        private static BillingItem billingItem;

        /// <summary>
        /// Számlázási tétel mennyisége
        /// </summary>
        private static int quantity;

        /// <summary>
        /// Számlázó ablak és számlázási tételek modális ablak prezenter konstruktora
        /// </summary>
        public BillingPresenter()
        {
            billingItem = new BillingItem();

            billingDataTable = new DataTable();
            billingDataTable.Columns.Add("Tétel", typeof(string));
            billingDataTable.Columns.Add("Ár", typeof(double));
            billingDataTable.Columns.Add("Egység", typeof(string));
            billingDataTable.Columns.Add("Mennyiség", typeof(int));
        }

        /// <summary>
        /// Metódus, amely beállítja a számlázási tétel adatait
        /// </summary>
        /// <param name="itemParamteres">Számlázási tétel adatai</param>
        public void SetItemParameters(params object[] itemParamteres)
        {
            billingItem.Name = itemParamteres[0].ToString();
            billingItem.Price = double.Parse(itemParamteres[1].ToString());
            billingItem.Unit = itemParamteres[2].ToString();
            quantity = int.Parse(itemParamteres[3].ToString());
        }

        /// <summary>
        /// Új rekord hozzáadása
        /// </summary>
        /// <returns>Módosított adattáblát adja vissza a függvény</returns>
        public DataTable AddNewRow()
        {
            billingDataTable.Rows.Add(billingItem.Name, billingItem.Price, billingItem.Unit, quantity);
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
            billingDataTable.Rows.Add(billingItem.Name, billingItem.Price, billingItem.Unit, quantity);
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
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double GetTotalPrice()
        {
            double total = dataRepository.CountTotalPrice();
            return total;
        }

        #endregion
    }
}
