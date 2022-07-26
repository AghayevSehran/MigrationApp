using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaAzdocMigration.Views
{
    public interface IDialogView
    {
        void ShowDalogForm(BindingSource bindingSource);
    }
}
