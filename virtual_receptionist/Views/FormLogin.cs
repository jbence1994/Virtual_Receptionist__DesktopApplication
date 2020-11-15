using System;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Alkalmazás bejelentkező ablaka
    /// </summary>
    public partial class FormLogin : Form
    {
        #region Adattagok

        /// <summary>
        /// Autentikáció vezérlő egy példánya
        /// </summary>
        private LoginController controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás bejelentkező ablak konstruktora
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            controller = new LoginController();
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

            try
            {
                bool validLogin = controller.EnterApplication(accomodationID, password);

                if (validLogin)
                {
                    Hide();
                    FormMainMenu formMainMenu = new FormMainMenu(this);
                    formMainMenu.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
