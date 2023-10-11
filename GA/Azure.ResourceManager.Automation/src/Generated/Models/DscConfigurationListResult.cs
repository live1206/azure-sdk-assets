// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list configuration operation. </summary>
    internal partial class DscConfigurationListResult
    {
        /// <summary> Initializes a new instance of DscConfigurationListResult. </summary>
        internal DscConfigurationListResult()
        {
            Value = new ChangeTrackingList<DscConfigurationData>();
        }

        /// <summary> Initializes a new instance of DscConfigurationListResult. </summary>
        /// <param name="value"> Gets or sets a list of configurations. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        /// <param name="totalCount"> Gets the total number of configurations matching filter criteria. </param>
        internal DscConfigurationListResult(IReadOnlyList<DscConfigurationData> value, string nextLink, int? totalCount)
        {
            Value = value;
            NextLink = nextLink;
            TotalCount = totalCount;
        }

        /// <summary> Gets or sets a list of configurations. </summary>
        public IReadOnlyList<DscConfigurationData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets the total number of configurations matching filter criteria. </summary>
        public int? TotalCount { get; }
    }
}