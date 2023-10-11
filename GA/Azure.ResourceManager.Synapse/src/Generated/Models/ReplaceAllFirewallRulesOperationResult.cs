// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> An existing operation for replacing the firewall rules. </summary>
    public partial class ReplaceAllFirewallRulesOperationResult
    {
        /// <summary> Initializes a new instance of ReplaceAllFirewallRulesOperationResult. </summary>
        internal ReplaceAllFirewallRulesOperationResult()
        {
        }

        /// <summary> Initializes a new instance of ReplaceAllFirewallRulesOperationResult. </summary>
        /// <param name="operationId"> The operation ID. </param>
        internal ReplaceAllFirewallRulesOperationResult(string operationId)
        {
            OperationId = operationId;
        }

        /// <summary> The operation ID. </summary>
        public string OperationId { get; }
    }
}