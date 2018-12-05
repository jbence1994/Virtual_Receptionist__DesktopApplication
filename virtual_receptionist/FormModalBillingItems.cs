using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virtual_receptionist
{
    /// <summary>
    /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak
    /// </summary>
    public partial class FormModalBillingItems : Form
    {
        #region Adattagok

        //private DataStore dataStore;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        public FormModalBillingItems()
        {
            InitializeComponent();
            //dataStore = new DataStore("localhost", "virtual_receptionist", "root", "", "3306");
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            //foreach (DataRow row in dataStore.GetBillingItems().Rows)
            //{
            //    ListViewItem billingItems = new ListViewItem(row[1].ToString());

            //    for (int i = 2; i < dataStore.GetBillingItems().Columns.Count; i++)
            //    {
            //        billingItems.SubItems.Add(row[i].ToString());
            //    }

            //    listViewBillingItems.Items.Add(billingItems);
            //}
        }

        #endregion
    }
}
