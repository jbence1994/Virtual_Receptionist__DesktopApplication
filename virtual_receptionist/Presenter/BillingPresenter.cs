using System;
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
        /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak egy példánya
        /// </summary>
        private FormModalBillingItems formModalBillingItems;

        #endregion

        #region Konstruktor
        
        #endregion

        #region Számlázó modul nézetfrissítései

        /// <summary>
        /// Számlázási tételek táblázatba új rekordot beszúró metódus
        /// </summary>
        public void AddNewRow()
        {
            formModalBillingItems = new FormModalBillingItems();
            formModalBillingItems.ShowDialog();
        }

        /// <summary>
        /// Számlázási tételek táblázatból meglévő rekordot törlő metódus
        /// </summary>
        public void DeleteRow()
        {
            //if (dataGridViewItems.SelectedRows.Count != 0)
            //{
            //    int rowToDelete = dataGridViewItems.SelectedRows[0].Index;
            //    dataGridViewItems.Rows.RemoveAt(rowToDelete);
            //}
            //else
            //{
            //    MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /// <summary>
        /// Számlázási tételek táblázatból meglévő rekordot módosító metódus
        /// </summary>
        public void UpdateRow()
        {
            //if (dataGridViewItems.SelectedRows.Count != 0)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        #endregion
    }
}
