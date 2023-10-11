// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The JSON-serialized array of IotHubQuotaMetricInfo objects with a next link. </summary>
    internal partial class IotHubQuotaMetricInfoListResult
    {
        /// <summary> Initializes a new instance of IotHubQuotaMetricInfoListResult. </summary>
        internal IotHubQuotaMetricInfoListResult()
        {
            Value = new ChangeTrackingList<IotHubQuotaMetricInfo>();
        }

        /// <summary> Initializes a new instance of IotHubQuotaMetricInfoListResult. </summary>
        /// <param name="value"> The array of quota metrics objects. </param>
        /// <param name="nextLink"> The next link. </param>
        internal IotHubQuotaMetricInfoListResult(IReadOnlyList<IotHubQuotaMetricInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The array of quota metrics objects. </summary>
        public IReadOnlyList<IotHubQuotaMetricInfo> Value { get; }
        /// <summary> The next link. </summary>
        public string NextLink { get; }
    }
}