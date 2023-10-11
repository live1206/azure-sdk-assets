// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The paginated list of received routes for the peering. </summary>
    internal partial class PeeringReceivedRouteListResult
    {
        /// <summary> Initializes a new instance of PeeringReceivedRouteListResult. </summary>
        internal PeeringReceivedRouteListResult()
        {
            Value = new ChangeTrackingList<PeeringReceivedRoute>();
        }

        /// <summary> Initializes a new instance of PeeringReceivedRouteListResult. </summary>
        /// <param name="value"> The list of received routes for the peering. </param>
        /// <param name="nextLink"> The link to fetch the next page of received routes for the peering. </param>
        internal PeeringReceivedRouteListResult(IReadOnlyList<PeeringReceivedRoute> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of received routes for the peering. </summary>
        public IReadOnlyList<PeeringReceivedRoute> Value { get; }
        /// <summary> The link to fetch the next page of received routes for the peering. </summary>
        public string NextLink { get; }
    }
}