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
            if (checkBoxIsCompany.Checked)
            {
                return;
            }

            textBoxBillingName.Text = textBoxGuestName.Text;
        }

        private void textBoxGuestZipCode_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxIsCompany.Checked)
            {
                return;
            }

            textBoxGuestZipCode.Text = textBoxHeadquarterZipCode.Text;
        }

        private void textBoxGuestCity_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxIsCompany.Checked)
            {
                return;
            }

            textBoxGuestCity.Text = textBoxHeadquarterCity.Text;
        }

        private void textBoxGuestAddress_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxIsCompany.Checked)
            {
                return;
            }

            textBoxGuestAddress.Text = labelHeadquarterAddress.Text;
        }

        private void checkBoxIsCompany_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBillingName.Clear();
            textBoxBillingName.Enabled = checkBoxIsCompany.Checked;

            comboBoxHeadquarterCountry.Enabled = checkBoxIsCompany.Checked;
            comboBoxHeadquarterCountry.DataSource = null;
            comboBoxHeadquarterCountry.DataSource = presenter.GetCountries();

            textBoxHeadquarterZipCode.Clear();
            textBoxHeadquarterZipCode.Enabled = checkBoxIsCompany.Checked;

            textBoxHeadquarterCity.Clear();
            textBoxHeadquarterCity.Enabled = checkBoxIsCompany.Checked;

            textBoxHeadquarterAddress.Clear();
            textBoxHeadquarterAddress.Enabled = checkBoxIsCompany.Checked;

            labelCompanyPhoneNumber.Visible = checkBoxIsCompany.Checked;
            textBoxCompanyPhoneNumber.Visible = checkBoxIsCompany.Checked;

            labelCompanyEmailAddress.Visible = checkBoxIsCompany.Checked;
            textBoxCompanyEmailAddress.Visible = checkBoxIsCompany.Checked;

            labelVATNumber.Visible = checkBoxIsCompany.Checked;
            textBoxCompanyVATNumber.Visible = checkBoxIsCompany.Checked;
        }
    }
}
