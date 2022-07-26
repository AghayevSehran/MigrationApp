
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;

namespace PaAzdocMigration.Repositories
{
    public abstract class BaseRepository
    {
        protected string migrationSettingsConnectionString;
        protected string sourceTablesConnectionString;
        protected string targetTablesConnectionString;
    }
}
