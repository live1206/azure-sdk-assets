// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of VirtualHubRouteTableV2s and a URL nextLink to get the next set of results. </summary>
    internal partial class ListVirtualHubRouteTableV2SResult
    {
        /// <summary> Initializes a new instance of ListVirtualHubRouteTableV2SResult. </summary>
        internal ListVirtualHubRouteTableV2SResult()
        {
            Value = new ChangeTrackingList<VirtualHubRouteTableV2Data>();
        }

        /// <summary> Initializes a new instance of ListVirtualHubRouteTableV2SResult. </summary>
        /// <param name="value"> List of VirtualHubRouteTableV2s. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListVirtualHubRouteTableV2SResult(IReadOnlyList<VirtualHubRouteTableV2Data> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VirtualHubRouteTableV2s. </summary>
        public IReadOnlyList<VirtualHubRouteTableV2Data> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}