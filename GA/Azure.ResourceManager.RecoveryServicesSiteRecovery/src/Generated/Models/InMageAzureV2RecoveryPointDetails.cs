// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMage Azure V2 provider specific recovery point details. </summary>
    public partial class InMageAzureV2RecoveryPointDetails : ProviderSpecificRecoveryPointDetails
    {
        /// <summary> Initializes a new instance of InMageAzureV2RecoveryPointDetails. </summary>
        internal InMageAzureV2RecoveryPointDetails()
        {
            InstanceType = "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of InMageAzureV2RecoveryPointDetails. </summary>
        /// <param name="instanceType"> Gets the provider type. </param>
        /// <param name="isMultiVmSyncPoint"> A value indicating whether the recovery point is multi VM consistent. </param>
        internal InMageAzureV2RecoveryPointDetails(string instanceType, string isMultiVmSyncPoint) : base(instanceType)
        {
            IsMultiVmSyncPoint = isMultiVmSyncPoint;
            InstanceType = instanceType ?? "InMageAzureV2";
        }

        /// <summary> A value indicating whether the recovery point is multi VM consistent. </summary>
        public string IsMultiVmSyncPoint { get; }
    }
}