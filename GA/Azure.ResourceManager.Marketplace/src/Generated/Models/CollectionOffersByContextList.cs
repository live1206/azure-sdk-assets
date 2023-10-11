// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> List of objects which describes offers per context. An empty GUID is a public context. </summary>
    internal partial class CollectionOffersByContextList
    {
        /// <summary> Initializes a new instance of CollectionOffersByContextList. </summary>
        internal CollectionOffersByContextList()
        {
            Value = new ChangeTrackingList<CollectionOffersByContext>();
        }

        /// <summary> Initializes a new instance of CollectionOffersByContextList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of offer list per context results if there are any. </param>
        internal CollectionOffersByContextList(IReadOnlyList<CollectionOffersByContext> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<CollectionOffersByContext> Value { get; }
        /// <summary> URL to get the next set of offer list per context results if there are any. </summary>
        public string NextLink { get; }
    }
}