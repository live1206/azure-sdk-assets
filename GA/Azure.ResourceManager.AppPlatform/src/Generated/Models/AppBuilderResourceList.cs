// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of Builder resources and a possible link for next set. </summary>
    internal partial class AppBuilderResourceList
    {
        /// <summary> Initializes a new instance of AppBuilderResourceList. </summary>
        internal AppBuilderResourceList()
        {
            Value = new ChangeTrackingList<AppPlatformBuilderData>();
        }

        /// <summary> Initializes a new instance of AppBuilderResourceList. </summary>
        /// <param name="value"> Collection of Builder resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        internal AppBuilderResourceList(IReadOnlyList<AppPlatformBuilderData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of Builder resources. </summary>
        public IReadOnlyList<AppPlatformBuilderData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}