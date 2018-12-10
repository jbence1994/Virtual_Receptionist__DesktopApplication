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
            DataStore path = null;

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                try
                {
                    string[] configuration = line.Split(';');
                    textBoxServer.Text = configuration[0];
                    textBoxDatabase.Text = configuration[1];
                    textBoxUsername.Text = configuration[2];
                    textBoxPassword.Text = configuration[3];
                    textBoxPort.Text = configuration[4];

                    path = new DataStore(configuration[0], configuration[1], configuration[2], configuration[3], configuration[4]);
                }
                catch (IOException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            return path;
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
        private void SetLocalDatabasePathFromXML()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely beállítja a távoli adatbázis elérési útvonalát XML állományból
        /// </summary>
        private void SetRemoteDatabasePathFromXML()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
