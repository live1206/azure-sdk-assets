// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The UnknownFirewallPolicyRuleCollection. </summary>
    internal partial class UnknownFirewallPolicyRuleCollection : FirewallPolicyRuleCollectionInfo
    {
        /// <summary> Initializes a new instance of UnknownFirewallPolicyRuleCollection. </summary>
        /// <param name="ruleCollectionType"> The type of the rule collection. </param>
        /// <param name="name"> The name of the rule collection. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Collection resource. </param>
        internal UnknownFirewallPolicyRuleCollection(FirewallPolicyRuleCollectionType ruleCollectionType, string name, int? priority) : base(ruleCollectionType, name, priority)
        {
            RuleCollectionType = ruleCollectionType;
        }
    }
}
