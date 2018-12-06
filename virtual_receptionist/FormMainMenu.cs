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

        private void buttonRoomEditor_Click(object sender, EventArgs e)
        {
            FormRoomEditor formRoomEditor = new FormRoomEditor(this);
            formRoomEditor.Show();
            Hide();
        }

        private void buttonGuestDatabase_Click(object sender, EventArgs e)
        {
            FormGuestDatabase formGuestDatabase = new FormGuestDatabase(this);
            formGuestDatabase.Show();
            Hide();
        }

        private void buttonBilling_Click(object sender, EventArgs e)
        {
            FormBilling formBilling = new FormBilling(this);
            formBilling.Show();
            Hide();
        }

        #endregion
    }
}
