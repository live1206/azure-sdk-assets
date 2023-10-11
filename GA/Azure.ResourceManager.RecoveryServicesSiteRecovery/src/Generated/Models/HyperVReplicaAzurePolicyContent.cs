// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper-V Replica Azure specific input for creating a protection profile. </summary>
    public partial class HyperVReplicaAzurePolicyContent : PolicyProviderSpecificContent
    {
        /// <summary> Initializes a new instance of HyperVReplicaAzurePolicyContent. </summary>
        public HyperVReplicaAzurePolicyContent()
        {
            StorageAccounts = new ChangeTrackingList<string>();
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> The duration (in hours) to which point the recovery history needs to be maintained. </summary>
        public int? RecoveryPointHistoryDuration { get; set; }
        /// <summary> The interval (in hours) at which Hyper-V Replica should create an application consistent snapshot within the VM. </summary>
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; set; }
        /// <summary> The replication interval. </summary>
        public int? ReplicationInterval { get; set; }
        /// <summary> The scheduled start time for the initial replication. If this parameter is Null, the initial replication starts immediately. </summary>
        public string OnlineReplicationStartTime { get; set; }
        /// <summary> The list of storage accounts to which the VMs in the primary cloud can replicate to. </summary>
        public IList<string> StorageAccounts { get; }
    }
}