// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the VirtualHubRouteTableV2 data model.
    /// VirtualHubRouteTableV2 Resource.
    /// </summary>
    public partial class VirtualHubRouteTableV2Data : NetworkResourceData
    {
        /// <summary> Initializes a new instance of VirtualHubRouteTableV2Data. </summary>
        public VirtualHubRouteTableV2Data()
        {
            Routes = new ChangeTrackingList<VirtualHubRouteV2>();
            AttachedConnections = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualHubRouteTableV2Data. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="routes"> List of all routes. </param>
        /// <param name="attachedConnections"> List of all connections attached to this route table v2. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual hub route table v2 resource. </param>
        internal VirtualHubRouteTableV2Data(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, IList<VirtualHubRouteV2> routes, IList<string> attachedConnections, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            Routes = routes;
            AttachedConnections = attachedConnections;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> List of all routes. </summary>
        public IList<VirtualHubRouteV2> Routes { get; }
        /// <summary> List of all connections attached to this route table v2. </summary>
        public IList<string> AttachedConnections { get; }
        /// <summary> The provisioning state of the virtual hub route table v2 resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}