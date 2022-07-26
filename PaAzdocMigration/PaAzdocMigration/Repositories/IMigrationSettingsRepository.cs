using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaAzdocMigration.Models
{
    public interface IMigrationSettingsRepository
    {
        void Add(MigrationSetting migration);
        void Edit(MigrationSetting migration);
        void Delete(int id);
        IEnumerable<MigrationSetting> GetAll();
        IEnumerable<MigrationSetting> GetBySourceTableValue(string getBySourceTable);
        IEnumerable<MigrationSetting> GetBySourceTableValue(string getBySourceTable, string migrationName);
        IEnumerable<MigrationSetting> GetByTargetTableValue(string getByTargetTable);
        IEnumerable<MigrationSetting> GetById(int id);
    }
}
