using PaAzdocMigration.Controls;
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
    public partial class frmMigrationSetting : Form, IMigrationSettingsView
    {

        BindingSource _bindingSource;
        public frmMigrationSetting()
        {
            InitializeComponent();
            //Save changes
            btnDelete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
            };
            btnSearch.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
             
            };
            txtSearchSourceTableName.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                toolTipStatus.Text = Message;
            };
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
            };
            dgwMigrationSettings.CellDoubleClick += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
            };           
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
            };
            btnSourceTables.Click += delegate
            {
                GetSourceTables?.Invoke(this, EventArgs.Empty);
            };
            btnSourceColumn.Click += delegate
            {
                GetSourceTableColumns?.Invoke(this, EventArgs.Empty);
            };
            btnTargetTables.Click += delegate
            {
                GetTargetTables?.Invoke(this, EventArgs.Empty);
            };
            btnTargetColumn.Click += delegate
            {
                GetTargetTableColumns?.Invoke(this, EventArgs.Empty);
            };            
           
        }

        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private int status = 1;

        public int Id { get; set; }
        public string SearchSourceTableName { get => this.txtSearchSourceTableName.Text; set => this.txtSearchSourceTableName.Text = value; }
        public string SourceTableName { get => this.txtSourceTable.Text; set => this.txtSourceTable.Text = value; }
        public string TargetTableName { get => this.txtTargetTable.Text; set => txtTargetTable.Text = value; }
        public string SourceColumnName { get => this.txtSourceColumn.Text; set => txtSourceColumn.Text = value; }
        public string TargetColumnName { get => this.txtTargetColumn.Text; set => this.txtTargetColumn.Text = value; }
        public int ColumnIndex { get => (int)this.numOrderIndex.Value; set => this.numOrderIndex.Value = value; }
        public bool IsEdit { get => this.isEdit; set => this.isEdit = value; }
        public bool IsSuccessful { get => this.isSuccessful; set => this.isSuccessful = value; }
        public string Message { get => this.message; set => this.message = value; }
        public int Status { get => this.status; set => this.status = value; }
        public string MigrationName { get => this.txtMigrationName.Text; set => this.txtMigrationName.Text = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler GetSourceTables;
        public event EventHandler GetSourceTableColumns;
        public event EventHandler GetTargetTables;
        public event EventHandler GetTargetTableColumns;
        public event EventHandler GetAllEvent;
        public event EventHandler CancelEvent;

        public void SetMigrationSettingsListBindingSource(BindingSource migrationSettingsList)
        {
            dgwMigrationSettings.DataSource = migrationSettingsList;
        }

        public frmMigrationSetting GetInstace(Form parentContainer)
        {          
            MdiParent = parentContainer;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            return this;
        }

        public void ShowDialogForm(BindingSource binding)
        {
            new frmDialog().ShowDalogForm(binding);
        }
            
    }
}
