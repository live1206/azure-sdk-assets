// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Azure specific reprotect input. </summary>
    public partial class HyperVReplicaAzureReprotectContent : ReverseReplicationProviderSpecificContent
    {
        /// <summary> Initializes a new instance of HyperVReplicaAzureReprotectContent. </summary>
        public HyperVReplicaAzureReprotectContent()
        {
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> The Hyper-V host Vm Id. </summary>
        public string HyperVHostVmId { get; set; }
        /// <summary> The Vm Name. </summary>
        public string VmName { get; set; }
        /// <summary> The OS type associated with vm. </summary>
        public string OSType { get; set; }
        /// <summary> The OS disk VHD id associated with vm. </summary>
        public string VhdId { get; set; }
        /// <summary> The storage account name. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
        /// <summary> The storage account to be used for logging during replication. </summary>
        public ResourceIdentifier LogStorageAccountId { get; set; }
    }
}