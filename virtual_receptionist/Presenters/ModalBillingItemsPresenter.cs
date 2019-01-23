using System.Data;
using System.Windows.Forms;
using virtual_receptionist.View;
using virtual_receptionist.Model;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó modul tételek felvételéhez szükséges modális ablak prezentere
    /// </summary>
    public class ModalBillingItemsPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Számlázási tételek táblázat
        /// </summary>
        private ListView listViewBillingItems;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételéhez szükséges modális ablak prezenter konstruktora
        /// </summary>
        /// <param name="listViewBillingItems">Számlázási tételek táblázat</param>
        public ModalBillingItemsPresenter(ListView listViewBillingItems)
        {
            this.listViewBillingItems = listViewBillingItems;
        }

        #endregion

        #region Számlázási tételek modális ablak nézetfrissítései

        /// <summary>
        /// Számlázi tételek táblázatot adatbázisból adatokkal feltöltő metódus
        /// </summary>
        public void InitializeBillingItemsListView()
        {
            DataTable dt = dataRepository.GetBillingItems();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem billingItems = new ListViewItem(row[0].ToString());

                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    billingItems.SubItems.Add(row[i].ToString());
                }

                listViewBillingItems.Items.Add(billingItems);
            }
        }

        /// <summary>
        /// Metódus, amely a táblázat adatait GUI vezérlőkbe menti el módosítás céljából
        /// </summary>
        /// <param name="textBoxQuantity">Mennyiség szövegmező</param>
        /// <param name="maskedTextBoxItemDiscount">Tételkedvezmény maszkolt szövegmező</param>
        /// <param name="controls">Egyéb GUI vezérlők</param>
        public void SetControlsWithData(TextBox textBoxQuantity, MaskedTextBox maskedTextBoxItemDiscount,
            params Control[] controls)
        {
            if (listViewBillingItems.SelectedItems.Count > 0)
            {
                controls[0].Enabled = true;
                controls[1].Text = listViewBillingItems.SelectedItems[0].Text;
                controls[2].Text = listViewBillingItems.SelectedItems[0].SubItems[1].Text;
                controls[3].Text = listViewBillingItems.SelectedItems[0].SubItems[2].Text;
                textBoxQuantity.Clear();
                controls[4].Text = listViewBillingItems.SelectedItems[0].SubItems[4].Text;
                maskedTextBoxItemDiscount.Clear();
            }
        }

        /// <summary>
        /// Metódus, amely rekordot készít a felvitt számlázási tétel beállításaiból a számlázó ablak táblázatába
        /// </summary>
        public void AddBillingItemToRecord()
        {

        }

        #endregion
    }
}
