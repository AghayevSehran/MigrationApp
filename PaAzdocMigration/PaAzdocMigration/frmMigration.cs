using PaAzdocMigration.Models;
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
    public partial class frmMigration : Form, IMigrationView
    {
        public frmMigration()
        {
            InitializeComponent();      
            
            cmbSourceTable.SelectedValueChanged += delegate {
                SourceTableDataEvent?.Invoke(this, EventArgs.Empty);
            }; 
            btnCopy.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
            };


        }
        
        public string SourceTableName { get => cmbSourceTable?.SelectedValue?.ToString(); }
        public bool TurnOffTargetAutoIncrement { get => chckTurnOff.Checked; set => chckTurnOff.Checked = value; }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public IEnumerable<ValueDisplayText> SourceTables { get => (IEnumerable<ValueDisplayText>)cmbSourceTable.DataSource; set => cmbSourceTable.DataSource = value; }

        public string MigrationName { get => cmbMigration?.SelectedValue?.ToString(); }

        public IEnumerable<ValueDisplayText> MigrationNames { get => (IEnumerable<ValueDisplayText>)cmbMigration.DataSource; set => cmbMigration.DataSource = value; }

        public event EventHandler GetAllEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler SourceTableDataEvent;
        public event EventHandler LoadSourceTablesEvent;

        public void SetSourceTableDataBindingSource(BindingSource bindingSource)
        {
            dtgwSourceTable.DataSource = bindingSource;
        }
        
       
        public  frmMigration GetInstace(Form parentContainer)
        {            
            this.MdiParent = parentContainer;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            return this;
        }

        public void UpdateProgress(int progress)
        {         
            progressBarCopyResult.Value = progress;
        }

        public void SetMaximumProgress(int progressMax)
        {
            progressBarCopyResult.Maximum = progressMax;
        }
    }
}
