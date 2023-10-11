// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of the routing intent result and a URL nextLink to get the next set of results. </summary>
    internal partial class ListRoutingIntentResult
    {
        /// <summary> Initializes a new instance of ListRoutingIntentResult. </summary>
        internal ListRoutingIntentResult()
        {
            Value = new ChangeTrackingList<RoutingIntentData>();
        }

        /// <summary> Initializes a new instance of ListRoutingIntentResult. </summary>
        /// <param name="value"> List of RoutingIntent resource. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListRoutingIntentResult(IReadOnlyList<RoutingIntentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of RoutingIntent resource. </summary>
        public IReadOnlyList<RoutingIntentData> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}