// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for task that migrates SSIS packages from SQL Server to Azure SQL Database Managed Instance. </summary>
    public partial class MigrateSsisTaskInput : SqlMigrationTaskInput
    {
        /// <summary> Initializes a new instance of MigrateSsisTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="ssisMigrationInfo"> SSIS package migration information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/> or <paramref name="ssisMigrationInfo"/> is null. </exception>
        public MigrateSsisTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, SsisMigrationInfo ssisMigrationInfo) : base(sourceConnectionInfo, targetConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(ssisMigrationInfo, nameof(ssisMigrationInfo));

            SsisMigrationInfo = ssisMigrationInfo;
        }

        /// <summary> SSIS package migration information. </summary>
        public SsisMigrationInfo SsisMigrationInfo { get; set; }
    }
}