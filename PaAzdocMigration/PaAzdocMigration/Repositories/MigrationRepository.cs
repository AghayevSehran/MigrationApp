using Dapper;
using PaAzdocMigration.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaAzdocMigration.Repositories
{
    public class MigrationRepository : BaseRepository, IMigrationRepository
    {
        IMigrationSettingsRepository migrationSettingsRepository;
        public MigrationRepository(string migrationSettingsConnection, string sourceTableConnection,
            string targetTableConnection, IMigrationSettingsRepository migrationSettingsRepository)
        {
            this.migrationSettingsRepository = migrationSettingsRepository;
            this.migrationSettingsConnectionString = migrationSettingsConnection;
            this.sourceTablesConnectionString = sourceTableConnection;
            this.targetTablesConnectionString = targetTableConnection;
        }

        public IEnumerable<int> Add(DataTable sourceTable, string sourceTableName, string migration, bool turnOffAuto)
        {
            var settings = migrationSettingsRepository.GetBySourceTableValue(sourceTableName, migration);
            if (turnOffAuto)
            {
                DeleteFromTarget(settings.First().TargetTableName);
                //TurnOffAutoIncrement(settings.First().TargetTableName);
            }
         
            int id = 0;
            StringBuilder columns = new StringBuilder();
            StringBuilder parametrs = new StringBuilder();

            int columnsCount = 2;
            int parametersCount = 10;
            columns.Append("( ");
            parametrs.Append(" VALUES ( ");
            foreach (var item in settings)
            {
                columns.Append(item.TargetColumnName);
                columnsCount += item.TargetColumnName.Length;
                columns.Append(',');
                columnsCount += 1;
                parametrs.Append($"@{item.TargetColumnName}");
                parametersCount += item.TargetColumnName.Length + 1;
                parametrs.Append(',');
                parametersCount += 1;
            }
            columns.Remove(columnsCount - 1, 1);
            parametrs.Remove(parametersCount - 1, 1);
            columns.Append(" ) ");
            parametrs.Append(" ) ");
            string query = null;
            if (!turnOffAuto)
            {
                query = "INSERT INTO " + settings.First().TargetTableName + " " + columns.ToString() + parametrs.ToString();
            }
            else
            {
                query = $"SET IDENTITY_INSERT {settings.First().TargetTableName} ON" + " INSERT INTO " + settings.First().TargetTableName + " " + columns.ToString() + parametrs.ToString();
            }           
          
            foreach (DataRow row in sourceTable.Rows)
            {                
                var param = new DynamicParameters();
                foreach (var p in settings)
                {
                    param.Add($"@{p.TargetColumnName}", row[p.SourceColumnName].ToString());
                }
                using (IDbConnection cnn = new SqlConnection(targetTablesConnectionString))
                {
                    cnn.Execute(query, param);
                }
                yield return id++;
            }
        }

        private void DeleteFromTarget(string targetTable)
        {
            var paramReset = new DynamicParameters();
            string queryReset = $"DELETE FROM  {targetTable} ";
            using (IDbConnection cnn = new SqlConnection(targetTablesConnectionString))
            {
                cnn.Execute(queryReset, paramReset);
            }
        }

        private void TurnOffAutoIncrement(string targetTable)
        {
            var paramReset = new DynamicParameters();
            string queryReset = $"SET IDENTITY_INSERT {targetTable} ON";
            using (IDbConnection cnn = new SqlConnection(targetTablesConnectionString))
            {
                cnn.Execute(queryReset, paramReset);
            }
        }

        public IEnumerable<ValueDisplayText> GetSourceTableColumnsBySourceTable(string sourceTableName)
        {
            var query = "SELECT COLUMN_NAME Value, COLUMN_NAME DisplayText FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @SourceTableName";
            var param = new DynamicParameters();
            param.Add("@SourceTableName", sourceTableName);
            using (IDbConnection cnn = new SqlConnection(sourceTablesConnectionString))
            {
                var output = cnn.Query<ValueDisplayText>(query, param);
                return output.ToList();
            }
        }

        public IEnumerable<ValueDisplayText> GetSourceTables()
        {
            var query = "SELECT TABLE_NAME Value, TABLE_NAME DisplayText " +
                "FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY Value";
            var param = new DynamicParameters();
            using (IDbConnection cnn = new SqlConnection(sourceTablesConnectionString))
            {
                var output = cnn.Query<ValueDisplayText>(query, param);
                return output.ToList();
            }
        }

        public IEnumerable<ValueDisplayText> GetTargetTableColumnsByTargetTable(string targteTableName)
        {
            var query = "SELECT COLUMN_NAME Value, COLUMN_NAME DisplayText FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TargteTableName";
            var param = new DynamicParameters();
            param.Add("@TargteTableName", targteTableName);
            using (IDbConnection cnn = new SqlConnection(targetTablesConnectionString))
            {
                var output = cnn.Query<ValueDisplayText>(query, param);
                return output.ToList();
            }
        }

        public IEnumerable<ValueDisplayText> GetTargetTables()
        {
            var query = "SELECT TABLE_NAME Value, TABLE_NAME DisplayText " +
            "FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY Value";
            var param = new DynamicParameters();
            using (IDbConnection cnn = new SqlConnection(targetTablesConnectionString))
            {
                var output = cnn.Query<ValueDisplayText>(query, param);
                return output.ToList();
            }
        }

        public DataTable GetSourceTableData(string sourceTableName)
        {
            using (SqlConnection con = new SqlConnection(sourceTablesConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM {sourceTableName}", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public IEnumerable<DisplayMemberModel> GetSourceTablesForGrid()
        {
            var query = "SELECT TABLE_NAME Value " +
             "FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY Value";
            var param = new DynamicParameters();
            using (IDbConnection cnn = new SqlConnection(sourceTablesConnectionString))
            {
                var output = cnn.Query<DisplayMemberModel>(query, param);
                return output.ToList();
            }
        }

        public IEnumerable<DisplayMemberModel> GetTargetTablesForGrid()
        {
            var query = "SELECT TABLE_NAME Value " +
            "FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY Value";
            var param = new DynamicParameters();
            using (IDbConnection cnn = new SqlConnection(targetTablesConnectionString))
            {
                var output = cnn.Query<DisplayMemberModel>(query, param);
                return output.ToList();
            }
        }

        public IEnumerable<DisplayMemberModel> GetSourceTableColumnsBySourceTableForGrid(string sourceTableName)
        {
            var query = "SELECT  COLUMN_NAME Value FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @SourceTableName";
            var param = new DynamicParameters();
            param.Add("@SourceTableName", sourceTableName);
            using (IDbConnection cnn = new SqlConnection(sourceTablesConnectionString))
            {
                var output = cnn.Query<DisplayMemberModel>(query, param);
                return output.ToList();
            }
        }

        public IEnumerable<DisplayMemberModel> GetTargetTableColumnsByTargetTableForGrid(string targteTableName)
        {
            var query = "SELECT COLUMN_NAME Value FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TargteTableName";
            var param = new DynamicParameters();
            param.Add("@TargteTableName", targteTableName);
            using (IDbConnection cnn = new SqlConnection(targetTablesConnectionString))
            {
                var output = cnn.Query<DisplayMemberModel>(query, param);
                return output.ToList();
            };
        }

        public IEnumerable<ValueDisplayText> GetMigrationNames()
        {
            var query = "SELECT DISTINCT MigrationName Value, MigrationName DisplayText FROM MigrationConfiguration";
            using (IDbConnection cnn = new SQLiteConnection(migrationSettingsConnectionString))
            {
                var output = cnn.Query<ValueDisplayText>(query, new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
