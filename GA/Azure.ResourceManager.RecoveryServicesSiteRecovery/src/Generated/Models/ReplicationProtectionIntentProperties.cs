// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Replication protection intent custom data details. </summary>
    public partial class ReplicationProtectionIntentProperties
    {
        /// <summary> Initializes a new instance of ReplicationProtectionIntentProperties. </summary>
        internal ReplicationProtectionIntentProperties()
        {
        }

        /// <summary> Initializes a new instance of ReplicationProtectionIntentProperties. </summary>
        /// <param name="friendlyName"> The name. </param>
        /// <param name="jobId"> The job Id. </param>
        /// <param name="jobState"> The job state. </param>
        /// <param name="isActive"> A value indicating whether the intent object is active. </param>
        /// <param name="createdOn"> The creation time in UTC. </param>
        /// <param name="providerSpecificDetails">
        /// The Replication provider custom settings.
        /// Please note <see cref="ReplicationProtectionIntentProviderSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AReplicationIntentDetails"/>.
        /// </param>
        internal ReplicationProtectionIntentProperties(string friendlyName, ResourceIdentifier jobId, string jobState, bool? isActive, string createdOn, ReplicationProtectionIntentProviderSpecificSettings providerSpecificDetails)
        {
            FriendlyName = friendlyName;
            JobId = jobId;
            JobState = jobState;
            IsActive = isActive;
            CreatedOn = createdOn;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary> The name. </summary>
        public string FriendlyName { get; }
        /// <summary> The job Id. </summary>
        public ResourceIdentifier JobId { get; }
        /// <summary> The job state. </summary>
        public string JobState { get; }
        /// <summary> A value indicating whether the intent object is active. </summary>
        public bool? IsActive { get; }
        /// <summary> The creation time in UTC. </summary>
        public string CreatedOn { get; }
        /// <summary>
        /// The Replication provider custom settings.
        /// Please note <see cref="ReplicationProtectionIntentProviderSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AReplicationIntentDetails"/>.
        /// </summary>
        public ReplicationProtectionIntentProviderSpecificSettings ProviderSpecificDetails { get; }
    }
}
