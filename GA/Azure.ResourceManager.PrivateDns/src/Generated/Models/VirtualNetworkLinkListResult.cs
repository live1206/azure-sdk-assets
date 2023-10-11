// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> The response to a list virtual network link to Private DNS zone operation. </summary>
    internal partial class VirtualNetworkLinkListResult
    {
        /// <summary> Initializes a new instance of VirtualNetworkLinkListResult. </summary>
        internal VirtualNetworkLinkListResult()
        {
            Value = new ChangeTrackingList<VirtualNetworkLinkData>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkLinkListResult. </summary>
        /// <param name="value"> Information about the virtual network links to the Private DNS zones. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        internal VirtualNetworkLinkListResult(IReadOnlyList<VirtualNetworkLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Information about the virtual network links to the Private DNS zones. </summary>
        public IReadOnlyList<VirtualNetworkLinkData> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}