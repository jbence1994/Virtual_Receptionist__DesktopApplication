using virtual_receptionist.Presenter;
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
        /// 
        /// </summary>
        private ModalGuestDatabasePresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő ablak új vendég felvételéhez vagy meglévő módosításához szükséges modális ablak konstruktora
        /// </summary>
        /// <param name="guest">Guest objektum</param>
        public FormModalGuestDatabase(Model.Guest guest)
        {
            InitializeComponent();
            presenter = new ModalGuestDatabasePresenter(guest);
        }

        /*

        
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
            }*/

        #endregion

        #region UI események

        private void FormModalGuestDatabase_Load(object sender, System.EventArgs e)
        {
            presenter.InitializeComboBoxWithCountryList(comboBoxCountry);
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            presenter.ReturnInpit();
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
