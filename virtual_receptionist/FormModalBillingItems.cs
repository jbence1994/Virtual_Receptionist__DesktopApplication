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
        private DataStore dataStore;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        public FormModalBillingItems()
        {
            InitializeComponent();
            dataStore = new DataStore("localhost", "virtual_receptionist", "root", "", "3306");
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in dataStore.GetBillingItems().Rows)
            {
                ListViewItem billingItems = new ListViewItem(row[1].ToString());

                for (int i = 2; i < dataStore.GetBillingItems().Columns.Count; i++)
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
            }
        }

        private void listViewBillingItems_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = 160;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int price = int.Parse(textBoxPrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);
                MessageBox.Show(dataStore.CalculateItemPrice(price, quantity).ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }

        }

        #endregion
    }
}
