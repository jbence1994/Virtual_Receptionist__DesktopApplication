using System.Windows.Forms;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Vendégadatbázis-kezelő ablak új vendég felvételéhez vagy meglévő módosításához szükséges modális ablak
    /// </summary>
    public partial class FormModalGuestDatabase : Form
    {
        #region Adattagok

        /// <summary>
        /// Guest objektum
        /// </summary>
        Model.Guest guest;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő ablak új vendég felvételéhez vagy meglévő módosításához szükséges modális ablak konstruktora
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public FormModalGuestDatabase(Model.Guest guest)
        {
            InitializeComponent();
            this.guest = guest;

            textBoxName.Text = guest.Name;
            comboBoxCountry.Text = guest.Country;
            textBoxZipCode.Text = guest.ZipCode;
            textBoxCity.Text = guest.City;
            textBoxAddress.Text = guest.Address;
            textBoxPhoneNumber.Text = guest.PhoneNumber;
            textBoxEmailAddress.Text = guest.EmailAddress;

            if (guest.Nationality == "belföldi")
            {
                radioButtonNational.Checked = true;
                radioButtonForeign.Checked = false;
            }
            else if (guest.Nationality == "külföldi")
            {
                radioButtonForeign.Checked = true;
                radioButtonNational.Checked = false;
            }
            else
            {
                radioButtonForeign.Checked = false;
                radioButtonNational.Checked = false;
            }

            if (checkBoxCorporateGuest.Checked)
            {
                textBoxVatNumber.Text = guest.VatNumber;
            }
        }

        #endregion

        #region UI események

        private void FormModalGuestDatabase_Load(object sender, System.EventArgs e)
        {
            Model.DataRepository dataRepository = new Model.DataRepository();
            comboBoxCountry.DataSource = dataRepository.GetCountries();
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            guest.Name = textBoxName.Text;
            guest.Country = comboBoxCountry.Text;
            guest.ZipCode = textBoxZipCode.Text;
            guest.City = textBoxCity.Text;
            guest.Address = textBoxAddress.Text;
            guest.PhoneNumber = textBoxPhoneNumber.Text;
            guest.EmailAddress = textBoxEmailAddress.Text;

            if (radioButtonNational.Checked)
            {
                guest.Nationality = "belföldi";
            }
            else if (radioButtonForeign.Checked)
            {
                guest.Nationality = "külföldi";
            }

            if (checkBoxCorporateGuest.Checked)
            {
                guest.VatNumber = textBoxVatNumber.Text;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Guest objektum
        /// </summary>
        public Model.Guest Guest
        {
            get { return guest; }
        }

        #endregion
    }
}
