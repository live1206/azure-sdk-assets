// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Azure Backup Rehydrate Request. </summary>
    public partial class BackupRehydrationContent
    {
        /// <summary> Initializes a new instance of BackupRehydrationContent. </summary>
        /// <param name="recoveryPointId"> Id of the recovery point to be recovered. </param>
        /// <param name="rehydrationRetentionDuration"> Retention duration in ISO 8601 format i.e P10D . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public BackupRehydrationContent(string recoveryPointId, TimeSpan rehydrationRetentionDuration)
        {
            Argument.AssertNotNull(recoveryPointId, nameof(recoveryPointId));

            RecoveryPointId = recoveryPointId;
            RehydrationRetentionDuration = rehydrationRetentionDuration;
        }

        /// <summary> Id of the recovery point to be recovered. </summary>
        public string RecoveryPointId { get; }
        /// <summary> Priority to be used for rehydration. Values High or Standard. </summary>
        public BackupRehydrationPriority? RehydrationPriority { get; set; }
        /// <summary> Retention duration in ISO 8601 format i.e P10D . </summary>
        public TimeSpan RehydrationRetentionDuration { get; }
    }
}