// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for task that migrates Schema for SQL Server databases to Azure SQL databases. </summary>
    public partial class MigrateSchemaSqlServerSqlDBTaskInput : SqlMigrationTaskInput
    {
        /// <summary> Initializes a new instance of MigrateSchemaSqlServerSqlDBTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/> or <paramref name="selectedDatabases"/> is null. </exception>
        public MigrateSchemaSqlServerSqlDBTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IEnumerable<MigrateSchemaSqlServerSqlDBDatabaseInput> selectedDatabases) : base(sourceConnectionInfo, targetConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));

            SelectedDatabases = selectedDatabases.ToList();
        }

        /// <summary> Initializes a new instance of MigrateSchemaSqlServerSqlDBTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="encryptedKeyForSecureFields"> encrypted key for secure fields. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/> or <paramref name="targetConnectionInfo"/> is null. </exception>
        internal MigrateSchemaSqlServerSqlDBTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IList<MigrateSchemaSqlServerSqlDBDatabaseInput> selectedDatabases, string encryptedKeyForSecureFields, string startedOn) : base(sourceConnectionInfo, targetConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));

            SelectedDatabases = selectedDatabases;
            EncryptedKeyForSecureFields = encryptedKeyForSecureFields;
            StartedOn = startedOn;
        }

        /// <summary> Databases to migrate. </summary>
        public IList<MigrateSchemaSqlServerSqlDBDatabaseInput> SelectedDatabases { get; }
        /// <summary> encrypted key for secure fields. </summary>
        public string EncryptedKeyForSecureFields { get; set; }
        /// <summary> Migration start time. </summary>
        public string StartedOn { get; set; }
    }
}