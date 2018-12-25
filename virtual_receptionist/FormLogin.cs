using System;
using System.Windows.Forms;

namespace virtual_receptionist
{
    /// <summary>
    /// Alkalmazás bejelentkező ablaka
    /// </summary>
    public partial class FormLogin : Form
    {
        #region Adattagok

        /// <summary>
        /// Felhasználó által bevitt szálláshely azonosító
        /// </summary>
        private Input inputAccomodationID;
        /// <summary>
        /// Felhasználó által bevitt jelszó
        /// </summary>
        private Input inputPassword;
        /// <summary>
        /// Felhasználó által kiválaszott csatlakozási típus
        /// </summary>
        private Input inputConnectionType;
        /// <summary>
        /// Adattár osztály egy példánya
        /// </summary>
        private DataStore dataStore;

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

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
