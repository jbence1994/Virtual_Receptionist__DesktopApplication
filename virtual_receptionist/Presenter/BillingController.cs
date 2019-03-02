using System.Data;
using System.Collections.Generic;
using virtual_receptionist.BusinessLogicLayer;

namespace virtual_receptionist.ApplicationLayer
{
    public partial class Controller
    {
        #region Adattagok

        /// <summary>
        /// Számlázási tételek adattábla
        /// </summary>
        private DataTable billingDataTable;

        #endregion

        //billingDataTable = new DataTable();
        //billingDataTable.Columns.Add("Tétel", typeof(string));
        //    billingDataTable.Columns.Add("Ár", typeof(double));
        //    billingDataTable.Columns.Add("Egység", typeof(string));
        //    billingDataTable.Columns.Add("Mennyiség", typeof(int));

        #region Metódusok

        /// <summary>
        /// Metódus, amely beállítja a számlázási tétel adatait
        /// </summary>
        /// <param name="itemParameters">Számlázási tétel paraméterei</param>
        public void SetBillingItemParameters(params object[] itemParameters)
        {
            string item = itemParameters[0].ToString();
            int vat = int.Parse(itemParameters[1].ToString());
            string unit = itemParameters[1].ToString();
            double price = double.Parse(itemParameters[2].ToString());
            int quantity = int.Parse(itemParameters[3].ToString());
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
            billingDataTable.Rows.Add();
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
            billingDataTable.Rows.Add();
            return billingDataTable;
        }

        /// <summary>
        /// Metódus, amely lekéri a számlázási tételek adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A számlázási tételek adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetBillingItems()
        {
            List<BillingItem> billingItems = Repository.BillingItems;

            DataTable billingItemsDataTable = new DataTable();
            billingItemsDataTable.Columns.Add("Name", typeof(string));
            billingItemsDataTable.Columns.Add("Price", typeof(double));
            billingItemsDataTable.Columns.Add("VAT", typeof(double));
            billingItemsDataTable.Columns.Add("CategoryName", typeof(string));
            billingItemsDataTable.Columns.Add("Unit", typeof(string));

            foreach (BillingItem billingItem in billingItems)
            {
                billingItemsDataTable.Rows.Add(billingItem.Name, billingItem.Price, billingItem.Category.VAT,
                    billingItem.Category.Name, billingItem.Category.Unit);
            }

            return billingItemsDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja a fizetendő végösszeget
        /// </summary>
        /// <param name="prices">Bementi paraméter tétel árak</param>
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double GetTotalPrice(params double[] prices)
        {
            double total = billingBLL.CountTotalPrice(prices);
            return total;
        }

        #endregion
    }
}
