// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan A2A failover input. </summary>
    public partial class RecoveryPlanA2AFailoverContent : RecoveryPlanProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of RecoveryPlanA2AFailoverContent. </summary>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        public RecoveryPlanA2AFailoverContent(A2ARpRecoveryPointType recoveryPointType)
        {
            RecoveryPointType = recoveryPointType;
            InstanceType = "A2A";
        }

        /// <summary> The recovery point type. </summary>
        public A2ARpRecoveryPointType RecoveryPointType { get; }
        /// <summary> A value indicating whether to use recovery cloud service for TFO or not. </summary>
        public string CloudServiceCreationOption { get; set; }
        /// <summary> A value indicating whether multi VM sync enabled VMs should use multi VM sync points for failover. </summary>
        public MultiVmSyncPointOption? MultiVmSyncPointOption { get; set; }
    }
}