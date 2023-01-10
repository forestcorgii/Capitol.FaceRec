using Capitol.FaceRecApp.FrontEnd.Persistence;
using Capitol.FaceRecApp.FrontEnd.Services;
using Capitol.FaceRecApp.FrontEnd.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Capitol.FaceRecApp.FrontEnd
{
    public static class Program
    {
        public static VerilookManagerFactory VerilookFactory;
        public static TimelogDbManager TimelogDbManager;
        public static AdministratorDbManager AdministratorDbManager;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            VerilookFactory = new VerilookManagerFactory(configurationRoot.GetConnectionString("default_dsn"), "subjects");

            string connectionString = configurationRoot.GetConnectionString("default");

            AdministratorDbManager = new AdministratorDbManager(connectionString);
            TimelogDbManager = new TimelogDbManager(connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (AdministratorDbManager.GetAdministratorCount() == 0)
                new AdministratorView().ShowDialog();

            MainView mainView = new MainView()
            {
                Text = $"Capitol FaceRec Attendance v{Application.ProductVersion}"
            };

            Application.Run(mainView);
        }
    }
}
