using System;
using System.Windows.Forms;
using virtual_receptionist.View;

namespace virtual_receptionist
{
    public static class Program
    {
        /// <summary>
        /// Az alkalmazás belépési pontja
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormOpening());
        }
    }
}
