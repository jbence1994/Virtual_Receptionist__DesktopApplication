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
            comboBoxGuestCountry.DataSource = presenter.GetCountries();
            comboBoxHeadquarterCountry.DataSource = presenter.GetCountries();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void textBoxGuestName_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxIsCompany.Checked)
            {
                textBoxBillingName.Text = textBoxGuestName.Text;
            }
        }

        private void textBoxGuestZipCode_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxIsCompany.Checked)
            {
                textBoxGuestZipCode.Text = textBoxHeadquarterZipCode.Text;
            }
        }

        private void textBoxGuestCity_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxIsCompany.Checked)
            {
                textBoxGuestCity.Text = textBoxHeadquarterCity.Text;
            }
        }

        private void textBoxGuestAddress_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxIsCompany.Checked)
            {
                textBoxGuestAddress.Text = labelHeadquarterAddress.Text;
            }
        }

        private void checkBoxIsCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsCompany.Checked)
            {
                textBoxBillingName.Clear();
                comboBoxHeadquarterCountry.DataSource = null;
                comboBoxHeadquarterCountry.DataSource = presenter.GetCountries();
                textBoxHeadquarterZipCode.Clear();
                textBoxHeadquarterCity.Clear();
                textBoxHeadquarterAddress.Clear();
                textBoxCompanyPhoneNumber.Visible = true;
                textBoxCompanyEmailAddress.Visible = true;
                textBoxCompanyVATNumber.Visible = true;
            }
        }
    }
}
