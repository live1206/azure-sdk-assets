// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to Azure Database for PostgreSQL and target server requirements for Oracle source. </summary>
    internal partial class ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput
    {
        /// <summary> Initializes a new instance of ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for PostgreSQL server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetConnectionInfo"/> is null. </exception>
        public ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput(PostgreSqlConnectionInfo targetConnectionInfo)
        {
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));

            TargetConnectionInfo = targetConnectionInfo;
        }

        /// <summary> Connection information for target Azure Database for PostgreSQL server. </summary>
        public PostgreSqlConnectionInfo TargetConnectionInfo { get; set; }
    }
}