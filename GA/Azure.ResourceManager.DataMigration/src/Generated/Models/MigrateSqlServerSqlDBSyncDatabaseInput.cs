// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database specific information for SQL to Azure SQL DB sync migration task inputs. </summary>
    public partial class MigrateSqlServerSqlDBSyncDatabaseInput
    {
        /// <summary> Initializes a new instance of MigrateSqlServerSqlDBSyncDatabaseInput. </summary>
        public MigrateSqlServerSqlDBSyncDatabaseInput()
        {
            TableMap = new ChangeTrackingDictionary<string, string>();
            MigrationSetting = new ChangeTrackingDictionary<string, string>();
            SourceSetting = new ChangeTrackingDictionary<string, string>();
            TargetSetting = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MigrateSqlServerSqlDBSyncDatabaseInput. </summary>
        /// <param name="id"> Unique identifier for database. </param>
        /// <param name="name"> Name of database. </param>
        /// <param name="targetDatabaseName"> Target database name. </param>
        /// <param name="schemaName"> Schema name to be migrated. </param>
        /// <param name="tableMap"> Mapping of source to target tables. </param>
        /// <param name="migrationSetting"> Migration settings which tune the migration behavior. </param>
        /// <param name="sourceSetting"> Source settings to tune source endpoint migration behavior. </param>
        /// <param name="targetSetting"> Target settings to tune target endpoint migration behavior. </param>
        internal MigrateSqlServerSqlDBSyncDatabaseInput(string id, string name, string targetDatabaseName, string schemaName, IDictionary<string, string> tableMap, IDictionary<string, string> migrationSetting, IDictionary<string, string> sourceSetting, IDictionary<string, string> targetSetting)
        {
            Id = id;
            Name = name;
            TargetDatabaseName = targetDatabaseName;
            SchemaName = schemaName;
            TableMap = tableMap;
            MigrationSetting = migrationSetting;
            SourceSetting = sourceSetting;
            TargetSetting = targetSetting;
        }

        /// <summary> Unique identifier for database. </summary>
        public string Id { get; set; }
        /// <summary> Name of database. </summary>
        public string Name { get; set; }
        /// <summary> Target database name. </summary>
        public string TargetDatabaseName { get; set; }
        /// <summary> Schema name to be migrated. </summary>
        public string SchemaName { get; set; }
        /// <summary> Mapping of source to target tables. </summary>
        public IDictionary<string, string> TableMap { get; }
        /// <summary> Migration settings which tune the migration behavior. </summary>
        public IDictionary<string, string> MigrationSetting { get; }
        /// <summary> Source settings to tune source endpoint migration behavior. </summary>
        public IDictionary<string, string> SourceSetting { get; }
        /// <summary> Target settings to tune target endpoint migration behavior. </summary>
        public IDictionary<string, string> TargetSetting { get; }
    }
}