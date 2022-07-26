using Dapper;
using PaAzdocMigration.Common;
using PaAzdocMigration.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace PaAzdocMigration.Repositories
{
    public class MigrationSettingRepository : BaseRepository, IMigrationSettingsRepository
    {        
        public MigrationSettingRepository(string migrationSettingsConnection, string sourceTableConnection,
            string targetTableConnection)
        {            
            this.migrationSettingsConnectionString = migrationSettingsConnection;
            this.sourceTablesConnectionString = sourceTableConnection;
            this.targetTablesConnectionString = targetTableConnection;
        }

        public void Add(MigrationSetting migration)
        {
            string query = "INSERT INTO MigrationConfiguration " +
                "(SourceTableName, TargetTableName, SourceColumnName, TargetColumnName, ColumnIndex, Status, MigrationName) " +
                "VALUES(@SourceTableName, @TargetTableName, @SourceColumnName, @TargetColumnName, @ColumnIndex, @Status, @MigrationName)";
            using (IDbConnection cnn =  new SQLiteConnection(migrationSettingsConnectionString))
            {
                cnn.Execute(query, migration);
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from MigrationConfiguration WHERE Id = @id";
            using (IDbConnection cnn = new SQLiteConnection(migrationSettingsConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@id", id);
                cnn.Execute(query, param);
            }
        }

        public void Edit(MigrationSetting migration)
        {
            const string query = "UPDATE MigrationConfiguration" +
                " SET SourceTableName = @SourceTableName, TargetTableName = @TargetTableName," +
                " SourceColumnName = @SourceColumnName, TargetColumnName = @TargetColumnName, ColumnIndex = @ColumnIndex,  MigrationName = @MigrationName " +
                "WHERE Id = @Id";
            var args = new Dictionary<string, object>
             {
               {"@SourceTableName", migration.SourceTableName},
               {"@TargetTableName", migration.TargetTableName},
               {"@SourceColumnName", migration.SourceColumnName},
               {"@TargetColumnName", migration.TargetColumnName},
               {"@ColumnIndex", migration.ColumnIndex},
               {"@MigrationName", migration.MigrationName},
               {"@id", migration.Id},
               {"@Status", 1}
             };
            using (IDbConnection cnn = new SQLiteConnection(migrationSettingsConnectionString))
            {
                cnn.Execute(query, migration);
            }
        }

        public IEnumerable<MigrationSetting> GetAll()
        {
            var query = "SELECT * FROM MigrationConfiguration";
            using (IDbConnection cnn = new SQLiteConnection(migrationSettingsConnectionString))
            {
                var output = cnn.Query<MigrationSetting>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        public IEnumerable<MigrationSetting> GetById(int id)
        {
            var query = "SELECT * FROM MigrationConfiguration WHERE Id = @id";         
            var param = new DynamicParameters();
            param.Add("@id", id);
            using (IDbConnection cnn = new SQLiteConnection(migrationSettingsConnectionString))
            {
                var output = cnn.Query<MigrationSetting>(query, param);
                return output.ToList();
            }
        }
        
        public IEnumerable<MigrationSetting> GetBySourceTableValue(string sourceTableName)
        {
            var query = "SELECT * FROM MigrationConfiguration WHERE SourceTableName = @SourceTableName";        
            var param = new DynamicParameters();
            param.Add("@SourceTableName", sourceTableName);
            using (IDbConnection cnn = new SQLiteConnection(migrationSettingsConnectionString))
            {
                var output = cnn.Query<MigrationSetting>(query, param);
                return output.ToList();
            }
        }

        public IEnumerable<MigrationSetting> GetBySourceTableValue(string getBySourceTable, string migrationName)
        {
            var query = "SELECT * FROM MigrationConfiguration WHERE SourceTableName = @SourceTableName AND MigrationName = @MigrationName";
            var param = new DynamicParameters();
            param.Add("@SourceTableName", getBySourceTable);
            param.Add("@MigrationName", migrationName);
            using (IDbConnection cnn = new SQLiteConnection(migrationSettingsConnectionString))
            {
                var output = cnn.Query<MigrationSetting>(query, param);
                return output.ToList();
            }
        }

        public IEnumerable<MigrationSetting> GetByTargetTableValue(string targetTableName)
        {
            var query = "SELECT * FROM MigrationConfiguration WHERE TargetTableName = @TargetTableName";      
            var param = new DynamicParameters();
            param.Add("@TargetTableName", targetTableName);
            using (IDbConnection cnn = new SQLiteConnection(migrationSettingsConnectionString))
            {
                var output = cnn.Query<MigrationSetting>(query, param);
                return output.ToList();
            }
        }
    }
}
