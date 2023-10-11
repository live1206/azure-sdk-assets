// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Backup Settings. </summary>
    public partial class MySqlFlexibleServerBackupSettings
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerBackupSettings. </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public MySqlFlexibleServerBackupSettings(string backupName)
        {
            Argument.AssertNotNull(backupName, nameof(backupName));

            BackupName = backupName;
        }

        /// <summary> The name of the backup. </summary>
        public string BackupName { get; }
        /// <summary> Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE). </summary>
        public MySqlFlexibleServerBackupFormat? BackupFormat { get; set; }
    }
}