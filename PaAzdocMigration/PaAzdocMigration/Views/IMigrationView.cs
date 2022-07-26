using PaAzdocMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaAzdocMigration.Views
{
    public interface IMigrationView
    {
        //Properties - Fields
        string SourceTableName { get; }
        string MigrationName { get; }
        bool TurnOffTargetAutoIncrement { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        IEnumerable<ValueDisplayText> SourceTables { get; set; }
        IEnumerable<ValueDisplayText> MigrationNames { get; set; }

        //Events
        event EventHandler SourceTableDataEvent;
        event EventHandler LoadSourceTablesEvent;
        event EventHandler GetAllEvent;
        event EventHandler AddNewEvent;

        //Methods
        void SetSourceTableDataBindingSource(BindingSource bindingSource);
       // void SetSourceTablesBindingSource(BindingSource bindingSource);
        void Show();//Optional

        void UpdateProgress(int progress);
        void SetMaximumProgress(int progressMax);

    }
}
