// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Collection of metadata for the app configuration snapshots that can be restored. </summary>
    internal partial class SiteConfigurationSnapshotInfoListResult
    {
        /// <summary> Initializes a new instance of SiteConfigurationSnapshotInfoListResult. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SiteConfigurationSnapshotInfoListResult(IEnumerable<SiteConfigurationSnapshotInfo> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SiteConfigurationSnapshotInfoListResult. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal SiteConfigurationSnapshotInfoListResult(IReadOnlyList<SiteConfigurationSnapshotInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<SiteConfigurationSnapshotInfo> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}