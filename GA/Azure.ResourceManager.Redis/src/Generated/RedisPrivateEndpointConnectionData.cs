// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Redis.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Redis
{
    /// <summary>
    /// A class representing the RedisPrivateEndpointConnection data model.
    /// The Private Endpoint Connection resource.
    /// </summary>
    public partial class RedisPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of RedisPrivateEndpointConnectionData. </summary>
        public RedisPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of RedisPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="redisPrivateLinkServiceConnectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="redisProvisioningState"> The provisioning state of the private endpoint connection resource. </param>
        internal RedisPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubResource privateEndpoint, RedisPrivateLinkServiceConnectionState redisPrivateLinkServiceConnectionState, RedisPrivateEndpointConnectionProvisioningState? redisProvisioningState) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            RedisPrivateLinkServiceConnectionState = redisPrivateLinkServiceConnectionState;
            RedisProvisioningState = redisProvisioningState;
        }

        /// <summary> The resource of private end point. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public RedisPrivateLinkServiceConnectionState RedisPrivateLinkServiceConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public RedisPrivateEndpointConnectionProvisioningState? RedisProvisioningState { get; }
    }
}
