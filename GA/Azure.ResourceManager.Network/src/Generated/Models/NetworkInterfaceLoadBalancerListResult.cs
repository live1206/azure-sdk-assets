// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for list ip configurations API service call. </summary>
    internal partial class NetworkInterfaceLoadBalancerListResult
    {
        /// <summary> Initializes a new instance of NetworkInterfaceLoadBalancerListResult. </summary>
        internal NetworkInterfaceLoadBalancerListResult()
        {
            Value = new ChangeTrackingList<LoadBalancerData>();
        }

        /// <summary> Initializes a new instance of NetworkInterfaceLoadBalancerListResult. </summary>
        /// <param name="value"> A list of load balancers. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal NetworkInterfaceLoadBalancerListResult(IReadOnlyList<LoadBalancerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of load balancers. </summary>
        public IReadOnlyList<LoadBalancerData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
