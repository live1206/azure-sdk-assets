// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> A list of cache usage models. </summary>
    internal partial class StorageCacheUsageModelsResult
    {
        /// <summary> Initializes a new instance of StorageCacheUsageModelsResult. </summary>
        internal StorageCacheUsageModelsResult()
        {
            Value = new ChangeTrackingList<StorageCacheUsageModel>();
        }

        /// <summary> Initializes a new instance of StorageCacheUsageModelsResult. </summary>
        /// <param name="nextLink"> The URI to fetch the next page of cache usage models. </param>
        /// <param name="value"> The list of usage models available for the subscription. </param>
        internal StorageCacheUsageModelsResult(string nextLink, IReadOnlyList<StorageCacheUsageModel> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The URI to fetch the next page of cache usage models. </summary>
        public string NextLink { get; }
        /// <summary> The list of usage models available for the subscription. </summary>
        public IReadOnlyList<StorageCacheUsageModel> Value { get; }
    }
}