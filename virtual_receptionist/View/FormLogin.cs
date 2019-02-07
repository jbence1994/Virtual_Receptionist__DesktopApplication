using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Alkalmazás bejelentkező ablaka
    /// </summary>
    public partial class FormLogin : Form
    {
        #region Adattagok

        /// <summary>
        /// Bejelentkező ablak prezenter egy példánya
        /// </summary>
        private LoginPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás bejelentkező ablak konstruktora
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this, textBoxAccomodationID);
        }

        #endregion

        #region UI események

        private void FormLogin_Load(object sender, EventArgs e)
        {
            presenter.SetLogin();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            presenter.EnterApplication(textBoxAccomodationID.Text, textBoxPassword.Text, comboBoxConnectionType.Text);
        }

        #endregion
    }
}
