// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The resource names object for network interface and related resources. </summary>
    public partial class NetworkInterfaceResourceNames
    {
        /// <summary> Initializes a new instance of NetworkInterfaceResourceNames. </summary>
        public NetworkInterfaceResourceNames()
        {
        }

        /// <summary> Initializes a new instance of NetworkInterfaceResourceNames. </summary>
        /// <param name="networkInterfaceName"> The full name for network interface. If name is not provided, service uses a default name based on the deployment type. For SingleServer, default name is {SID}-Nic. In case of HA-AvZone systems, default name will be {SID}-{App/ASCS/DB}-Zone{A/B}-Nic with an incrementor at the end in case of more than 1 instance per layer. For distributed and HA-AvSet systems, default name will be {SID}-{App/ASCS/DB}-Nic with an incrementor at the end in case of more than 1 instance per layer. </param>
        internal NetworkInterfaceResourceNames(string networkInterfaceName)
        {
            NetworkInterfaceName = networkInterfaceName;
        }

        /// <summary> The full name for network interface. If name is not provided, service uses a default name based on the deployment type. For SingleServer, default name is {SID}-Nic. In case of HA-AvZone systems, default name will be {SID}-{App/ASCS/DB}-Zone{A/B}-Nic with an incrementor at the end in case of more than 1 instance per layer. For distributed and HA-AvSet systems, default name will be {SID}-{App/ASCS/DB}-Nic with an incrementor at the end in case of more than 1 instance per layer. </summary>
        public string NetworkInterfaceName { get; set; }
    }
}