using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaAzdocMigration.Models
{
    public class DisplayMemberModel
    {
        [DisplayName("Table name")]
        public string Value { get; set; }
    }
}
