using System;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace virtual_receptionist
{
    /// <summary>
    /// Adatbázis konfigurációra szolgáló ablak
    /// </summary>
    public partial class FormDatabaseConfiguration : Form
    {
        #region Adattagok

        /// <summary>
        /// XmlTextReader osztály egy példánya
        /// </summary>
        private XmlTextReader xmlTextReader;
        /// <summary>
        /// StreamReader osztály egy példánya
        /// </summary>
        private StreamReader streamReader;
        /// <summary>
        /// Adattár osztály egy példánya
        /// </summary>
        private DataStore dataStore;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adatbázis konfigurációra szolgáló ablak konstruktora
        /// </summary>
        public FormDatabaseConfiguration()
        {
            InitializeComponent();
            xmlTextReader = new XmlTextReader("dbconfig.xml");
            streamReader = new StreamReader("dbconfig.txt");
        }

        #endregion

        #region UI események

        private void comboBoxConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxConnectionType.SelectedItem)
            {
                case "Helyi":
                    buttonConnect.Enabled = true;
                    dataStore = SetLocalDatabasePathFromTxt();
                    break;
                case "Távoli":
                    buttonConnect.Enabled = true;
                    dataStore = SetRemoteDatabasePathFromTxt();
                    break;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely beállítja a helyi adatbázis elérési útvonalát szöveges állományból
        /// </summary>
        private DataStore SetLocalDatabasePathFromTxt()
        {
            DataStore initPath = null;

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                try
                {
                    string[] configuration = line.Split(';');
                    string server = configuration[0];
                    string database = configuration[1];
                    string username = configuration[2];
                    string password = configuration[3];
                    string port = configuration[4];

                    textBoxServer.Text = server;
                    textBoxDatabase.Text = database;
                    textBoxUsername.Text = username;
                    textBoxPassword.Text = password;
                    textBoxPort.Text = port;

                    initPath = new DataStore(server, database, username, password, port);
                }
                catch (IOException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            return initPath;
        }
        /// <summary>
        /// Metódus, amely beállítja a távoli adatbázis elérési útvonalát szöveges állományból
        /// </summary>
        private DataStore SetRemoteDatabasePathFromTxt()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely beállítja a helyi adatbázis elérési útvonalát XML állományból
        /// </summary>
        private DataStore SetLocalDatabasePathFromXML()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely beállítja a távoli adatbázis elérési útvonalát XML állományból
        /// </summary>
        private DataStore SetRemoteDatabasePathFromXML()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
