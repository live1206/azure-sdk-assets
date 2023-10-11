// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapsePrivateLinkHub data model.
    /// A privateLinkHub
    /// </summary>
    public partial class SynapsePrivateLinkHubData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SynapsePrivateLinkHubData. </summary>
        /// <param name="location"> The location. </param>
        public SynapsePrivateLinkHubData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionForPrivateLinkHubBasic>();
        }

        /// <summary> Initializes a new instance of SynapsePrivateLinkHubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> PrivateLinkHub provisioning state. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        internal SynapsePrivateLinkHubData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string provisioningState, IReadOnlyList<PrivateEndpointConnectionForPrivateLinkHubBasic> privateEndpointConnections) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> PrivateLinkHub provisioning state. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> List of private endpoint connections. </summary>
        public IReadOnlyList<PrivateEndpointConnectionForPrivateLinkHubBasic> PrivateEndpointConnections { get; }
    }
}
