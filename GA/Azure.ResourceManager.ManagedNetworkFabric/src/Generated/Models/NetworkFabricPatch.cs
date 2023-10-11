// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The Network Fabric resource definition. </summary>
    public partial class NetworkFabricPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of NetworkFabricPatch. </summary>
        public NetworkFabricPatch()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Number of compute racks associated to Network Fabric. </summary>
        public int? RackCount { get; set; }
        /// <summary> Number of servers.Possible values are from 1-16. </summary>
        public int? ServerCountPerRack { get; set; }
        /// <summary> IPv4Prefix for Management Network. Example: 10.1.0.0/19. </summary>
        public string IPv4Prefix { get; set; }
        /// <summary> IPv6Prefix for Management Network. Example: 3FFE:FFFF:0:CD40::/59. </summary>
        public string IPv6Prefix { get; set; }
        /// <summary> ASN of CE devices for CE/PE connectivity. </summary>
        public long? FabricAsn { get; set; }
        /// <summary> Network and credentials configuration already applied to terminal server. </summary>
        public NetworkFabricPatchablePropertiesTerminalServerConfiguration TerminalServerConfiguration { get; set; }
        /// <summary> Configuration to be used to setup the management network. </summary>
        public ManagementNetworkConfigurationPatchableProperties ManagementNetworkConfiguration { get; set; }
    }
}