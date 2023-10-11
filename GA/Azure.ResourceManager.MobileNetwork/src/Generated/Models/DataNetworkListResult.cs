// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Response for data network API service call. </summary>
    internal partial class DataNetworkListResult
    {
        /// <summary> Initializes a new instance of DataNetworkListResult. </summary>
        internal DataNetworkListResult()
        {
            Value = new ChangeTrackingList<MobileDataNetworkData>();
        }

        /// <summary> Initializes a new instance of DataNetworkListResult. </summary>
        /// <param name="value"> A list of data networks. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal DataNetworkListResult(IReadOnlyList<MobileDataNetworkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of data networks. </summary>
        public IReadOnlyList<MobileDataNetworkData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}