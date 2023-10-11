// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing the ContainerRegistryPrivateEndpointConnection data model.
    /// An object that represents a private endpoint connection for a container registry.
    /// </summary>
    public partial class ContainerRegistryPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of ContainerRegistryPrivateEndpointConnectionData. </summary>
        public ContainerRegistryPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> The resource of private endpoint. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of private endpoint connection resource. </param>
        internal ContainerRegistryPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WritableSubResource privateEndpoint, ContainerRegistryPrivateLinkServiceConnectionState connectionState, ContainerRegistryProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The resource of private endpoint. </summary>
        internal WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
            set
            {
                if (PrivateEndpoint is null)
                    PrivateEndpoint = new WritableSubResource();
                PrivateEndpoint.Id = value;
            }
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public ContainerRegistryPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of private endpoint connection resource. </summary>
        public ContainerRegistryProvisioningState? ProvisioningState { get; }
    }
}