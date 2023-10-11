// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The parameters specifying the connection resource whose inbound routes are being requested. </summary>
    public partial class VirtualHubInboundRoutesContent
    {
        /// <summary> Initializes a new instance of VirtualHubInboundRoutesContent. </summary>
        public VirtualHubInboundRoutesContent()
        {
        }

        /// <summary> The connection resource whose inbound routes are being requested. </summary>
        public Uri ResourceUri { get; set; }
        /// <summary> The type of the specified connection resource like ExpressRouteConnection, HubVirtualNetworkConnection, VpnConnection and P2SConnection. </summary>
        public string ConnectionType { get; set; }
    }
}