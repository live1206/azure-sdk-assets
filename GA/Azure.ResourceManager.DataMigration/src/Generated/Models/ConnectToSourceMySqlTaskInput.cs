// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates MySQL database connection. </summary>
    public partial class ConnectToSourceMySqlTaskInput
    {
        /// <summary> Initializes a new instance of ConnectToSourceMySqlTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to MySQL source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/> is null. </exception>
        public ConnectToSourceMySqlTaskInput(MySqlConnectionInfo sourceConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));

            SourceConnectionInfo = sourceConnectionInfo;
        }

        /// <summary> Initializes a new instance of ConnectToSourceMySqlTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to MySQL source. </param>
        /// <param name="targetPlatform"> Target Platform for the migration. </param>
        /// <param name="checkPermissionsGroup"> Permission group for validations. </param>
        /// <param name="isOfflineMigration"> Flag for whether or not the migration is offline. </param>
        internal ConnectToSourceMySqlTaskInput(MySqlConnectionInfo sourceConnectionInfo, MySqlTargetPlatformType? targetPlatform, ServerLevelPermissionsGroup? checkPermissionsGroup, bool? isOfflineMigration)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetPlatform = targetPlatform;
            CheckPermissionsGroup = checkPermissionsGroup;
            IsOfflineMigration = isOfflineMigration;
        }

        /// <summary> Information for connecting to MySQL source. </summary>
        public MySqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Target Platform for the migration. </summary>
        public MySqlTargetPlatformType? TargetPlatform { get; set; }
        /// <summary> Permission group for validations. </summary>
        public ServerLevelPermissionsGroup? CheckPermissionsGroup { get; set; }
        /// <summary> Flag for whether or not the migration is offline. </summary>
        public bool? IsOfflineMigration { get; set; }
    }
}