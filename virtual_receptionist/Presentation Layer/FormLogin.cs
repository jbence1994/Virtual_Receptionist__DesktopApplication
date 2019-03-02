using System;
using System.Windows.Forms;
using virtual_receptionist.ApplicationLayer;

namespace virtual_receptionist.PresentationLayer
{
    /// <summary>
    /// Alkalmazás bejelentkező ablaka
    /// </summary>
    public partial class FormLogin : Form
    {
        #region Adattagok

        /// <summary>
        /// Alkalmazás vezérlő egy példánya
        /// </summary>
        private Controller controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás bejelentkező ablak konstruktora
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            controller = new Controller();
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
                bool login = controller.EnterApplication(accomodationID, password, connectionType);

                if (login)
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
            Environment.Exit(0);
        }

        #endregion
    }
}
