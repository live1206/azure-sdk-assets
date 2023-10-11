// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Infra network profile for the NetworkCloud platform. </summary>
    internal partial class VirtualNetworksPropertiesInfraVnetProfileNetworkCloud
    {
        /// <summary> Initializes a new instance of VirtualNetworksPropertiesInfraVnetProfileNetworkCloud. </summary>
        public VirtualNetworksPropertiesInfraVnetProfileNetworkCloud()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworksPropertiesInfraVnetProfileNetworkCloud. </summary>
        /// <param name="networkId"> The ARM ID of Network Cloud Network Resource to Associate with this VirtualNetwork. </param>
        internal VirtualNetworksPropertiesInfraVnetProfileNetworkCloud(string networkId)
        {
            NetworkId = networkId;
        }

        /// <summary> The ARM ID of Network Cloud Network Resource to Associate with this VirtualNetwork. </summary>
        public string NetworkId { get; set; }
    }
}