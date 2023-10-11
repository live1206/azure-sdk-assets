// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownEventProviderSpecificDetails. </summary>
    internal partial class UnknownEventProviderSpecificDetails : SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of UnknownEventProviderSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal UnknownEventProviderSpecificDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}