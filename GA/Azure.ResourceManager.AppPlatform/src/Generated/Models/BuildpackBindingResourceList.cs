// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of BuildpackBinding resources and a possible link for next set. </summary>
    internal partial class BuildpackBindingResourceList
    {
        /// <summary> Initializes a new instance of BuildpackBindingResourceList. </summary>
        internal BuildpackBindingResourceList()
        {
            Value = new ChangeTrackingList<AppPlatformBuildpackBindingData>();
        }

        /// <summary> Initializes a new instance of BuildpackBindingResourceList. </summary>
        /// <param name="value"> Collection of BuildpackBinding resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        internal BuildpackBindingResourceList(IReadOnlyList<AppPlatformBuildpackBindingData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of BuildpackBinding resources. </summary>
        public IReadOnlyList<AppPlatformBuildpackBindingData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}