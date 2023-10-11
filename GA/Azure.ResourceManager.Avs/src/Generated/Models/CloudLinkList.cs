// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A paged list of cloud links. </summary>
    internal partial class CloudLinkList
    {
        /// <summary> Initializes a new instance of CloudLinkList. </summary>
        internal CloudLinkList()
        {
            Value = new ChangeTrackingList<AvsCloudLinkData>();
        }

        /// <summary> Initializes a new instance of CloudLinkList. </summary>
        /// <param name="value"> The items on a page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal CloudLinkList(IReadOnlyList<AvsCloudLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on a page. </summary>
        public IReadOnlyList<AvsCloudLinkData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}