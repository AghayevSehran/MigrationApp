using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaAzdocMigration.Models
{
    public class MigrationSetting
    {
        [DisplayName("Migration id")]
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Source table name")]
        //[Required(ErrorMessage = "Source table name is requerid")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
        public string SourceTableName { get; set; }

        [DisplayName("Target table name")]
        public string TargetTableName { get; set; }

        [DisplayName("Source column name")]
        public string SourceColumnName { get; set; }

        [DisplayName("Target column name")]
        public string TargetColumnName { get; set; }

        [DisplayName("Column index")]
        public int ColumnIndex { get; set; }

        [DisplayName("Status")]
        public int Status { get; set; }

        [DisplayName("Migration name")]
        public string MigrationName { get; set; }
    }
}
