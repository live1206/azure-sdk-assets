// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Backup management usage for vault. </summary>
    internal partial class BackupManagementUsageList
    {
        /// <summary> Initializes a new instance of BackupManagementUsageList. </summary>
        internal BackupManagementUsageList()
        {
            Value = new ChangeTrackingList<BackupManagementUsage>();
        }

        /// <summary> Initializes a new instance of BackupManagementUsageList. </summary>
        /// <param name="value"> The list of backup management usages for the given vault. </param>
        internal BackupManagementUsageList(IReadOnlyList<BackupManagementUsage> value)
        {
            Value = value;
        }

        /// <summary> The list of backup management usages for the given vault. </summary>
        public IReadOnlyList<BackupManagementUsage> Value { get; }
    }
}