// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Security admin configuration rule collection list result. </summary>
    internal partial class AdminRuleGroupListResult
    {
        /// <summary> Initializes a new instance of AdminRuleGroupListResult. </summary>
        internal AdminRuleGroupListResult()
        {
            Value = new ChangeTrackingList<AdminRuleGroupData>();
        }

        /// <summary> Initializes a new instance of AdminRuleGroupListResult. </summary>
        /// <param name="value"> A list of network manager security admin configuration rule collections. </param>
        /// <param name="nextLink"> Gets the URL to get the next set of results. </param>
        internal AdminRuleGroupListResult(IReadOnlyList<AdminRuleGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of network manager security admin configuration rule collections. </summary>
        public IReadOnlyList<AdminRuleGroupData> Value { get; }
        /// <summary> Gets the URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}