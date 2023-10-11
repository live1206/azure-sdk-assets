// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Network Interface model. </summary>
    public partial class NetworkInterfaces
    {
        /// <summary> Initializes a new instance of NetworkInterfaces. </summary>
        public NetworkInterfaces()
        {
            IPv4Addresses = new ChangeTrackingList<string>();
            IPv6Addresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkInterfaces. </summary>
        /// <param name="name"> Gets or sets the name of the network interface. </param>
        /// <param name="displayName"> Gets the display name of the network interface as shown in the vmmServer. This is the fallback label for a NIC when the name is not set. </param>
        /// <param name="ipv4Addresses"> Gets or sets the nic ipv4 addresses. </param>
        /// <param name="ipv6Addresses"> Gets or sets the nic ipv6 addresses. </param>
        /// <param name="macAddress"> Gets or sets the nic MAC address. </param>
        /// <param name="virtualNetworkId"> Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic. </param>
        /// <param name="networkName"> Gets or sets the name of the virtual network in vmmServer that the nic is connected to. </param>
        /// <param name="ipv4AddressType"> Gets or sets the ipv4 address type. </param>
        /// <param name="ipv6AddressType"> Gets or sets the ipv6 address type. </param>
        /// <param name="macAddressType"> Gets or sets the mac address type. </param>
        /// <param name="nicId"> Gets or sets the nic id. </param>
        internal NetworkInterfaces(string name, string displayName, IReadOnlyList<string> ipv4Addresses, IReadOnlyList<string> ipv6Addresses, string macAddress, string virtualNetworkId, string networkName, AllocationMethod? ipv4AddressType, AllocationMethod? ipv6AddressType, AllocationMethod? macAddressType, string nicId)
        {
            Name = name;
            DisplayName = displayName;
            IPv4Addresses = ipv4Addresses;
            IPv6Addresses = ipv6Addresses;
            MacAddress = macAddress;
            VirtualNetworkId = virtualNetworkId;
            NetworkName = networkName;
            IPv4AddressType = ipv4AddressType;
            IPv6AddressType = ipv6AddressType;
            MacAddressType = macAddressType;
            NicId = nicId;
        }

        /// <summary> Gets or sets the name of the network interface. </summary>
        public string Name { get; set; }
        /// <summary> Gets the display name of the network interface as shown in the vmmServer. This is the fallback label for a NIC when the name is not set. </summary>
        public string DisplayName { get; }
        /// <summary> Gets or sets the nic ipv4 addresses. </summary>
        public IReadOnlyList<string> IPv4Addresses { get; }
        /// <summary> Gets or sets the nic ipv6 addresses. </summary>
        public IReadOnlyList<string> IPv6Addresses { get; }
        /// <summary> Gets or sets the nic MAC address. </summary>
        public string MacAddress { get; set; }
        /// <summary> Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic. </summary>
        public string VirtualNetworkId { get; set; }
        /// <summary> Gets or sets the name of the virtual network in vmmServer that the nic is connected to. </summary>
        public string NetworkName { get; }
        /// <summary> Gets or sets the ipv4 address type. </summary>
        public AllocationMethod? IPv4AddressType { get; set; }
        /// <summary> Gets or sets the ipv6 address type. </summary>
        public AllocationMethod? IPv6AddressType { get; set; }
        /// <summary> Gets or sets the mac address type. </summary>
        public AllocationMethod? MacAddressType { get; set; }
        /// <summary> Gets or sets the nic id. </summary>
        public string NicId { get; set; }
    }
}