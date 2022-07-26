using PaAzdocMigration.Models;
using PaAzdocMigration.Repositories;
using PaAzdocMigration.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaAzdocMigration.Presenters
{
    public class MigrationPresenter
    {
        private IMigrationView view;
        private IMigrationRepository repository;
        private BindingSource sourceTableDataBindingSource;
        private BindingSource sourceTablesBindingSource;
        private DataTable sourceDataTable;
        private Migration migration;
        public MigrationPresenter(IMigrationView view, IMigrationRepository repository)
        {
            sourceTableDataBindingSource = new BindingSource();
            sourceTablesBindingSource = new BindingSource();
            migration = new Migration();
            this.view = view;
            migration.SourceTable = view.SourceTableName;
            migration.MigrationName = view.MigrationName;
            migration.TurnOffTargetAutoIncrement = view.TurnOffTargetAutoIncrement;
            this.repository = repository;
            this.view.SourceTableDataEvent += View_SourceTableEvent;
            this.view.LoadSourceTablesEvent += View_LoadSourceTablesEvent;
            this.view.AddNewEvent += View_AddNewEvent;
            this.view.SetSourceTableDataBindingSource(sourceTableDataBindingSource);
            LoadSourceTables();
            this.view.Show();
        }

        private void View_AddNewEvent(object sender, EventArgs e)
        {
            var dataTable = (DataTable)sourceTableDataBindingSource.DataSource;
            this.view.SetMaximumProgress(dataTable.Rows.Count-1);
            foreach (var id in repository.Add(dataTable, view.SourceTableName, view.MigrationName, view.TurnOffTargetAutoIncrement))
            {               
                this.view.UpdateProgress(id);
            }
            
        }

        private void View_LoadSourceTablesEvent(object sender, EventArgs e)
        {
            sourceTablesBindingSource.DataSource = repository.GetSourceTables();
        }

        private void LoadSourceTables()
        {
            //  sourceTablesBindingSource.DataSource = repository.GetSourceTables();
            this.view.SourceTables = repository.GetSourceTables();
            this.view.MigrationNames = repository.GetMigrationNames();
        }

        private void View_SourceTableEvent(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SourceTableName);
            if (!emptyValue)
            {
                sourceTableDataBindingSource.DataSource = repository.GetSourceTableData(this.view.SourceTableName);
            }
        }
    }
}
