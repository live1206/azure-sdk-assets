// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Recovery point specific to PointInTime in SAPHana. </summary>
    public partial class WorkloadSapHanaPointInTimeRecoveryPoint : WorkloadPointInTimeRecoveryPoint
    {
        /// <summary> Initializes a new instance of WorkloadSapHanaPointInTimeRecoveryPoint. </summary>
        public WorkloadSapHanaPointInTimeRecoveryPoint()
        {
            ObjectType = "AzureWorkloadSAPHanaPointInTimeRecoveryPoint";
        }

        /// <summary> Initializes a new instance of WorkloadSapHanaPointInTimeRecoveryPoint. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryPointCreatedOn"> UTC time at which recovery point was created. </param>
        /// <param name="restorePointType"> Type of restore point. </param>
        /// <param name="recoveryPointTierDetails"> Recovery point tier information. </param>
        /// <param name="recoveryPointMoveReadinessInfo"> Eligibility of RP to be moved to another tier. </param>
        /// <param name="recoveryPointProperties"> Properties of Recovery Point. </param>
        /// <param name="timeRanges"> List of log ranges. </param>
        internal WorkloadSapHanaPointInTimeRecoveryPoint(string objectType, DateTimeOffset? recoveryPointCreatedOn, RestorePointType? restorePointType, IList<RecoveryPointTierInformationV2> recoveryPointTierDetails, IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo, RecoveryPointProperties recoveryPointProperties, IList<PointInTimeRange> timeRanges) : base(objectType, recoveryPointCreatedOn, restorePointType, recoveryPointTierDetails, recoveryPointMoveReadinessInfo, recoveryPointProperties, timeRanges)
        {
            ObjectType = objectType ?? "AzureWorkloadSAPHanaPointInTimeRecoveryPoint";
        }
    }
}