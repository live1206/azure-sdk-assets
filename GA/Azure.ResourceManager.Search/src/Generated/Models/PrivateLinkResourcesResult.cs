// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing a list of supported Private Link Resources. </summary>
    internal partial class PrivateLinkResourcesResult
    {
        /// <summary> Initializes a new instance of PrivateLinkResourcesResult. </summary>
        internal PrivateLinkResourcesResult()
        {
            Value = new ChangeTrackingList<SearchPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResourcesResult. </summary>
        /// <param name="value"> The list of supported Private Link Resources. </param>
        internal PrivateLinkResourcesResult(IReadOnlyList<SearchPrivateLinkResource> value)
        {
            Value = value;
        }

        /// <summary> The list of supported Private Link Resources. </summary>
        public IReadOnlyList<SearchPrivateLinkResource> Value { get; }
    }
}