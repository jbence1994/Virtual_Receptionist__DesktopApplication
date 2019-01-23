using System;
using System.Windows.Forms;
using virtual_receptionist.View;

namespace virtual_receptionist
{
    static class Program
    {
        private static int a = 0;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (a > 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormGuestRegistrationCard());
            }
        }
    }
}
