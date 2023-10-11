// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel. </summary>
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel : MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel. </summary>
        internal MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel()
        {
            ResultType = "MigrationLevelOutput";
        }

        /// <summary> Initializes a new instance of MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="sourceServerVersion"> Source server version. </param>
        /// <param name="sourceServer"> Source server name. </param>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServer"> Target server name. </param>
        /// <param name="sourceServerType"> Source server type. </param>
        /// <param name="targetServerType"> Target server type. </param>
        /// <param name="state"> Migration status. </param>
        /// <param name="databaseCount"> Number of databases to include. </param>
        internal MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(string id, string resultType, DateTimeOffset? startedOn, DateTimeOffset? endedOn, string sourceServerVersion, string sourceServer, string targetServerVersion, string targetServer, ScenarioSource? sourceServerType, ScenarioTarget? targetServerType, ReplicateMigrationState? state, float? databaseCount) : base(id, resultType)
        {
            StartedOn = startedOn;
            EndedOn = endedOn;
            SourceServerVersion = sourceServerVersion;
            SourceServer = sourceServer;
            TargetServerVersion = targetServerVersion;
            TargetServer = targetServer;
            SourceServerType = sourceServerType;
            TargetServerType = targetServerType;
            State = state;
            DatabaseCount = databaseCount;
            ResultType = resultType ?? "MigrationLevelOutput";
        }

        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Source server version. </summary>
        public string SourceServerVersion { get; }
        /// <summary> Source server name. </summary>
        public string SourceServer { get; }
        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server name. </summary>
        public string TargetServer { get; }
        /// <summary> Source server type. </summary>
        public ScenarioSource? SourceServerType { get; }
        /// <summary> Target server type. </summary>
        public ScenarioTarget? TargetServerType { get; }
        /// <summary> Migration status. </summary>
        public ReplicateMigrationState? State { get; }
        /// <summary> Number of databases to include. </summary>
        public float? DatabaseCount { get; }
    }
}