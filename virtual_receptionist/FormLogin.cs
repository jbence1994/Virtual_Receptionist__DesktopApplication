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
            dataStore = new DataStore();
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
            switch (comboBoxConnectionType.Text) //Ez metódus legyen!!! GUI-kódon ne legyen logika
            {
                case "local.xml":
                    dataStore.GetLocalDatabaseServerPathFromXML();
                    break;

                case "local.txt":
                    dataStore.GetLocalDatabaseServerPathFromTxt();
                    break;

                case "remote.xml":
                    dataStore.GetRemoteDatabaseServerPathFromXML();
                    break;

                case "remote.txt":
                    dataStore.GetRemoteDatabaseServerPathFromTxt();
                    break;
            }
        }

        #endregion
    }
}
