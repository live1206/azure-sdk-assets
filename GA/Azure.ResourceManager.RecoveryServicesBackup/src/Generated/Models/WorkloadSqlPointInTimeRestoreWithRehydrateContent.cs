// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> AzureWorkload SQL-specific restore with integrated rehydration of recovery point. </summary>
    public partial class WorkloadSqlPointInTimeRestoreWithRehydrateContent : WorkloadSqlPointInTimeRestoreContent
    {
        /// <summary> Initializes a new instance of WorkloadSqlPointInTimeRestoreWithRehydrateContent. </summary>
        public WorkloadSqlPointInTimeRestoreWithRehydrateContent()
        {
            ObjectType = "AzureWorkloadSQLPointInTimeRestoreWithRehydrateRequest";
        }

        /// <summary> Initializes a new instance of WorkloadSqlPointInTimeRestoreWithRehydrateContent. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryType"> Type of this recovery. </param>
        /// <param name="sourceResourceId"> Fully qualified ARM ID of the VM on which workload that was running is being recovered. </param>
        /// <param name="propertyBag"> Workload specific property bag. </param>
        /// <param name="targetInfo"> Details of target database. </param>
        /// <param name="recoveryMode"> Defines whether the current recovery mode is file restore or database restore. </param>
        /// <param name="targetVirtualMachineId">
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </param>
        /// <param name="shouldUseAlternateTargetLocation"> Default option set to true. If this is set to false, alternate data directory must be provided. </param>
        /// <param name="isNonRecoverable"> SQL specific property where user can chose to set no-recovery when restore operation is tried. </param>
        /// <param name="alternateDirectoryPaths"> Data directory details. </param>
        /// <param name="pointInTime"> PointInTime value. </param>
        /// <param name="recoveryPointRehydrationInfo"> RP Rehydration Info. </param>
        internal WorkloadSqlPointInTimeRestoreWithRehydrateContent(string objectType, FileShareRecoveryType? recoveryType, ResourceIdentifier sourceResourceId, IDictionary<string, string> propertyBag, TargetRestoreInfo targetInfo, RecoveryMode? recoveryMode, ResourceIdentifier targetVirtualMachineId, bool? shouldUseAlternateTargetLocation, bool? isNonRecoverable, IList<SqlDataDirectoryMapping> alternateDirectoryPaths, DateTimeOffset? pointInTime, RecoveryPointRehydrationInfo recoveryPointRehydrationInfo) : base(objectType, recoveryType, sourceResourceId, propertyBag, targetInfo, recoveryMode, targetVirtualMachineId, shouldUseAlternateTargetLocation, isNonRecoverable, alternateDirectoryPaths, pointInTime)
        {
            RecoveryPointRehydrationInfo = recoveryPointRehydrationInfo;
            ObjectType = objectType ?? "AzureWorkloadSQLPointInTimeRestoreWithRehydrateRequest";
        }

        /// <summary> RP Rehydration Info. </summary>
        public RecoveryPointRehydrationInfo RecoveryPointRehydrationInfo { get; set; }
    }
}
