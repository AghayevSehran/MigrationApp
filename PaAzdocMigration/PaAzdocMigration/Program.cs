using PaAzdocMigration.Presenters;
using PaAzdocMigration.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaAzdocMigration
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
            string sqliteConnectionString = ConfigurationManager.ConnectionStrings["SqliteSettingsConnection"].ConnectionString;
            string sqlSourceConnectionString = ConfigurationManager.ConnectionStrings["SourceSqlConnection"].ConnectionString;
            string sqlTargetConnectionString = ConfigurationManager.ConnectionStrings["TargetSqlConnection"].ConnectionString;
            IMainView view = new frmMain();
            new MainPresenter(view, sqliteConnectionString, sqlSourceConnectionString, sqlTargetConnectionString);
            Application.Run((Form)view);
        }
    }
}
