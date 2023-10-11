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
    /// <summary> The List Galleries operation response. </summary>
    internal partial class GalleryList
    {
        /// <summary> Initializes a new instance of GalleryList. </summary>
        /// <param name="value"> A list of galleries. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal GalleryList(IEnumerable<GalleryData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of GalleryList. </summary>
        /// <param name="value"> A list of galleries. </param>
        /// <param name="nextLink"> The uri to fetch the next page of galleries. Call ListNext() with this to fetch the next page of galleries. </param>
        internal GalleryList(IReadOnlyList<GalleryData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of galleries. </summary>
        public IReadOnlyList<GalleryData> Value { get; }
        /// <summary> The uri to fetch the next page of galleries. Call ListNext() with this to fetch the next page of galleries. </summary>
        public string NextLink { get; }
    }
}