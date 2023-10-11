// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Gallery Application version operation response. </summary>
    internal partial class GalleryApplicationVersionList
    {
        /// <summary> Initializes a new instance of GalleryApplicationVersionList. </summary>
        /// <param name="value"> A list of gallery Application Versions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal GalleryApplicationVersionList(IEnumerable<GalleryApplicationVersionData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of GalleryApplicationVersionList. </summary>
        /// <param name="value"> A list of gallery Application Versions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of gallery Application Versions. Call ListNext() with this to fetch the next page of gallery Application Versions. </param>
        internal GalleryApplicationVersionList(IReadOnlyList<GalleryApplicationVersionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of gallery Application Versions. </summary>
        public IReadOnlyList<GalleryApplicationVersionData> Value { get; }
        /// <summary> The uri to fetch the next page of gallery Application Versions. Call ListNext() with this to fetch the next page of gallery Application Versions. </summary>
        public string NextLink { get; }
    }
}
