// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Virtual Network Gateway Autoscale Configuration details. </summary>
    internal partial class VirtualNetworkGatewayAutoScaleConfiguration
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayAutoScaleConfiguration. </summary>
        public VirtualNetworkGatewayAutoScaleConfiguration()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayAutoScaleConfiguration. </summary>
        /// <param name="bounds"> The bounds of the autoscale configuration. </param>
        internal VirtualNetworkGatewayAutoScaleConfiguration(VirtualNetworkGatewayAutoScaleBounds bounds)
        {
            Bounds = bounds;
        }

        /// <summary> The bounds of the autoscale configuration. </summary>
        public VirtualNetworkGatewayAutoScaleBounds Bounds { get; set; }
    }
}