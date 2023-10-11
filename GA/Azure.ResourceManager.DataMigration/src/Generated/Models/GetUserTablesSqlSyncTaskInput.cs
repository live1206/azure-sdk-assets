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
    /// <summary> Input for the task that collects user tables for the given list of databases. </summary>
    public partial class GetUserTablesSqlSyncTaskInput
    {
        /// <summary> Initializes a new instance of GetUserTablesSqlSyncTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for SQL Server. </param>
        /// <param name="targetConnectionInfo"> Connection information for SQL DB. </param>
        /// <param name="selectedSourceDatabases"> List of source database names to collect tables for. </param>
        /// <param name="selectedTargetDatabases"> List of target database names to collect tables for. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/>, <paramref name="selectedSourceDatabases"/> or <paramref name="selectedTargetDatabases"/> is null. </exception>
        public GetUserTablesSqlSyncTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IEnumerable<string> selectedSourceDatabases, IEnumerable<string> selectedTargetDatabases)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(selectedSourceDatabases, nameof(selectedSourceDatabases));
            Argument.AssertNotNull(selectedTargetDatabases, nameof(selectedTargetDatabases));

            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedSourceDatabases = selectedSourceDatabases.ToList();
            SelectedTargetDatabases = selectedTargetDatabases.ToList();
        }

        /// <summary> Initializes a new instance of GetUserTablesSqlSyncTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for SQL Server. </param>
        /// <param name="targetConnectionInfo"> Connection information for SQL DB. </param>
        /// <param name="selectedSourceDatabases"> List of source database names to collect tables for. </param>
        /// <param name="selectedTargetDatabases"> List of target database names to collect tables for. </param>
        internal GetUserTablesSqlSyncTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IList<string> selectedSourceDatabases, IList<string> selectedTargetDatabases)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedSourceDatabases = selectedSourceDatabases;
            SelectedTargetDatabases = selectedTargetDatabases;
        }

        /// <summary> Connection information for SQL Server. </summary>
        public SqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Connection information for SQL DB. </summary>
        public SqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> List of source database names to collect tables for. </summary>
        public IList<string> SelectedSourceDatabases { get; }
        /// <summary> List of target database names to collect tables for. </summary>
        public IList<string> SelectedTargetDatabases { get; }
    }
}