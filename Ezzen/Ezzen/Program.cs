﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Ezzen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        private static MainWindow mW;
        private static bool isAlwaysLogin = false;
        private static string ipaddress = "104.199.115.20";
        private static string ipaddress_res = "35.185.224.125";
        //private static List<ChatGroup> groupList = new List<ChatGroup>();
        private static Dictionary<string, ChatGroup> groupList = new Dictionary<string, ChatGroup>();
        //getters & setters
        public static MainWindow MW { get => mW;}
        public static bool IsAlwaysLogin { get => isAlwaysLogin; set => isAlwaysLogin = value; }
        public static string IPaddress { get => ipaddress;}
        public static string IPaddress_res { get => ipaddress_res;}
        public static Dictionary<string, ChatGroup> GroupList { get => groupList; set => groupList = value; }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mW = new MainWindow();
            //for (int i = 0; i < 100000000; i++) ;
            Application.Run(MW);
        }
    }
}
