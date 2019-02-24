using System;
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
        private RegistrationCardPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég bejelentkező lap ablak konstruktora
        /// </summary>
        public FormGuestRegistrationCard()
        {
            InitializeComponent();
            presenter = new RegistrationCardPresenter();
        }

        #endregion

        #region UI események

        private void FormGuestRegistrationCard_Load(object sender, EventArgs e)
        {
            comboBoxCountry.DataSource = presenter.GetCountries();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxCorporateGuest_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVatNumber.ReadOnly = !checkBoxCorporateGuest.Checked;

            if (textBoxVatNumber.ReadOnly)
            {
                textBoxVatNumber.Clear();
            }
        }

        #endregion
    }
}
