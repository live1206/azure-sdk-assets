// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> List Restore Ranges Response. </summary>
    public partial class BackupFindRestorableTimeRangeResult : ResourceData
    {
        /// <summary> Initializes a new instance of BackupFindRestorableTimeRangeResult. </summary>
        public BackupFindRestorableTimeRangeResult()
        {
        }

        /// <summary> Initializes a new instance of BackupFindRestorableTimeRangeResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> AzureBackupFindRestorableTimeRangesResponseResource properties. </param>
        internal BackupFindRestorableTimeRangeResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BackupFindRestorableTimeRangeResultProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> AzureBackupFindRestorableTimeRangesResponseResource properties. </summary>
        public BackupFindRestorableTimeRangeResultProperties Properties { get; set; }
    }
}