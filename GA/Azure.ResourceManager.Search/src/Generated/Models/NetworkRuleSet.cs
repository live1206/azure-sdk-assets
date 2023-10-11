// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Network specific rules that determine how the Azure Cognitive Search service may be reached. </summary>
    internal partial class NetworkRuleSet
    {
        /// <summary> Initializes a new instance of NetworkRuleSet. </summary>
        public NetworkRuleSet()
        {
            IPRules = new ChangeTrackingList<SearchServiceIPRule>();
        }

        /// <summary> Initializes a new instance of NetworkRuleSet. </summary>
        /// <param name="ipRules"> A list of IP restriction rules that defines the inbound network(s) with allowing access to the search service endpoint. At the meantime, all other public IP networks are blocked by the firewall. These restriction rules are applied only when the 'publicNetworkAccess' of the search service is 'enabled'; otherwise, traffic over public interface is not allowed even with any public IP rules, and private endpoint connections would be the exclusive access method. </param>
        internal NetworkRuleSet(IList<SearchServiceIPRule> ipRules)
        {
            IPRules = ipRules;
        }

        /// <summary> A list of IP restriction rules that defines the inbound network(s) with allowing access to the search service endpoint. At the meantime, all other public IP networks are blocked by the firewall. These restriction rules are applied only when the 'publicNetworkAccess' of the search service is 'enabled'; otherwise, traffic over public interface is not allowed even with any public IP rules, and private endpoint connections would be the exclusive access method. </summary>
        public IList<SearchServiceIPRule> IPRules { get; }
    }
}