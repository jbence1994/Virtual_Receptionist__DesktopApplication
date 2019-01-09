using System;
using System.Data;
using System.Windows.Forms;

namespace virtual_receptionist
{
    /// <summary>
    /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak
    /// </summary>
    public partial class FormModalBillingItems : Form
    {
        #region Adattagok

        /// <summary>
        /// Adattár osztály egy példánya
        /// </summary>
        private DataRepository dataStore;
        /// <summary>
        /// DataTable adatszerkezet, amely a mindig újabb rekordokkal bővül, ha a modális ablakkal új tételeket adunk hozzá
        /// </summary>
        private DataTable billingItems;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        /// <param name="billingItems">DataTable adatszerkezet, amely a hozzáadott számlázási tételeket tartalmazza</param>
        public FormModalBillingItems(DataTable billingItems)
        {
            InitializeComponent();
            //dataStore = new DataStore("localhost", "virtual_receptionist", "root", "", "3306");
            this.billingItems = billingItems;
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            DataTable billingItemsDataContainer = dataStore.GetBillingItems();

            foreach (DataRow row in billingItemsDataContainer.Rows)
            {
                ListViewItem billingItems = new ListViewItem(row[1].ToString());

                for (int i = 2; i < billingItemsDataContainer.Columns.Count; i++)
                {
                    billingItems.SubItems.Add(row[i].ToString());
                }

                listViewBillingItems.Items.Add(billingItems);
            }
        }

        private void listViewBillingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBillingItems.SelectedItems.Count > 0)
            {
                buttonAdd.Enabled = true;
                textBoxItem.Text = listViewBillingItems.SelectedItems[0].Text;
                textBoxPrice.Text = listViewBillingItems.SelectedItems[0].SubItems[1].Text;
                textBoxUnit.Text = listViewBillingItems.SelectedItems[0].SubItems[2].Text;
                textBoxQuantity.Clear();
                maskedTextBoxVAT.Clear();
                maskedTextBoxItemDiscount.Clear();
            }
        }

        private void listViewBillingItems_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = 160;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string item = textBoxItem.Text;
            double price = double.Parse(textBoxPrice.Text) * double.Parse(textBoxQuantity.Text);
            string unit = textBoxUnit.Text;
            double quantity = double.Parse(textBoxQuantity.Text);

            dataStore.AddNewBillingItemsRow(billingItems, item, price, unit, quantity);
        }

        #endregion
    }
}
