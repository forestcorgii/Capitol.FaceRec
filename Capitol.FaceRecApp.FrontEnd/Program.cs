using Capitol.FaceRecApp.FrontEnd.Persistence;
using Capitol.FaceRecApp.FrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitol.FaceRecApp.FrontEnd
{
    public static class Program
    {
        public static VerilookManagerFactory VerilookFactory;
        public static TimelogDbManager TimelogDbManager;
        public static UserDbManager UserDbManager;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VerilookFactory = new VerilookManagerFactory("DSN=mysql_dsn;UID=root;PWD=Soft1234", "subjects");

            string connectionString = "Server=localhost;Database=capitol_facerec;Uid=root;Pwd=Soft1234;";
            UserDbManager = new UserDbManager(connectionString);
            TimelogDbManager = new TimelogDbManager(connectionString);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
