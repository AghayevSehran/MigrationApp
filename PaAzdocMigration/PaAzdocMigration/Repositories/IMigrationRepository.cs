using PaAzdocMigration.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaAzdocMigration.Repositories
{
    public interface IMigrationRepository
    {
        IEnumerable<int> Add(DataTable sourceTable, string sourceTableName, string migrationName, bool turnOffAutoIncrement);
        DataTable GetSourceTableData(string sourceTableName);
        IEnumerable<ValueDisplayText> GetSourceTables();
        IEnumerable<ValueDisplayText> GetMigrationNames();
        IEnumerable<DisplayMemberModel> GetSourceTablesForGrid();
        IEnumerable<ValueDisplayText> GetTargetTables();
        IEnumerable<DisplayMemberModel> GetTargetTablesForGrid();
        IEnumerable<ValueDisplayText> GetSourceTableColumnsBySourceTable(string sourceTableName);
        IEnumerable<DisplayMemberModel> GetSourceTableColumnsBySourceTableForGrid(string sourceTableName);
        IEnumerable<ValueDisplayText> GetTargetTableColumnsByTargetTable(string targteTableName);
        IEnumerable<DisplayMemberModel> GetTargetTableColumnsByTargetTableForGrid(string targteTableName);
    }
}
