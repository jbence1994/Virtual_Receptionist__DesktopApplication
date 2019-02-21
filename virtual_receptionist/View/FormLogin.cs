using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;
using virtual_receptionist.Exceptions;

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
            presenter = new LoginPresenter(this);
        }

        #endregion

        #region UI események

        private void FormApplicationOpening_Load(object sender, EventArgs e)
        {
            textBoxAccomodationID.Select();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string accomodationID = textBoxAccomodationID.Text;
            string password = textBoxPassword.Text;
            string connectionType = comboBoxConnectionType.Text;

            try
            {
                presenter.EnterApplication(accomodationID, password, connectionType);
            }
            catch (FailedLoginException exception)
            {
                MessageBox.Show(exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion
    }
}
