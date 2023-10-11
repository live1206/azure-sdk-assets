// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Update replication protected item provider specific input.
    /// Please note <see cref="UpdateReplicationProtectedItemProviderContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2AUpdateReplicationProtectedItemContent"/>, <see cref="HyperVReplicaAzureUpdateReplicationProtectedItemContent"/>, <see cref="InMageAzureV2UpdateReplicationProtectedItemContent"/> and <see cref="InMageRcmUpdateReplicationProtectedItemContent"/>.
    /// </summary>
    public abstract partial class UpdateReplicationProtectedItemProviderContent
    {
        /// <summary> Initializes a new instance of UpdateReplicationProtectedItemProviderContent. </summary>
        protected UpdateReplicationProtectedItemProviderContent()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}