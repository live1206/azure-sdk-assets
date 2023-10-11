// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMage provider specific settings. </summary>
    public partial class InMageReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of InMageReplicationDetails. </summary>
        internal InMageReplicationDetails()
        {
            ProtectedDisks = new ChangeTrackingList<InMageProtectedDiskDetails>();
            ConsistencyPoints = new ChangeTrackingDictionary<string, DateTimeOffset>();
            VmNics = new ChangeTrackingList<VmNicDetails>();
            Datastores = new ChangeTrackingList<string>();
            ValidationErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
            InstanceType = "InMage";
        }

        /// <summary> Initializes a new instance of InMageReplicationDetails. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="activeSiteType"> The active location of the VM. If the VM is being protected from Azure, this field will take values from { Azure, OnPrem }. If the VM is being protected between two data-centers, this field will be OnPrem always. </param>
        /// <param name="sourceVmCpuCount"> The CPU count of the VM on the primary side. </param>
        /// <param name="sourceVmRamSizeInMB"> The RAM size of the VM on the primary side. </param>
        /// <param name="osDetails"> The OS details. </param>
        /// <param name="protectionStage"> The protection stage. </param>
        /// <param name="vmId"> The virtual machine Id. </param>
        /// <param name="vmProtectionState"> The protection state for the vm. </param>
        /// <param name="vmProtectionStateDescription"> The protection state description for the vm. </param>
        /// <param name="resyncDetails"> The resync details of the machine. </param>
        /// <param name="retentionWindowStartOn"> The retention window start time. </param>
        /// <param name="retentionWindowEndOn"> The retention window end time. </param>
        /// <param name="compressedDataRateInMB"> The compressed data change rate in MB. </param>
        /// <param name="uncompressedDataRateInMB"> The uncompressed data change rate in MB. </param>
        /// <param name="rpoInSeconds"> The RPO in seconds. </param>
        /// <param name="protectedDisks"> The list of protected disks. </param>
        /// <param name="ipAddress"> The source IP address. </param>
        /// <param name="lastHeartbeatReceivedOn"> The last heartbeat received from the source server. </param>
        /// <param name="processServerId"> The process server Id. </param>
        /// <param name="masterTargetId"> The master target Id. </param>
        /// <param name="consistencyPoints"> The collection of Consistency points. </param>
        /// <param name="diskResized"> A value indicating whether any disk is resized for this VM. </param>
        /// <param name="rebootAfterUpdateStatus"> A value indicating whether the source server requires a restart after update. </param>
        /// <param name="multiVmGroupId"> The multi vm group Id, if any. </param>
        /// <param name="multiVmGroupName"> The multi vm group name, if any. </param>
        /// <param name="multiVmSyncStatus"> A value indicating whether the multi vm sync is enabled or disabled. </param>
        /// <param name="agentDetails"> The agent details. </param>
        /// <param name="vCenterInfrastructureId"> The vCenter infrastructure Id. </param>
        /// <param name="infrastructureVmId"> The infrastructure VM Id. </param>
        /// <param name="vmNics"> The PE Network details. </param>
        /// <param name="discoveryType"> A value indicating the discovery type of the machine. </param>
        /// <param name="azureStorageAccountId"> A value indicating the underlying Azure storage account. If the VM is not running in Azure, this value shall be set to null. </param>
        /// <param name="datastores"> The datastores of the on-premise machine Value can be list of strings that contain datastore names. </param>
        /// <param name="validationErrors"> The validation errors of the on-premise machine Value can be list of validation errors. </param>
        /// <param name="lastRpoCalculatedOn"> The last RPO calculated time. </param>
        /// <param name="lastUpdateReceivedOn"> The last update time received from on-prem components. </param>
        /// <param name="replicaId"> The replica id of the protected item. </param>
        /// <param name="osVersion"> The OS Version of the protected item. </param>
        /// <param name="isAdditionalStatsAvailable"> A value indicating whether additional IR stats are available or not. </param>
        /// <param name="totalDataTransferred"> The total transferred data in bytes. </param>
        /// <param name="totalProgressHealth"> The progress health. </param>
        internal InMageReplicationDetails(string instanceType, string activeSiteType, int? sourceVmCpuCount, int? sourceVmRamSizeInMB, SiteRecoveryOSDiskDetails osDetails, string protectionStage, string vmId, string vmProtectionState, string vmProtectionStateDescription, InitialReplicationDetails resyncDetails, DateTimeOffset? retentionWindowStartOn, DateTimeOffset? retentionWindowEndOn, double? compressedDataRateInMB, double? uncompressedDataRateInMB, long? rpoInSeconds, IReadOnlyList<InMageProtectedDiskDetails> protectedDisks, IPAddress ipAddress, DateTimeOffset? lastHeartbeatReceivedOn, Guid? processServerId, string masterTargetId, IReadOnlyDictionary<string, DateTimeOffset> consistencyPoints, string diskResized, string rebootAfterUpdateStatus, string multiVmGroupId, string multiVmGroupName, string multiVmSyncStatus, InMageAgentDetails agentDetails, string vCenterInfrastructureId, string infrastructureVmId, IReadOnlyList<VmNicDetails> vmNics, string discoveryType, ResourceIdentifier azureStorageAccountId, IReadOnlyList<string> datastores, IReadOnlyList<SiteRecoveryHealthError> validationErrors, DateTimeOffset? lastRpoCalculatedOn, DateTimeOffset? lastUpdateReceivedOn, string replicaId, string osVersion, bool? isAdditionalStatsAvailable, long? totalDataTransferred, string totalProgressHealth) : base(instanceType)
        {
            ActiveSiteType = activeSiteType;
            SourceVmCpuCount = sourceVmCpuCount;
            SourceVmRamSizeInMB = sourceVmRamSizeInMB;
            OSDetails = osDetails;
            ProtectionStage = protectionStage;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            ResyncDetails = resyncDetails;
            RetentionWindowStartOn = retentionWindowStartOn;
            RetentionWindowEndOn = retentionWindowEndOn;
            CompressedDataRateInMB = compressedDataRateInMB;
            UncompressedDataRateInMB = uncompressedDataRateInMB;
            RpoInSeconds = rpoInSeconds;
            ProtectedDisks = protectedDisks;
            IPAddress = ipAddress;
            LastHeartbeatReceivedOn = lastHeartbeatReceivedOn;
            ProcessServerId = processServerId;
            MasterTargetId = masterTargetId;
            ConsistencyPoints = consistencyPoints;
            DiskResized = diskResized;
            RebootAfterUpdateStatus = rebootAfterUpdateStatus;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            MultiVmSyncStatus = multiVmSyncStatus;
            AgentDetails = agentDetails;
            VCenterInfrastructureId = vCenterInfrastructureId;
            InfrastructureVmId = infrastructureVmId;
            VmNics = vmNics;
            DiscoveryType = discoveryType;
            AzureStorageAccountId = azureStorageAccountId;
            Datastores = datastores;
            ValidationErrors = validationErrors;
            LastRpoCalculatedOn = lastRpoCalculatedOn;
            LastUpdateReceivedOn = lastUpdateReceivedOn;
            ReplicaId = replicaId;
            OSVersion = osVersion;
            IsAdditionalStatsAvailable = isAdditionalStatsAvailable;
            TotalDataTransferred = totalDataTransferred;
            TotalProgressHealth = totalProgressHealth;
            InstanceType = instanceType ?? "InMage";
        }

        /// <summary> The active location of the VM. If the VM is being protected from Azure, this field will take values from { Azure, OnPrem }. If the VM is being protected between two data-centers, this field will be OnPrem always. </summary>
        public string ActiveSiteType { get; }
        /// <summary> The CPU count of the VM on the primary side. </summary>
        public int? SourceVmCpuCount { get; }
        /// <summary> The RAM size of the VM on the primary side. </summary>
        public int? SourceVmRamSizeInMB { get; }
        /// <summary> The OS details. </summary>
        public SiteRecoveryOSDiskDetails OSDetails { get; }
        /// <summary> The protection stage. </summary>
        public string ProtectionStage { get; }
        /// <summary> The virtual machine Id. </summary>
        public string VmId { get; }
        /// <summary> The protection state for the vm. </summary>
        public string VmProtectionState { get; }
        /// <summary> The protection state description for the vm. </summary>
        public string VmProtectionStateDescription { get; }
        /// <summary> The resync details of the machine. </summary>
        public InitialReplicationDetails ResyncDetails { get; }
        /// <summary> The retention window start time. </summary>
        public DateTimeOffset? RetentionWindowStartOn { get; }
        /// <summary> The retention window end time. </summary>
        public DateTimeOffset? RetentionWindowEndOn { get; }
        /// <summary> The compressed data change rate in MB. </summary>
        public double? CompressedDataRateInMB { get; }
        /// <summary> The uncompressed data change rate in MB. </summary>
        public double? UncompressedDataRateInMB { get; }
        /// <summary> The RPO in seconds. </summary>
        public long? RpoInSeconds { get; }
        /// <summary> The list of protected disks. </summary>
        public IReadOnlyList<InMageProtectedDiskDetails> ProtectedDisks { get; }
        /// <summary> The source IP address. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The last heartbeat received from the source server. </summary>
        public DateTimeOffset? LastHeartbeatReceivedOn { get; }
        /// <summary> The process server Id. </summary>
        public Guid? ProcessServerId { get; }
        /// <summary> The master target Id. </summary>
        public string MasterTargetId { get; }
        /// <summary> The collection of Consistency points. </summary>
        public IReadOnlyDictionary<string, DateTimeOffset> ConsistencyPoints { get; }
        /// <summary> A value indicating whether any disk is resized for this VM. </summary>
        public string DiskResized { get; }
        /// <summary> A value indicating whether the source server requires a restart after update. </summary>
        public string RebootAfterUpdateStatus { get; }
        /// <summary> The multi vm group Id, if any. </summary>
        public string MultiVmGroupId { get; }
        /// <summary> The multi vm group name, if any. </summary>
        public string MultiVmGroupName { get; }
        /// <summary> A value indicating whether the multi vm sync is enabled or disabled. </summary>
        public string MultiVmSyncStatus { get; }
        /// <summary> The agent details. </summary>
        public InMageAgentDetails AgentDetails { get; }
        /// <summary> The vCenter infrastructure Id. </summary>
        public string VCenterInfrastructureId { get; }
        /// <summary> The infrastructure VM Id. </summary>
        public string InfrastructureVmId { get; }
        /// <summary> The PE Network details. </summary>
        public IReadOnlyList<VmNicDetails> VmNics { get; }
        /// <summary> A value indicating the discovery type of the machine. </summary>
        public string DiscoveryType { get; }
        /// <summary> A value indicating the underlying Azure storage account. If the VM is not running in Azure, this value shall be set to null. </summary>
        public ResourceIdentifier AzureStorageAccountId { get; }
        /// <summary> The datastores of the on-premise machine Value can be list of strings that contain datastore names. </summary>
        public IReadOnlyList<string> Datastores { get; }
        /// <summary> The validation errors of the on-premise machine Value can be list of validation errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> ValidationErrors { get; }
        /// <summary> The last RPO calculated time. </summary>
        public DateTimeOffset? LastRpoCalculatedOn { get; }
        /// <summary> The last update time received from on-prem components. </summary>
        public DateTimeOffset? LastUpdateReceivedOn { get; }
        /// <summary> The replica id of the protected item. </summary>
        public string ReplicaId { get; }
        /// <summary> The OS Version of the protected item. </summary>
        public string OSVersion { get; }
        /// <summary> A value indicating whether additional IR stats are available or not. </summary>
        public bool? IsAdditionalStatsAvailable { get; }
        /// <summary> The total transferred data in bytes. </summary>
        public long? TotalDataTransferred { get; }
        /// <summary> The progress health. </summary>
        public string TotalProgressHealth { get; }
    }
}