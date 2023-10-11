// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Redis;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> The response of list firewall rules Redis operation. </summary>
    internal partial class RedisFirewallRuleListResult
    {
        /// <summary> Initializes a new instance of RedisFirewallRuleListResult. </summary>
        internal RedisFirewallRuleListResult()
        {
            Value = new ChangeTrackingList<RedisFirewallRuleData>();
        }

        /// <summary> Initializes a new instance of RedisFirewallRuleListResult. </summary>
        /// <param name="value"> Results of the list firewall rules operation. </param>
        /// <param name="nextLink"> Link for next page of results. </param>
        internal RedisFirewallRuleListResult(IReadOnlyList<RedisFirewallRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list firewall rules operation. </summary>
        public IReadOnlyList<RedisFirewallRuleData> Value { get; }
        /// <summary> Link for next page of results. </summary>
        public string NextLink { get; }
    }
}