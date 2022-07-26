using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaAzdocMigration.Views
{
    public interface IMigrationSettingsView
    {
        //Properties - Fields
        int Id { get; set; }
        string SourceTableName { get; set; }
        string SearchSourceTableName { get; set; }
        string TargetTableName { get; set; }
        string SourceColumnName { get; set; }
        string TargetColumnName { get; set; }
        int ColumnIndex { get; set; }
        string MigrationName { get; set; }
        int Status { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler GetAllEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler GetSourceTables;
        event EventHandler GetSourceTableColumns;
        event EventHandler GetTargetTables;
        event EventHandler GetTargetTableColumns;

        //Methods
        void SetMigrationSettingsListBindingSource(BindingSource bindingSource);
        void Show();//Optional
        void ShowDialogForm(BindingSource bindingSource);
    }
}
