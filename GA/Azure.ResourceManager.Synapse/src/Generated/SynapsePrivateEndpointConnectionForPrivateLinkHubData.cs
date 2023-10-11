// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary> A class representing the SynapsePrivateEndpointConnectionForPrivateLinkHub data model. </summary>
    public partial class SynapsePrivateEndpointConnectionForPrivateLinkHubData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapsePrivateEndpointConnectionForPrivateLinkHubData. </summary>
        internal SynapsePrivateEndpointConnectionForPrivateLinkHubData()
        {
        }

        /// <summary> Initializes a new instance of SynapsePrivateEndpointConnectionForPrivateLinkHubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of a private endpoint connection. </param>
        internal SynapsePrivateEndpointConnectionForPrivateLinkHubData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SynapsePrivateEndpointConnectionProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of a private endpoint connection. </summary>
        public SynapsePrivateEndpointConnectionProperties Properties { get; }
    }
}