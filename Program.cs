using System;
using System.Windows.Forms;

namespace Menu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ensure proper disposal of resources
            using (var menuWindow = new MenuWindow())
            {
                Application.Run(menuWindow);
            }
        }
    }
}

