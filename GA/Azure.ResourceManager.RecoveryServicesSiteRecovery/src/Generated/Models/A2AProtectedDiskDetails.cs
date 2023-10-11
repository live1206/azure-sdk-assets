// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A protected disk details. </summary>
    public partial class A2AProtectedDiskDetails
    {
        /// <summary> Initializes a new instance of A2AProtectedDiskDetails. </summary>
        internal A2AProtectedDiskDetails()
        {
            AllowedDiskLevelOperation = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of A2AProtectedDiskDetails. </summary>
        /// <param name="diskUri"> The disk uri. </param>
        /// <param name="recoveryAzureStorageAccountId"> The recovery disk storage account. </param>
        /// <param name="primaryDiskAzureStorageAccountId"> The primary disk storage account. </param>
        /// <param name="recoveryDiskUri"> Recovery disk uri. </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="diskCapacityInBytes"> The disk capacity in bytes. </param>
        /// <param name="primaryStagingAzureStorageAccountId"> The primary staging storage account. </param>
        /// <param name="diskType"> The type of disk. </param>
        /// <param name="isResyncRequired"> A value indicating whether resync is required for this disk. </param>
        /// <param name="monitoringPercentageCompletion"> The percentage of the monitoring job. The type of the monitoring job is defined by MonitoringJobType property. </param>
        /// <param name="monitoringJobType"> The type of the monitoring job. The progress is contained in MonitoringPercentageCompletion property. </param>
        /// <param name="dataPendingInStagingStorageAccountInMB"> The data pending for replication in MB at staging account. </param>
        /// <param name="dataPendingAtSourceAgentInMB"> The data pending at source virtual machine in MB. </param>
        /// <param name="diskState"> The disk state. </param>
        /// <param name="allowedDiskLevelOperation"> The disk level operations list. </param>
        /// <param name="isDiskEncrypted"> A value indicating whether vm has encrypted os disk or not. </param>
        /// <param name="secretIdentifier"> The secret URL / identifier (BEK). </param>
        /// <param name="dekKeyVaultArmId"> The KeyVault resource id for secret (BEK). </param>
        /// <param name="isDiskKeyEncrypted"> A value indicating whether disk key got encrypted or not. </param>
        /// <param name="keyIdentifier"> The key URL / identifier (KEK). </param>
        /// <param name="kekKeyVaultArmId"> The KeyVault resource id for key (KEK). </param>
        /// <param name="failoverDiskName"> The failover name for the managed disk. </param>
        /// <param name="tfoDiskName"> The test failover name for the managed disk. </param>
        internal A2AProtectedDiskDetails(Uri diskUri, ResourceIdentifier recoveryAzureStorageAccountId, ResourceIdentifier primaryDiskAzureStorageAccountId, Uri recoveryDiskUri, string diskName, long? diskCapacityInBytes, ResourceIdentifier primaryStagingAzureStorageAccountId, string diskType, bool? isResyncRequired, int? monitoringPercentageCompletion, string monitoringJobType, double? dataPendingInStagingStorageAccountInMB, double? dataPendingAtSourceAgentInMB, string diskState, IReadOnlyList<string> allowedDiskLevelOperation, bool? isDiskEncrypted, string secretIdentifier, ResourceIdentifier dekKeyVaultArmId, bool? isDiskKeyEncrypted, string keyIdentifier, ResourceIdentifier kekKeyVaultArmId, string failoverDiskName, string tfoDiskName)
        {
            DiskUri = diskUri;
            RecoveryAzureStorageAccountId = recoveryAzureStorageAccountId;
            PrimaryDiskAzureStorageAccountId = primaryDiskAzureStorageAccountId;
            RecoveryDiskUri = recoveryDiskUri;
            DiskName = diskName;
            DiskCapacityInBytes = diskCapacityInBytes;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            DiskType = diskType;
            IsResyncRequired = isResyncRequired;
            MonitoringPercentageCompletion = monitoringPercentageCompletion;
            MonitoringJobType = monitoringJobType;
            DataPendingInStagingStorageAccountInMB = dataPendingInStagingStorageAccountInMB;
            DataPendingAtSourceAgentInMB = dataPendingAtSourceAgentInMB;
            DiskState = diskState;
            AllowedDiskLevelOperation = allowedDiskLevelOperation;
            IsDiskEncrypted = isDiskEncrypted;
            SecretIdentifier = secretIdentifier;
            DekKeyVaultArmId = dekKeyVaultArmId;
            IsDiskKeyEncrypted = isDiskKeyEncrypted;
            KeyIdentifier = keyIdentifier;
            KekKeyVaultArmId = kekKeyVaultArmId;
            FailoverDiskName = failoverDiskName;
            TfoDiskName = tfoDiskName;
        }

        /// <summary> The disk uri. </summary>
        public Uri DiskUri { get; }
        /// <summary> The recovery disk storage account. </summary>
        public ResourceIdentifier RecoveryAzureStorageAccountId { get; }
        /// <summary> The primary disk storage account. </summary>
        public ResourceIdentifier PrimaryDiskAzureStorageAccountId { get; }
        /// <summary> Recovery disk uri. </summary>
        public Uri RecoveryDiskUri { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> The disk capacity in bytes. </summary>
        public long? DiskCapacityInBytes { get; }
        /// <summary> The primary staging storage account. </summary>
        public ResourceIdentifier PrimaryStagingAzureStorageAccountId { get; }
        /// <summary> The type of disk. </summary>
        public string DiskType { get; }
        /// <summary> A value indicating whether resync is required for this disk. </summary>
        public bool? IsResyncRequired { get; }
        /// <summary> The percentage of the monitoring job. The type of the monitoring job is defined by MonitoringJobType property. </summary>
        public int? MonitoringPercentageCompletion { get; }
        /// <summary> The type of the monitoring job. The progress is contained in MonitoringPercentageCompletion property. </summary>
        public string MonitoringJobType { get; }
        /// <summary> The data pending for replication in MB at staging account. </summary>
        public double? DataPendingInStagingStorageAccountInMB { get; }
        /// <summary> The data pending at source virtual machine in MB. </summary>
        public double? DataPendingAtSourceAgentInMB { get; }
        /// <summary> The disk state. </summary>
        public string DiskState { get; }
        /// <summary> The disk level operations list. </summary>
        public IReadOnlyList<string> AllowedDiskLevelOperation { get; }
        /// <summary> A value indicating whether vm has encrypted os disk or not. </summary>
        public bool? IsDiskEncrypted { get; }
        /// <summary> The secret URL / identifier (BEK). </summary>
        public string SecretIdentifier { get; }
        /// <summary> The KeyVault resource id for secret (BEK). </summary>
        public ResourceIdentifier DekKeyVaultArmId { get; }
        /// <summary> A value indicating whether disk key got encrypted or not. </summary>
        public bool? IsDiskKeyEncrypted { get; }
        /// <summary> The key URL / identifier (KEK). </summary>
        public string KeyIdentifier { get; }
        /// <summary> The KeyVault resource id for key (KEK). </summary>
        public ResourceIdentifier KekKeyVaultArmId { get; }
        /// <summary> The failover name for the managed disk. </summary>
        public string FailoverDiskName { get; }
        /// <summary> The test failover name for the managed disk. </summary>
        public string TfoDiskName { get; }
    }
}