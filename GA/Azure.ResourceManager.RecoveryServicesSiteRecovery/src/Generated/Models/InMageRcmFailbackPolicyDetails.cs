// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm failback specific policy details. </summary>
    public partial class InMageRcmFailbackPolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of InMageRcmFailbackPolicyDetails. </summary>
        internal InMageRcmFailbackPolicyDetails()
        {
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> Initializes a new instance of InMageRcmFailbackPolicyDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="appConsistentFrequencyInMinutes"> The app consistent snapshot frequency in minutes. </param>
        /// <param name="crashConsistentFrequencyInMinutes"> The crash consistent snapshot frequency in minutes. </param>
        internal InMageRcmFailbackPolicyDetails(string instanceType, int? appConsistentFrequencyInMinutes, int? crashConsistentFrequencyInMinutes) : base(instanceType)
        {
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            InstanceType = instanceType ?? "InMageRcmFailback";
        }

        /// <summary> The app consistent snapshot frequency in minutes. </summary>
        public int? AppConsistentFrequencyInMinutes { get; }
        /// <summary> The crash consistent snapshot frequency in minutes. </summary>
        public int? CrashConsistentFrequencyInMinutes { get; }
    }
}