using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak
    /// </summary>
    public partial class FormModalBilling : Form
    {
        #region Adattagok

        /// <summary>
        /// 
        /// </summary>
        private ModalBillingPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak konstruktora
        /// </summary>
        public FormModalBilling()
        {
            InitializeComponent();
            presenter = new ModalBillingPresenter();
        }

        private void FormModalBilling_Load(object sender, EventArgs e)
        {
            presenter.InitializeComboBoxWithCountryList(comboBoxCountry);
        }

        private void checkBoxCorporateGuest_CheckedChanged(object sender, EventArgs e)
        {
            presenter.SetCorporateGuest(checkBoxCorporateGuest, textBoxVatNumber);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
