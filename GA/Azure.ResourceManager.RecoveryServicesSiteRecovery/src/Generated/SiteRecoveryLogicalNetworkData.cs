// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the SiteRecoveryLogicalNetwork data model.
    /// Logical network data model.
    /// </summary>
    public partial class SiteRecoveryLogicalNetworkData : ResourceData
    {
        /// <summary> Initializes a new instance of SiteRecoveryLogicalNetworkData. </summary>
        internal SiteRecoveryLogicalNetworkData()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryLogicalNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The Logical Network Properties. </param>
        /// <param name="location"> Resource Location. </param>
        internal SiteRecoveryLogicalNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SiteRecoveryLogicalNetworkProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> The Logical Network Properties. </summary>
        public SiteRecoveryLogicalNetworkProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}