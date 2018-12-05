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
    /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak
    /// </summary>
    public partial class FormModalBilling : Form
    {
        DataStoreage dataStoreage = new DataStoreage("localhost", "virtual_receptionist", "",  "root", "", "3306");




        #region Konstruktor

        /// <summary>
        /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak konstruktora
        /// </summary>
        public FormModalBilling()
        {
            InitializeComponent();
        }

        #endregion
    }
}
