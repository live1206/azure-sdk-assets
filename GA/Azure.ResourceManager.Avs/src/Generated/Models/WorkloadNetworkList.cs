// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A list of workload networks. </summary>
    internal partial class WorkloadNetworkList
    {
        /// <summary> Initializes a new instance of WorkloadNetworkList. </summary>
        internal WorkloadNetworkList()
        {
            Value = new ChangeTrackingList<WorkloadNetworkData>();
        }

        /// <summary> Initializes a new instance of WorkloadNetworkList. </summary>
        /// <param name="value"> The items on the page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal WorkloadNetworkList(IReadOnlyList<WorkloadNetworkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on the page. </summary>
        public IReadOnlyList<WorkloadNetworkData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
