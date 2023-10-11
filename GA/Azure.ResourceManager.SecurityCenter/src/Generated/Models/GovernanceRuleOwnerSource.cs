// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Describe the owner source of governance rule. </summary>
    public partial class GovernanceRuleOwnerSource
    {
        /// <summary> Initializes a new instance of GovernanceRuleOwnerSource. </summary>
        public GovernanceRuleOwnerSource()
        {
        }

        /// <summary> Initializes a new instance of GovernanceRuleOwnerSource. </summary>
        /// <param name="sourceType"> The owner type for the governance rule owner source. </param>
        /// <param name="value"> The source value e.g. tag key like owner name or email address. </param>
        internal GovernanceRuleOwnerSource(GovernanceRuleOwnerSourceType? sourceType, string value)
        {
            SourceType = sourceType;
            Value = value;
        }

        /// <summary> The owner type for the governance rule owner source. </summary>
        public GovernanceRuleOwnerSourceType? SourceType { get; set; }
        /// <summary> The source value e.g. tag key like owner name or email address. </summary>
        public string Value { get; set; }
    }
}