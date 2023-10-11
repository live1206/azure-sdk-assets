// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem. </summary>
    public partial class ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem
    {
        /// <summary> Initializes a new instance of ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem. </summary>
        internal ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem()
        {
            Schemas = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem. </summary>
        /// <param name="database"></param>
        /// <param name="schemas"></param>
        internal ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem(string database, IReadOnlyList<string> schemas)
        {
            Database = database;
            Schemas = schemas;
        }

        /// <summary> Gets the database. </summary>
        public string Database { get; }
        /// <summary> Gets the schemas. </summary>
        public IReadOnlyList<string> Schemas { get; }
    }
}