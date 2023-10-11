// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Replication appliance properties. </summary>
    internal partial class SiteRecoveryReplicationApplianceProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryReplicationApplianceProperties. </summary>
        internal SiteRecoveryReplicationApplianceProperties()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryReplicationApplianceProperties. </summary>
        /// <param name="providerSpecificDetails">
        /// Provider specific settings.
        /// Please note <see cref="SiteRecoveryApplianceSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmApplianceSpecificDetails"/>.
        /// </param>
        internal SiteRecoveryReplicationApplianceProperties(SiteRecoveryApplianceSpecificDetails providerSpecificDetails)
        {
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// Provider specific settings.
        /// Please note <see cref="SiteRecoveryApplianceSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmApplianceSpecificDetails"/>.
        /// </summary>
        public SiteRecoveryApplianceSpecificDetails ProviderSpecificDetails { get; }
    }
}