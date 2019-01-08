using System;
using System.Windows.Forms;
using virtual_receptionist.Controller;

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
            Input inputAccomodationID = new Input(textBoxAccomodationID.Text);
            Input inputPassword = new Input(textBoxPassword.Text);
            Input inputConnectionType = new Input(comboBoxConnectionType.Text);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
