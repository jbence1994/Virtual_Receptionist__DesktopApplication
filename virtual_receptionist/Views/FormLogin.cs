using System;
using System.Windows.Forms;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Alkalmazás bejelentkező ablaka
    /// </summary>
    public partial class FormLogin : Form
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás bejelentkező ablak konstruktora
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region UI események

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxAccomodationID.Select();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            EnterApplication();
        }

        private void buttonLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterApplication();
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely megnyitja az alkalmazás főmenüjét, a bejelentkezés ablakot pedig bezárja
        /// </summary>
        private void EnterApplication()
        {
            Hide();
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();
        }

        #endregion
    }
}
