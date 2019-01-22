using System.Linq;
using System.Windows.Forms;
using virtual_receptionist.View;
using virtual_receptionist.Model;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó modul prezentere
    /// </summary>
    public class BillingPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Számlázási tételek táblázat
        /// </summary>
        private DataGridView dataGridViewItems;
        /// <summary>
        /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak egy példánya
        /// </summary>
        private FormModalBillingItems formModalBillingItems;
        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak egy példánya
        /// </summary>
        private FormModalBilling formModalBilling;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul prezenter konstruktora
        /// </summary>
        /// <param name="dataGridViewItems">Számlázási tételek táblázat</param>
        public BillingPresenter(DataGridView dataGridViewItems)
        {
            this.dataGridViewItems = dataGridViewItems;
        }

        #endregion

        #region Számlázó modul nézetfrissítései

        /// <summary>
        /// 
        /// </summary>
        public void ImportData()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        public void PrintInvoice()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        public void SaveInvoice()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        public void AddNewRow()
        {
            formModalBillingItems = new FormModalBillingItems();
            formModalBillingItems.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        public void DeleteRow()
        {
            if (dataGridViewItems.SelectedRows.Count != 0)
            {
                int rowToDelete = dataGridViewItems.SelectedRows[0].Index;
                dataGridViewItems.Rows.RemoveAt(rowToDelete);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void UpdateRow()
        {
            if (dataGridViewItems.SelectedRows.Count != 0)
            {

            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public void NewData(params object[] buttons)
        {

            formModalBilling = new FormModalBilling();

            if (formModalBilling.ShowDialog() == DialogResult.OK)
            {
                buttonAddItem.Enabled = true;
                buttonUpdateItem.Enabled = true;
                buttonDeleteItem.Enabled = true;
                buttonPrintInvoice.Enabled = true;
                buttonSaveInvoice.Enabled = true;
            }
        }
    }
}
