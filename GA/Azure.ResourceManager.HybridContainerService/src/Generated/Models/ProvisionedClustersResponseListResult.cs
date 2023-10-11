// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The ProvisionedClustersResponseListResult. </summary>
    internal partial class ProvisionedClustersResponseListResult
    {
        /// <summary> Initializes a new instance of ProvisionedClustersResponseListResult. </summary>
        internal ProvisionedClustersResponseListResult()
        {
            Value = new ChangeTrackingList<ProvisionedClusterData>();
        }

        /// <summary> Initializes a new instance of ProvisionedClustersResponseListResult. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal ProvisionedClustersResponseListResult(IReadOnlyList<ProvisionedClusterData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ProvisionedClusterData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}