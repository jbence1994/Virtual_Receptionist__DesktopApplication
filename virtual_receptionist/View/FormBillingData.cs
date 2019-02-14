using virtual_receptionist.Presenter;
using System.Windows.Forms;

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
            presenter.GetBillingData();
        }

        #endregion
    }
}
