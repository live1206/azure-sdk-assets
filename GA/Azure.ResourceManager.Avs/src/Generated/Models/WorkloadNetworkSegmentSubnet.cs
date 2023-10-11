// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Subnet configuration for segment. </summary>
    public partial class WorkloadNetworkSegmentSubnet
    {
        /// <summary> Initializes a new instance of WorkloadNetworkSegmentSubnet. </summary>
        public WorkloadNetworkSegmentSubnet()
        {
            DhcpRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WorkloadNetworkSegmentSubnet. </summary>
        /// <param name="dhcpRanges"> DHCP Range assigned for subnet. </param>
        /// <param name="gatewayAddress"> Gateway address. </param>
        internal WorkloadNetworkSegmentSubnet(IList<string> dhcpRanges, string gatewayAddress)
        {
            DhcpRanges = dhcpRanges;
            GatewayAddress = gatewayAddress;
        }

        /// <summary> DHCP Range assigned for subnet. </summary>
        public IList<string> DhcpRanges { get; }
        /// <summary> Gateway address. </summary>
        public string GatewayAddress { get; set; }
    }
}