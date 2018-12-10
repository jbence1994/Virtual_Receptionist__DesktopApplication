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
        private void LocalServerPathFromTxt()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely beállítja a távoli adatbázis elérési útvonalát szöveges állományból
        /// </summary>
        private void RemoteServerPathFromTxt()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely beállítja a helyi adatbázis elérési útvonalát XML állományból
        /// </summary>
        private void LocalServerPathFromXML()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metódus, amely beállítja a távoli adatbázis elérési útvonalát XML állományból
        /// </summary>
        private void RemoteServerPathFromXML()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
