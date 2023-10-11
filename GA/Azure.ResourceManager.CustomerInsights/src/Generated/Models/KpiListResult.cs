// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list KPI operation. </summary>
    internal partial class KpiListResult
    {
        /// <summary> Initializes a new instance of KpiListResult. </summary>
        internal KpiListResult()
        {
            Value = new ChangeTrackingList<KpiResourceFormatData>();
        }

        /// <summary> Initializes a new instance of KpiListResult. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal KpiListResult(IReadOnlyList<KpiResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<KpiResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}