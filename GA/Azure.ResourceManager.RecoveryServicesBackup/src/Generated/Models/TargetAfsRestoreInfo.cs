// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Target Azure File Share Info. </summary>
    public partial class TargetAfsRestoreInfo
    {
        /// <summary> Initializes a new instance of TargetAfsRestoreInfo. </summary>
        public TargetAfsRestoreInfo()
        {
        }

        /// <summary> Initializes a new instance of TargetAfsRestoreInfo. </summary>
        /// <param name="name"> File share name. </param>
        /// <param name="targetResourceId"> Target file share resource ARM ID. </param>
        internal TargetAfsRestoreInfo(string name, ResourceIdentifier targetResourceId)
        {
            Name = name;
            TargetResourceId = targetResourceId;
        }

        /// <summary> File share name. </summary>
        public string Name { get; set; }
        /// <summary> Target file share resource ARM ID. </summary>
        public ResourceIdentifier TargetResourceId { get; set; }
    }
}