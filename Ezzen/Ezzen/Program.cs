using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ezzen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        private static MainWindow mW;
        public static MainWindow MW { get => mW; set => mW = value; }
        private static ClientSocket cs = new ClientSocket();
        private static bool isAlwaysLogin = false;
        private static string ipaddress = "35.185.224.125";

        //getters & setters
        public static bool IsAlwaysLogin { get => isAlwaysLogin; set => isAlwaysLogin = value; }
        public static ClientSocket CS { get => cs;}
        public static string IPaddress { get => ipaddress;}

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MW = new MainWindow();

            Application.Run(MW);
            CS.disconnect();
        }
    }
}
