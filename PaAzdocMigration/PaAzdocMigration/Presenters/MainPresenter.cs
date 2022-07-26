using PaAzdocMigration.Models;
using PaAzdocMigration.Repositories;
using PaAzdocMigration.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaAzdocMigration.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqliteConnectionString;
        private readonly string sourceConnectionString;
        private readonly string targetConnectionString;

        public MainPresenter(IMainView mainView, string sqliteConnectionString, string sourceConnectionString, string targetConnectionString)
        {
            this.mainView = mainView;
            this.sqliteConnectionString = sqliteConnectionString;
            this.sourceConnectionString = sourceConnectionString;
            this.targetConnectionString = targetConnectionString;
            this.mainView.ShowMigrationSettingsView += MainView_ShowMigrationSettingsView; ;
            this.mainView.OpenMigrations += MainView_OpenMigrations;
        }

        private void MainView_OpenMigrations(object sender, EventArgs e)
        {
            IMigrationView view = new frmMigration().GetInstace((frmMain)mainView);
            IMigrationSettingsRepository repositorySettings = new MigrationSettingRepository(sqliteConnectionString, sourceConnectionString, targetConnectionString);
            IMigrationRepository repository = new MigrationRepository(sqliteConnectionString, sourceConnectionString, targetConnectionString, repositorySettings);
            new MigrationPresenter(view, repository);
        }

        private void MainView_ShowMigrationSettingsView(object sender, EventArgs e)
        {
            IMigrationSettingsView view = new frmMigrationSetting().GetInstace((frmMain)mainView);
            IMigrationSettingsRepository repository = new MigrationSettingRepository(sqliteConnectionString,sourceConnectionString,targetConnectionString);
            IMigrationRepository migrationRepository = new MigrationRepository(sqliteConnectionString, sourceConnectionString, targetConnectionString, repository);
            new MigrationSettingPresenter(view, repository, migrationRepository);
        }
              
    }
}
