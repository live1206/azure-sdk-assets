// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The StreamingEndpointSkuInfoListResult. </summary>
    internal partial class StreamingEndpointSkuInfoListResult
    {
        /// <summary> Initializes a new instance of StreamingEndpointSkuInfoListResult. </summary>
        internal StreamingEndpointSkuInfoListResult()
        {
            Value = new ChangeTrackingList<StreamingEndpointSkuInfo>();
        }

        /// <summary> Initializes a new instance of StreamingEndpointSkuInfoListResult. </summary>
        /// <param name="value"> The result of the List StreamingEndpoint skus. </param>
        internal StreamingEndpointSkuInfoListResult(IReadOnlyList<StreamingEndpointSkuInfo> value)
        {
            Value = value;
        }

        /// <summary> The result of the List StreamingEndpoint skus. </summary>
        public IReadOnlyList<StreamingEndpointSkuInfo> Value { get; }
    }
}