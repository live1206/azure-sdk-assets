// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of provider permissions. </summary>
    internal partial class ProviderPermissionListResult
    {
        /// <summary> Initializes a new instance of ProviderPermissionListResult. </summary>
        internal ProviderPermissionListResult()
        {
            Value = new ChangeTrackingList<ProviderPermission>();
        }

        /// <summary> Initializes a new instance of ProviderPermissionListResult. </summary>
        /// <param name="value"> An array of provider permissions. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ProviderPermissionListResult(IReadOnlyList<ProviderPermission> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of provider permissions. </summary>
        public IReadOnlyList<ProviderPermission> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
