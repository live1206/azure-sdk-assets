// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of usages. </summary>
    internal partial class InstancePoolUsageListResult
    {
        /// <summary> Initializes a new instance of InstancePoolUsageListResult. </summary>
        internal InstancePoolUsageListResult()
        {
            Value = new ChangeTrackingList<InstancePoolUsage>();
        }

        /// <summary> Initializes a new instance of InstancePoolUsageListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal InstancePoolUsageListResult(IReadOnlyList<InstancePoolUsage> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<InstancePoolUsage> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}