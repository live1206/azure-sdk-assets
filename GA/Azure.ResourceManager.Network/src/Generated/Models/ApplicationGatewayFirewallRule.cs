// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A web application firewall rule. </summary>
    public partial class ApplicationGatewayFirewallRule
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFirewallRule. </summary>
        /// <param name="ruleId"> The identifier of the web application firewall rule. </param>
        public ApplicationGatewayFirewallRule(int ruleId)
        {
            RuleId = ruleId;
        }

        /// <summary> Initializes a new instance of ApplicationGatewayFirewallRule. </summary>
        /// <param name="ruleId"> The identifier of the web application firewall rule. </param>
        /// <param name="ruleIdString"> The string representation of the web application firewall rule identifier. </param>
        /// <param name="state"> The string representation of the web application firewall rule state. </param>
        /// <param name="action"> The string representation of the web application firewall rule action. </param>
        /// <param name="description"> The description of the web application firewall rule. </param>
        internal ApplicationGatewayFirewallRule(int ruleId, string ruleIdString, ApplicationGatewayWafRuleStateType? state, ApplicationGatewayWafRuleActionType? action, string description)
        {
            RuleId = ruleId;
            RuleIdString = ruleIdString;
            State = state;
            Action = action;
            Description = description;
        }

        /// <summary> The identifier of the web application firewall rule. </summary>
        public int RuleId { get; set; }
        /// <summary> The string representation of the web application firewall rule identifier. </summary>
        public string RuleIdString { get; set; }
        /// <summary> The string representation of the web application firewall rule state. </summary>
        public ApplicationGatewayWafRuleStateType? State { get; set; }
        /// <summary> The string representation of the web application firewall rule action. </summary>
        public ApplicationGatewayWafRuleActionType? Action { get; set; }
        /// <summary> The description of the web application firewall rule. </summary>
        public string Description { get; set; }
    }
}