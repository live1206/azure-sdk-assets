// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary>
    /// A class representing the WebPubSubPrivateEndpointConnection data model.
    /// A private endpoint connection to an azure resource
    /// </summary>
    public partial class WebPubSubPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of WebPubSubPrivateEndpointConnectionData. </summary>
        public WebPubSubPrivateEndpointConnectionData()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WebPubSubPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="privateEndpoint"> Private endpoint. </param>
        /// <param name="groupIds"> Group IDs. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        internal WebPubSubPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WebPubSubProvisioningState? provisioningState, PrivateEndpoint privateEndpoint, IReadOnlyList<string> groupIds, WebPubSubPrivateLinkServiceConnectionState connectionState) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            GroupIds = groupIds;
            ConnectionState = connectionState;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public WebPubSubProvisioningState? ProvisioningState { get; }
        /// <summary> Private endpoint. </summary>
        internal PrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary> Full qualified Id of the private endpoint. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
            set
            {
                if (PrivateEndpoint is null)
                    PrivateEndpoint = new PrivateEndpoint();
                PrivateEndpoint.Id = value;
            }
        }

        /// <summary> Group IDs. </summary>
        public IReadOnlyList<string> GroupIds { get; }
        /// <summary> Connection state of the private endpoint connection. </summary>
        public WebPubSubPrivateLinkServiceConnectionState ConnectionState { get; set; }
    }
}