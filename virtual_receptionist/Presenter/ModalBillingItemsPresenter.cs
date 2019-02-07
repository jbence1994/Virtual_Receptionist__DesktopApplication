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

        /// <summary>
        /// Hozzáadás gomb
        /// </summary>
        private Button buttonAdd;

        /// <summary>
        /// Tétel szövegmező
        /// </summary>
        private TextBox textBoxItem;

        /// <summary>
        /// Ár szövegmező
        /// </summary>
        private TextBox textBoxPrice;

        /// <summary>
        /// Egység szövegmező
        /// </summary>
        private TextBox textBoxUnit;

        /// <summary>
        /// Mennyiség szövegmező
        /// </summary>
        private TextBox textBoxQuantity;

        /// <summary>
        /// ÁFA maszkolt szövegmező
        /// </summary>
        private MaskedTextBox maskedTextBoxVAT;

        /// <summary>
        /// Tétel kedvezmény maszkolt szövegmező
        /// </summary>
        private MaskedTextBox maskedTextBoxItemDiscount;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételéhez szükséges modális ablak prezenter konstruktora
        /// </summary>
        /// <param name="controls">Paraméterül átadott GUI vezérlők</param>
        public ModalBillingItemsPresenter(params Control[] controls)
        {
            listViewBillingItems = (ListView) controls[0];
            buttonAdd = (Button) controls[1];
            textBoxItem = (TextBox) controls[2];
            textBoxPrice = (TextBox) controls[3];
            textBoxUnit = (TextBox) controls[4];
            textBoxQuantity = (TextBox) controls[5];
            maskedTextBoxVAT = (MaskedTextBox) controls[6];
            maskedTextBoxItemDiscount = (MaskedTextBox) controls[7];
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
        public void SetControlsWithData()
        {
            if (listViewBillingItems.SelectedItems.Count > 0)
            {
                buttonAdd.Enabled = true;
                textBoxItem.Text = listViewBillingItems.SelectedItems[0].Text;
                textBoxPrice.Text = listViewBillingItems.SelectedItems[0].SubItems[1].Text;
                maskedTextBoxVAT.Text = listViewBillingItems.SelectedItems[0].SubItems[2].Text;
                textBoxUnit.Text = listViewBillingItems.SelectedItems[0].SubItems[4].Text;
                textBoxQuantity.Clear();
                maskedTextBoxItemDiscount.Clear();
            }
        }

        /// <summary>
        /// Metódus, amely rekordot készít a felvitt számlázási tétel beállításaiból a számlázó ablak táblázatába
        /// </summary>
        public void AddBillingItemToRecord()
        {
            if (maskedTextBoxItemDiscount.MaskFull)
            {

            }
        }

        #endregion
    }
}
