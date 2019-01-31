using System;
using System.Windows.Forms;
using virtual_receptionist.MySQL_ORM;
using virtual_receptionist.View;

namespace virtual_receptionist
{
    public static class Program
    {
        /// <summary>
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke ORM osztály egy példánya
        /// </summary>
        private static Database database;

        /// <summary>
        /// Statikus konstruktor
        /// </summary>
        static Program()
        {
            database = Database.DatabaseInstance;
        }

        /// <summary>
        /// Az alkalmazás belépési pontja
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!database.OpenConnection())
            {
                MessageBox.Show("Adatbázis kapcsolódás hiba!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());
            }
        }
    }
}
