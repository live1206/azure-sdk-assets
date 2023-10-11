// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The list private endpoint connections response. </summary>
    internal partial class HDInsightPrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of HDInsightPrivateEndpointConnectionListResult. </summary>
        internal HDInsightPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<HDInsightPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of HDInsightPrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> The list of private endpoint connections. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal HDInsightPrivateEndpointConnectionListResult(IReadOnlyList<HDInsightPrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of private endpoint connections. </summary>
        public IReadOnlyList<HDInsightPrivateEndpointConnectionData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}