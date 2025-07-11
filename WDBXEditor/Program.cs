using System;
using System.Windows.Forms;

namespace WDBXEditor
{
    internal static class Program
    {
        public static bool PrimaryInstance = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UpdateManager.Clean();

            Application.Run(new Main());
        }
    }
}
