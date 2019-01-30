using System;
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
        /// Számlázó modul tételek felvételéhez szükséges modális ablak prezenter egy példánya
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
            presenter = new ModalBillingItemsPresenter(listViewBillingItems, buttonAdd, textBoxItem, textBoxPrice,
                textBoxUnit, textBoxQuantity, maskedTextBoxVAT, maskedTextBoxItemDiscount);
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            presenter.InitializeBillingItemsListView();
        }

        private void listViewBillingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.SetControlsWithData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            presenter.AddBillingItemToRecord();
        }

        #endregion
    }
}
