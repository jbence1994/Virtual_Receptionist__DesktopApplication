using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Vendég bejelentkező lap ablak
    /// </summary>
    public partial class FormGuestRegistrationCard : Form
    {
        #region Adattagok

        /// <summary>
        /// Vendég bejelentkező lap prezenter egy példánya
        /// </summary>
        private GuestRegistrationCardPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég bejelentkező lap ablak konstruktora
        /// </summary>
        public FormGuestRegistrationCard()
        {
            InitializeComponent();
            presenter = new GuestRegistrationCardPresenter();
        }

        #endregion

        #region UI események

        private void FormGuestRegistrationCard_Load(object sender, System.EventArgs e)
        {
            presenter.SetRegistrationCard(comboBoxCountry);
        }

        private void buttonSaveToDatabase_Click(object sender, System.EventArgs e)
        {
            presenter.SaveGuestDataToDatabase();
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            presenter.SaveRent();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            presenter.BackToMainMenu(this);
        }

        private void checkBoxCorporateGuest_CheckedChanged(object sender, System.EventArgs e)
        {
            presenter.SetCorporateGuest(checkBoxCorporateGuest, textBoxVatNumber);
        }

        #endregion
    }
}
