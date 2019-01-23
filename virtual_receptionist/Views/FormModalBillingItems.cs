using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul tételek felvételéhez szükséges modális ablak
    /// </summary>
    public partial class FormModalBillingItems : Form
    {
        #region Adattagok

        /// <summary>
        /// 
        /// </summary>
        private ModalBillingItemsPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        public FormModalBillingItems()
        {
            InitializeComponent();
            presenter = new ModalBillingItemsPresenter(listViewBillingItems);
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            Model.DataRepository dataStore = new Model.DataRepository();

            DataTable dt = dataStore.GetBillingItems();

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

        private void listViewBillingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBillingItems.SelectedItems.Count > 0)
            {
                buttonAdd.Enabled = true;
                textBoxItem.Text = listViewBillingItems.SelectedItems[0].Text;
                textBoxPrice.Text = listViewBillingItems.SelectedItems[0].SubItems[1].Text;
                maskedTextBoxVAT.Text = listViewBillingItems.SelectedItems[0].SubItems[2].Text;
                textBoxQuantity.Clear();
                textBoxUnit.Text = listViewBillingItems.SelectedItems[0].SubItems[4].Text;
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
            if (maskedTextBoxItemDiscount.MaskFull)
            {

            }
        }

        #endregion
    }
}
