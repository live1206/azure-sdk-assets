// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The parameters specifying the resource whose effective routes are being requested. </summary>
    public partial class EffectiveRoutesContent
    {
        /// <summary> Initializes a new instance of EffectiveRoutesContent. </summary>
        public EffectiveRoutesContent()
        {
        }

        /// <summary> The resource whose effective routes are being requested. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The type of the specified resource like RouteTable, ExpressRouteConnection, HubVirtualNetworkConnection, VpnConnection and P2SConnection. </summary>
        public string VirtualWanResourceType { get; set; }
    }
}