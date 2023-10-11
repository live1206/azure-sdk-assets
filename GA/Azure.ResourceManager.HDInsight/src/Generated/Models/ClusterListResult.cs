// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The List Cluster operation response. </summary>
    internal partial class ClusterListResult
    {
        /// <summary> Initializes a new instance of ClusterListResult. </summary>
        internal ClusterListResult()
        {
            Value = new ChangeTrackingList<HDInsightClusterData>();
        }

        /// <summary> Initializes a new instance of ClusterListResult. </summary>
        /// <param name="value"> The list of Clusters. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal ClusterListResult(IReadOnlyList<HDInsightClusterData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of Clusters. </summary>
        public IReadOnlyList<HDInsightClusterData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}