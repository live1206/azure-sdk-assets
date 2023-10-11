// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Search;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing a list of Shared Private Link Resources. </summary>
    internal partial class SharedPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of SharedPrivateLinkResourceListResult. </summary>
        internal SharedPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<SharedSearchServicePrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of SharedPrivateLinkResourceListResult. </summary>
        /// <param name="value"> The list of Shared Private Link Resources. </param>
        /// <param name="nextLink"> The URL to get the next set of shared private link resources, if there are any. </param>
        internal SharedPrivateLinkResourceListResult(IReadOnlyList<SharedSearchServicePrivateLinkResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of Shared Private Link Resources. </summary>
        public IReadOnlyList<SharedSearchServicePrivateLinkResourceData> Value { get; }
        /// <summary> The URL to get the next set of shared private link resources, if there are any. </summary>
        public string NextLink { get; }
    }
}