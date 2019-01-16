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

        /// <summary>
        /// Főmenü ablak egy példánya
        /// </summary>
        private FormMainMenu formMainMenu;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás bejelentkező ablak konstruktora
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            formMainMenu = new FormMainMenu(this);
        }

        #endregion

        #region UI események

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxAccomodationID.Select();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Hide();
            formMainMenu.Show();
        }

        private void buttonLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        #endregion
    }
}
