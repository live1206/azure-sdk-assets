// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownProviderSpecificRecoveryPointDetails. </summary>
    internal partial class UnknownProviderSpecificRecoveryPointDetails : ProviderSpecificRecoveryPointDetails
    {
        /// <summary> Initializes a new instance of UnknownProviderSpecificRecoveryPointDetails. </summary>
        /// <param name="instanceType"> Gets the provider type. </param>
        internal UnknownProviderSpecificRecoveryPointDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}