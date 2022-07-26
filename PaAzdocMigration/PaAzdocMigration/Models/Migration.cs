using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaAzdocMigration.Models
{
    public class Migration
    {
        public string SourceTable { get; set; }
        public string MigrationName { get; set; }
        public bool TurnOffTargetAutoIncrement { get; set; }
    }
}
