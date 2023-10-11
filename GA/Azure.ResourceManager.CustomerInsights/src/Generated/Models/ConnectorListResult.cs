// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list connector operation. </summary>
    internal partial class ConnectorListResult
    {
        /// <summary> Initializes a new instance of ConnectorListResult. </summary>
        internal ConnectorListResult()
        {
            Value = new ChangeTrackingList<ConnectorResourceFormatData>();
        }

        /// <summary> Initializes a new instance of ConnectorListResult. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal ConnectorListResult(IReadOnlyList<ConnectorResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<ConnectorResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}