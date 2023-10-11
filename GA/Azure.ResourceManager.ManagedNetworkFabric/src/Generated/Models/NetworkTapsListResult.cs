// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of NetworkTaps. </summary>
    internal partial class NetworkTapsListResult
    {
        /// <summary> Initializes a new instance of NetworkTapsListResult. </summary>
        internal NetworkTapsListResult()
        {
            Value = new ChangeTrackingList<NetworkTapData>();
        }

        /// <summary> Initializes a new instance of NetworkTapsListResult. </summary>
        /// <param name="value"> List of NetworkTap resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal NetworkTapsListResult(IReadOnlyList<NetworkTapData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of NetworkTap resources. </summary>
        public IReadOnlyList<NetworkTapData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}