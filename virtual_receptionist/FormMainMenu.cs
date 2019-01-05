using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virtual_receptionist
{
    /// <summary>
    /// Főmenü ablak
    /// </summary>
    public partial class FormMainMenu : Form
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak konstruktora
        /// </summary>
        public FormMainMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region UI események

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelClient.Text += DataStore.Client;
            Text += $"{DataStore.Accomodation.Company} ({DataStore.Accomodation.VatNumber})";
        }

        private void toolStripMenuItemRoomEditor_Click(object sender, EventArgs e)
        {
            FormRoomEditor formRoomEditor = new FormRoomEditor(this);
            formRoomEditor.ShowDialog();
        }

        private void toolStripMenuItemGuestDatabase_Click(object sender, EventArgs e)
        {
            FormGuestDatabase formGuestDatabase = new FormGuestDatabase(this);
            formGuestDatabase.ShowDialog();
        }

        private void toolStripMenuItemBilling_Click(object sender, EventArgs e)
        {
            FormBilling formBilling = new FormBilling(this);
            formBilling.ShowDialog();
        }

        private void toolStripMenuItemHelpCHM_Click(object sender, EventArgs e)
        {
            // CHM
        }

        private void toolStripMenuItemAboutUs_Click(object sender, EventArgs e)
        {
            FormAboutUs formAboutUs = new FormAboutUs();
            formAboutUs.ShowDialog();
        }

        private void toolStripMenuItemHelpCHM_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Segítség";
        }

        private void toolStripMenuItemHelpCHM_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemAboutUs_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Névjegy";
        }

        private void toolStripMenuItemAboutUs_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemRoomEditor_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Szobakiadások és foglalások";
        }

        private void toolStripMenuItemRoomEditor_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemGuestDatabase_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Vendégadatbázis";
        }

        private void toolStripMenuItemGuestDatabase_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemBilling_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Számlázás";
        }

        private void toolStripMenuItemBilling_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        private void toolStripMenuItemHelp_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = "Súgó";
        }

        private void toolStripMenuItemHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuName.Text = string.Empty;
        }

        #endregion
    }
}
