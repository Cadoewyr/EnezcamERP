using System.Diagnostics;
using Windows.Media.Capture;

namespace EnezcamERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
                return;

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}