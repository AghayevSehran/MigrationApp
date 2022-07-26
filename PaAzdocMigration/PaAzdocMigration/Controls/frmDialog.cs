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

namespace PaAzdocMigration.Controls
{
    public partial class frmDialog : Form,IDialogView
    {
        public frmDialog()
        {
            InitializeComponent();
        }    
        public void ShowDalogForm(BindingSource bindingSource)
        {
            dtgwDialog.DataSource = bindingSource;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowDialog();
        }
    }
}
