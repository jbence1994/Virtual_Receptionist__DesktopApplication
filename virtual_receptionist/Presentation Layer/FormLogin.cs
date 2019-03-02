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
            controller = new Controller(this);
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
                controller.EnterApplication(accomodationID, password, connectionType);
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
