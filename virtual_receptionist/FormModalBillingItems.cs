using System;
using System.Data;
using System.Windows.Forms;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak
    /// </summary>
    public partial class FormModalBillingItems : Form
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        public FormModalBillingItems()
        {
            InitializeComponent();
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            Model.DataStore dataStore = new Model.DataStore();
            dataStore.BillingItems;
            DataTable dt =dataStore.GetBillingItems();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem billingItems = new ListViewItem(row[1].ToString());

                for (int i = 2; i < dt.Columns.Count; i++)
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
        }

        #endregion
    }
}
