using PaAzdocMigration.Models;
using PaAzdocMigration.Repositories;
using PaAzdocMigration.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaAzdocMigration.Presenters
{
    public class MigrationSettingPresenter
    {
        private IMigrationSettingsView view;
        private IMigrationSettingsRepository repository;
        private IMigrationRepository migrationRepository;
        private BindingSource migrationsBindingSource;
        private BindingSource dialogBindingSource;
        private IEnumerable<MigrationSetting> migrationList;

        public MigrationSettingPresenter(IMigrationSettingsView view, IMigrationSettingsRepository repository, IMigrationRepository migrationRepository)
        {
            this.migrationsBindingSource = new BindingSource();
            this.dialogBindingSource = new BindingSource();
            this.migrationRepository = migrationRepository;
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchMigrationSetting;
            this.view.AddNewEvent += AddNewMigrationSetting;
            this.view.EditEvent += LoadSelectedMigrationSettingToEdit;
            this.view.GetAllEvent += View_GetAllEvent; ;
            this.view.DeleteEvent += DeleteSelectedMigrationSetting;
            this.view.SaveEvent += SaveMigrationSetting;
            this.view.CancelEvent += CancelAction;
            this.view.SetMigrationSettingsListBindingSource(migrationsBindingSource);
            this.view.GetSourceTables += View_GetSourceTables;
            this.view.GetSourceTableColumns += View_GetSourceTableColumns;
            this.view.GetTargetTables += View_GetTargetTables;
            this.view.GetTargetTableColumns += View_GetTargetTableColumns;
            LoadAllMigrationSettingsList();
            this.view.Show();
        }

        private void View_GetTargetTableColumns(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.TargetTableName);
            if (!emptyValue)
            {
                dialogBindingSource.DataSource = migrationRepository.GetTargetTableColumnsByTargetTableForGrid(this.view.TargetTableName);
                view.ShowDialogForm(dialogBindingSource);
                var data = (DisplayMemberModel)dialogBindingSource.Current;
                view.TargetColumnName = data.Value;
            }
            else
                view.Message = "Target table is not defined";
        }

        private void View_GetTargetTables(object sender, EventArgs e)
        {
            dialogBindingSource.DataSource = migrationRepository.GetTargetTablesForGrid();
            view.ShowDialogForm(dialogBindingSource);
            var data = (DisplayMemberModel)dialogBindingSource.Current;
            view.TargetTableName = data.Value;
        }

        private void View_GetSourceTableColumns(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SourceTableName);
            if (!emptyValue)
            {
                dialogBindingSource.DataSource = migrationRepository.GetSourceTableColumnsBySourceTableForGrid(this.view.SourceTableName);
                view.ShowDialogForm(dialogBindingSource);
                var data = (DisplayMemberModel)dialogBindingSource.Current;
                view.SourceColumnName = data.Value;
            }
            else
                view.Message = "Source table is not defined";
        }

        private void View_GetSourceTables(object sender, EventArgs e)
        {
            dialogBindingSource.DataSource = migrationRepository.GetSourceTablesForGrid();
            view.ShowDialogForm(dialogBindingSource);
            var data = (DisplayMemberModel)dialogBindingSource.Current;
            view.SourceTableName = data.Value;
        }

        private void View_GetAllEvent(object sender, EventArgs e)
        {
            LoadAllMigrationSettingsList();
        }

        private void LoadAllMigrationSettingsList()
        {
            migrationList = repository.GetAll();
            migrationsBindingSource.DataSource = migrationList;
        }

        private void SearchMigrationSetting(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchSourceTableName);
            if (emptyValue == false)
                migrationList = repository.GetBySourceTableValue(this.view.SearchSourceTableName);
            else migrationList = repository.GetAll();
            migrationsBindingSource.DataSource = migrationList;
        }

        private void AddNewMigrationSetting(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectedMigrationSettingToEdit(object sender, EventArgs e)
        {
            var migration = (MigrationSetting)migrationsBindingSource.Current;
            view.Id = migration.Id;
            view.SourceTableName = migration.SourceTableName;
            view.TargetTableName = migration.TargetTableName;
            view.SourceColumnName = migration.SourceColumnName;
            view.TargetColumnName = migration.TargetColumnName;
            view.ColumnIndex = migration.ColumnIndex;
            view.IsEdit = true;
        }

        private void SaveMigrationSetting(object sender, EventArgs e)
        {
            var model = new MigrationSetting();
            model.Id = view.Id;
            model.SourceTableName = view.SourceTableName;
            model.TargetTableName = view.TargetTableName;
            model.SourceColumnName = view.SourceColumnName;
            model.TargetColumnName = view.TargetColumnName;
            model.ColumnIndex = view.ColumnIndex;
            model.Status = view.Status;
            model.MigrationName = view.MigrationName;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Migration setting edited successfuly";
                }
                else 
                {
                    repository.Add(model);
                    view.Message = "Migration setting added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllMigrationSettingsList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.Id = 0;
            view.SourceTableName = "";
            view.TargetTableName = "";
            view.SourceColumnName = "";
            view.TargetColumnName = "";
            view.ColumnIndex = 0;
            view.Status = 0;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void DeleteSelectedMigrationSetting(object sender, EventArgs e)
        {
            try
            {
                var setting = (MigrationSetting)migrationsBindingSource.Current;
                repository.Delete(setting.Id);
                view.IsSuccessful = true;
                view.Message = "Migration setting deleted successfully";
                LoadAllMigrationSettingsList();
            }
            catch 
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Migration setting";
            }
        }
    }
}
