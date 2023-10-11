// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Sync BackupInstance Request. </summary>
    public partial class BackupInstanceSyncContent
    {
        /// <summary> Initializes a new instance of BackupInstanceSyncContent. </summary>
        public BackupInstanceSyncContent()
        {
        }

        /// <summary> Field indicating sync type e.g. to sync only in case of failure or in all cases. </summary>
        public BackupInstanceSyncType? SyncType { get; set; }
    }
}
