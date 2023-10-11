// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input definition for unplanned failover input properties. </summary>
    public partial class UnplannedFailoverProperties
    {
        /// <summary> Initializes a new instance of UnplannedFailoverProperties. </summary>
        public UnplannedFailoverProperties()
        {
        }

        /// <summary> Failover direction. </summary>
        public string FailoverDirection { get; set; }
        /// <summary> Source site operations status. </summary>
        public string SourceSiteOperations { get; set; }
        /// <summary>
        /// Provider specific settings.
        /// Please note <see cref="UnplannedFailoverProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AUnplannedFailoverContent"/>, <see cref="HyperVReplicaAzureUnplannedFailoverContent"/>, <see cref="InMageUnplannedFailoverContent"/>, <see cref="InMageAzureV2UnplannedFailoverContent"/> and <see cref="InMageRcmUnplannedFailoverContent"/>.
        /// </summary>
        public UnplannedFailoverProviderSpecificContent ProviderSpecificDetails { get; set; }
    }
}