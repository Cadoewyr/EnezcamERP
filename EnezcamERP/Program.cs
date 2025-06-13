using EnezcamERP.Validators;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

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

            if (!CheckDatabaseConnection())
            {
                MessageBox.Show("Veritabanýna baðlanýlamadý. Uygulama kapatýlýyor.", "Baðlantý Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }

        private static bool CheckDatabaseConnection()
        {
            try
            {
                IConfiguration _config;

                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                _config = builder.Build();

                using(SqlConnection conn = new SqlConnection(_config["ConnectionStrings:DefaultConnection"]))
                {
                    conn.Open();
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Veritabaný baðlantý hatasý: " + ex.Message);
                return false;
            }
        }
    }
}