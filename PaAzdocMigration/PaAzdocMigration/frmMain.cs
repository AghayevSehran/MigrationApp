using PaAzdocMigration.Models;
using PaAzdocMigration.Presenters;
using PaAzdocMigration.Repositories;
using PaAzdocMigration.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaAzdocMigration
{
    public partial class frmMain : Form, IMainView
    {

        public event EventHandler ShowMigrationSettingsView;
        public event EventHandler OpenMigrations;

        public frmMain()
        {
            InitializeComponent();
            this.migrationSettingToolStripMenuItem.Click += delegate { ShowMigrationSettingsView?.Invoke(this, EventArgs.Empty); };
            this.copyFromSourceToTargetToolStripMenuItem.Click += delegate { OpenMigrations?.Invoke(this, EventArgs.Empty); };
        }    
    }
}
