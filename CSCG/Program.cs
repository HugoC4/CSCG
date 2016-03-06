using System;
using System.Windows.Forms;
using CSCG.Forms;
using CSCG.Models;

namespace CSCG
{
    static class Program
    {
        public static StartMenu StartMenu { get; set; }
        public static Project Project { get; set; }

        public static CSCGContext Db { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Db = new CSCGContext();
            StartMenu = new StartMenu();
            Application.Run(StartMenu);
        }

        public static void Exit()
        {
            // Close DB connections
            // Stops Threads
            Db.Dispose();
            Application.Exit();
        }
    }
}
