// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Cluster list results. </summary>
    internal partial class ServiceFabricClusterListResult
    {
        /// <summary> Initializes a new instance of ServiceFabricClusterListResult. </summary>
        internal ServiceFabricClusterListResult()
        {
            Value = new ChangeTrackingList<ServiceFabricClusterData>();
        }

        /// <summary> Initializes a new instance of ServiceFabricClusterListResult. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ServiceFabricClusterListResult(IReadOnlyList<ServiceFabricClusterData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ServiceFabricClusterData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}