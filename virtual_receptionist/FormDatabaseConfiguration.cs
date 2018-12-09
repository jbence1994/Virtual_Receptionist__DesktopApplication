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
                    SetLocalDatabasePathFromTxt();
                    buttonConnect.Enabled = true;
                    break;
                case "Távoli":
                    buttonConnect.Enabled = true;
                    break;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely beállítja a helyi adatbázis elérési útvonalát szöveges állományból
        /// </summary>
        private void SetLocalDatabasePathFromTxt()
        {
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                try
                {
                    string[] config = line.Split(';');
                    textBoxServer.Text = config[0];
                    textBoxDatabase.Text = config[1];
                    textBoxUsername.Text = config[2];
                    textBoxPassword.Text = config[3];
                    textBoxPort.Text = config[4];
                }
                catch (IOException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        /// <summary>
        /// Metódus, amely beállítja a távoli adatbázis elérési útvonalát szöveges állományból
        /// </summary>
        private void SetRemoteDatabasePathFromTxt()
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
