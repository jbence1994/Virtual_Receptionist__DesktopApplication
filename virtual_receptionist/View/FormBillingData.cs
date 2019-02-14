using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    public partial class FormBillingData : Form
    {
        #region Adattagok

        /// <summary>
        /// 
        /// </summary>
        private BillingPresenter presenter;

        #endregion


        #region Konstruktor

        /// <summary>
        /// 
        /// </summary>
        public FormBillingData()
        {
            InitializeComponent();
            presenter = new BillingPresenter();
        }

        #endregion

        #region UI események

        private void FormBillingData_Load(object sender, System.EventArgs e)
        {
            DataTable billingDataDataTable = presenter.GetBillingData();

            foreach (DataRow row in billingDataDataTable.Rows)
            {
                ListViewItem billingData = new ListViewItem(row[0].ToString());

                for (int i = 1; i < billingDataDataTable.Columns.Count; i++)
                {
                    billingData.SubItems.Add(row[i].ToString());
                }

                listViewPrivateGuests.Items.Add(billingData);
            }
        }

        #endregion
    }
}
